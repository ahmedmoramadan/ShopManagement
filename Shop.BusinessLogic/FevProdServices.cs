using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Shop.DataAccess;

namespace Shop.BusinessLogic
{
    public class FevProdServices
    {
        private readonly DbContext _context;

        public FevProdServices(string connectionString)
        {
            _context = new DbContext(connectionString);
        }

        public DataTable GetAll(int Cid)
        {
            string query = "SELECT UserId, f.ProductId, p.ProductName FROM Favorites f INNER JOIN Products p ON p.ProductId = f.ProductId where UserId = @id";
            SqlParameter[] parameters =
             {
                new SqlParameter("@id",Cid)
            };
            return _context.ExecuteQuery(query, parameters);
        }

        public (bool Success, string Message) Add(int UserId , int ProductId)
        {
           try
            {

                string query = "INSERT INTO Favorites (UserId, ProductId) VALUES (@UserId, @ProductId);";
                SqlParameter[] parameters =
                {
            new SqlParameter("@UserId", UserId),
            new SqlParameter("@ProductId" ,ProductId)
        };

                int rowsAffected = _context.ExecuteNonQuery(query, parameters);
                if (rowsAffected > 0)
                {
                    return (true, "Fav added successfully!");
                }
                else
                {
                    return (false, "Failed to add Fav. it is in ur fav already");
                }
            }
            catch (Exception ex)
            {
                // Log the exception (consider using a logging framework like NLog, Serilog, etc.)
                // Logger.LogError(ex, "An error occurred while adding a category.");

                return (false, $"An error occurred: {ex.Message}");
            }
        }

    //    public DataTable GetById(int pid, int Uid)
    //    {
    //        string query = "SELECT CategoryId, CategoryName FROM Categories WHERE CategoryId = @CategoryId";

    //        // Create the SqlParameter for the ID
    //        SqlParameter[] parameters =
    //        {
    //    new SqlParameter("@CategoryId", id),
    //};

    //        // Execute the query and return the resulting DataTable
    //        return _context.ExecuteQuery(query, parameters);
    //    }

    //    public (bool Success, string Message) Update(string category, int cid)
    //    {
    //        // Validate the input
    //        if (string.IsNullOrWhiteSpace(category))
    //        {
    //            return (false, "Category name cannot be empty.");
    //        }

    //        // Define the SQL query
    //        string query = "UPDATE Categories SET CategoryName = @CategoryName WHERE CategoryId = @CategoryId";

    //        // Create the SqlParameter array
    //        SqlParameter[] parameters =
    //        {
    //    new SqlParameter("@CategoryName", category),
    //    new SqlParameter("@CategoryId", cid) // Assuming C_id is the current category ID
    //};

    //        // Execute the query
    //        int rowsAffected = _context.ExecuteNonQuery(query, parameters);

    //        // Check if the update was successful
    //        if (rowsAffected > 0)
    //        {
    //            return (true, "Category updated successfully!");
    //        }
    //        else
    //        {
    //            return (false, "Failed to update category. Category ID may not exist.");
    //        }
    //    }
        public bool Delete(int PID , int Uid)
        {
            string query = "DELETE FROM Favorites WHERE ProductId = @ProductId AND UserId = @UserId";

            // تأكد من تطابق أسماء المعاملات مع الاستعلام
            SqlParameter[] parameters =
            {
        new SqlParameter("@ProductId", PID),
        new SqlParameter("@UserId", Uid)
    };

            // Execute the query and check if any rows were affected
            return _context.ExecuteNonQuery(query, parameters) > 0;
        }

    }
}
