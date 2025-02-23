using System;
using System.Data;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using Azure;
using Microsoft.Data.SqlClient;
using Shop.DataAccess;

namespace Shop.BusinessLogic
{
    public class UserServices
    {
        private readonly DbContext _context;

        public UserServices(string connectionString)
        {
            _context = new DbContext(connectionString);
        }

        #region Register
        public bool RegisterUser(string username, string password, string email, int age, string address)
        {
            // Check if the username or email already exists
            if (IsEmailTaken(email) || IsUsernameTaken(username))
            {
                return false; // User already exists
            }

            // Hash the password before storing it
            string hashedPassword = HashPassword(password);

            // Add user to the database
            string query = @"
                INSERT INTO Users (Username, Password, Email, Age, Address, Role)
                VALUES (@Username, @Password, @Email, @Age, @Address, 'User');
            ";

            SqlParameter[] parameters = {
                new SqlParameter("@Username", username),
                new SqlParameter("@Password", hashedPassword),
                new SqlParameter("@Email", email),
                new SqlParameter("@Age", age),
                new SqlParameter("@Address", address)
            };

            int rowsAffected = _context.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }
        #endregion

        #region
        //login
       static int USERID;
        public int GetUser()
        {
            return USERID;
        }
        
        public string LoginUser(string userName, string password)
        {
            //GetUser(userName);
            string? role = null;
            try
            {
                const string query = "SELECT Password, UserId , Role FROM Users WHERE Username = @Username";
                SqlParameter[] parameters =
                {
                      new SqlParameter("@Username", userName)
                };

                DataTable userData = _context.ExecuteQuery(query, parameters);

                if (userData.Rows.Count > 0)
                {
                    string storedPassword = userData.Rows[0]["Password"]?.ToString() ?? string.Empty;
                    USERID =(int)userData.Rows[0]["UserId"];
                    if (HashPassword(password) == storedPassword)
                    {
                        role = userData.Rows[0]["Role"]?.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❗ Error during login for user '{userName}': {ex.Message}");
            }
            //if (role == "User") { }
            return role;
        }
        #endregion

        #region admin operation
        public DataTable GetAllUsers()
        {
            string query = "SELECT UserId, Username, Email, Age, Address, Role FROM Users";
            return _context.ExecuteQuery(query, null);

        }
        public DataTable GetUserById(int id)
        {

            string query = @"SELECT Username, Email, Age, Address, Role , Password FROM Users WHERE UserId = @id";

            SqlParameter[] parameters = { new SqlParameter("@id", id) };

            try
            {
                return _context.ExecuteQuery(query, parameters);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while retrieving user data.", ex);
            }
        }
        public (bool isSuccess, string message) AddUser(string username, string password, string email, int age, string address, bool isAdmin)
        {
            if (IsUsernameTaken(username))
                return (false, "❗ Username is already taken.");

            if (IsEmailTaken(email))
                return (false, "❗ Email is already registered.");
            var validmassage =  ValidateUserInput(username, email, password, password, age);
            if (!validmassage.isValid)
                return (false, validmassage.message);
            string hashedPassword = HashPassword(password);
            string role = isAdmin ? "Admin" : "User";

            string query = @"
        INSERT INTO Users (Username, Password, Email, Age, Address, Role)
        VALUES (@Username, @Password, @Email, @Age, @Address, @Role);";

            SqlParameter[] parameters = {
        new SqlParameter("@Username", username),
        new SqlParameter("@Password", hashedPassword),
        new SqlParameter("@Email", email),
        new SqlParameter("@Age", age),
        new SqlParameter("@Address", address),
        new SqlParameter("@Role", role)
    };

            int rowsAffected = _context.ExecuteNonQuery(query, parameters);

            if (rowsAffected > 0)
                return (true, "✅ User added successfully.");
            else
                return (false, "⚠️ Failed to add user due to a database error.");
        }
        public bool UpdateUser(int userId, string username, string email, int age, string address, bool isAdmin)
        {
            string role = isAdmin ? "Admin" : "User";
            string query = @"
                UPDATE Users 
                SET Username = @Username, Email = @Email, Age = @Age, Address = @Address, Role = @Role 
                WHERE UserId = @UserId;";

            SqlParameter[] parameters = {
                new SqlParameter("@UserId", userId),
                new SqlParameter("@Username", username),
                new SqlParameter("@Email", email),
                new SqlParameter("@Age", age),
                new SqlParameter("@Address", address),
                new SqlParameter("@Role", role)
            };

            return _context.ExecuteNonQuery(query, parameters) > 0;
        }
        public bool DeleteUser(int userId)
        {
            string query = "DELETE FROM Users WHERE UserId = @UserId";
            SqlParameter[] parameters = { new SqlParameter("@UserId", userId) };

            return _context.ExecuteNonQuery(query, parameters) > 0;
        }
        #endregion

        #region UsedMethod
        public (bool isValid, string message) ValidateUserInput(string username, string email, string password, string confirmPassword, int age)
        {
            // Validate username
            if (string.IsNullOrWhiteSpace(username))
            {
                return (false, "Username is invalid. It must contain text.");
            }

            // Validate email format
            if (!Regex.IsMatch(email, @"^[^@\s]+@gmail\.com$"))
            {
                return (false, "Email is invalid. It must be in the format 'name@gmail.com'.");
            }

            // Validate password length
            if (password.Length < 6)
            {
                return (false, "Password is invalid. It must be at least 6 characters long.");
            }

            // Validate password match
            if (password != confirmPassword)
            {
                return (false, "Passwords do not match.");
            }

            // Validate age
            if (age <= 0)
            {
                return (false, "Age is invalid. It must be greater than 0.");
            }

            return (true, "Validation successful.");
        }
        public (string username, string password, string confirmPassword, string email, int age, string address) GetDefaultUserValues()
        {
            return ("", "", "", "", 0, "");
        }
        public bool IsUsernameTaken(string username)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
            SqlParameter[] parameters = {
        new SqlParameter("@Username", username)
    };

            int count = Convert.ToInt32(_context.ExecuteScalar(query, parameters));
            return count > 0;
        }
        public bool IsEmailTaken(string email)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE Email = @Email";
            SqlParameter[] parameters = {
        new SqlParameter("@Email", email)
    };

            int count = Convert.ToInt32(_context.ExecuteScalar(query, parameters));
            return count > 0;
        }
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }
        #endregion

        public bool ChangePassword(int userId,int password)
        {           
            string query = @"
                UPDATE Users 
                SET  Password = @password
                WHERE UserId = @UserId;";

            SqlParameter[] parameters = {
                new SqlParameter("@UserId", userId),
                
                new SqlParameter("@password", password)
            };

            return _context.ExecuteNonQuery(query, parameters) > 0;
        }
        public bool UpdatePassword(int userId, string newPassword)
        {
            try
            {
                string query = "UPDATE Users SET Password = @Password WHERE UserId = @UserId";
                SqlParameter[] parameters =
                {
            new SqlParameter("@Password", newPassword),
            new SqlParameter("@UserId", userId)
        };

                int rowsAffected = _context.ExecuteNonQuery(query, parameters);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while updating the password.", ex);
            }
        }

    }
}