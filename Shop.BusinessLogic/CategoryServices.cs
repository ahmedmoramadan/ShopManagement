using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Shop.DataAccess;

namespace Shop.BusinessLogic
{
    public class CategoryServices
    {
        private readonly DbContext _context;

        public CategoryServices(string connectionString)
        {
            _context = new DbContext(connectionString);
        }
       
        public DataTable GetAllCategories()
        {
            string query = "SELECT CategoryId, CategoryName FROM Categories";
            return _context.ExecuteQuery(query, null);
        }

        public (bool Success, string Message) Add(string category)
        {
            if (string.IsNullOrWhiteSpace(category))
            {
                return (false, "Category name cannot be empty.");
            }

            try
            {
                string query = "INSERT INTO Categories (CategoryName) VALUES (@CategoryName)";
                SqlParameter[] parameters =
                {
            new SqlParameter("@CategoryName", category)
        };

                int rowsAffected = _context.ExecuteNonQuery(query, parameters);
                if (rowsAffected > 0)
                {
                    return (true, "Category added successfully!");
                }
                else
                {
                    return (false, "Failed to add category.");
                }
            }
            catch (Exception ex)
            {
                // Log the exception (consider using a logging framework like NLog, Serilog, etc.)
                // Logger.LogError(ex, "An error occurred while adding a category.");

                return (false, $"An error occurred: {ex.Message}");
            }
        }

        public DataTable GetById(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Category ID must be greater than zero.");
            }

            // Define the SQL query
            string query = "SELECT CategoryId, CategoryName FROM Categories WHERE CategoryId = @CategoryId";

            // Create the SqlParameter for the ID
            SqlParameter[] parameters =
            {
        new SqlParameter("@CategoryId", id)
    };

            // Execute the query and return the resulting DataTable
            return _context.ExecuteQuery(query, parameters);
        }

        public (bool Success, string Message) Update(string category ,int cid)
        {
            // Validate the input
            if (string.IsNullOrWhiteSpace(category))
            {
                return (false, "Category name cannot be empty.");
            }

            // Define the SQL query
            string query = "UPDATE Categories SET CategoryName = @CategoryName WHERE CategoryId = @CategoryId";

            // Create the SqlParameter array
            SqlParameter[] parameters =
            {
        new SqlParameter("@CategoryName", category),
        new SqlParameter("@CategoryId", cid) // Assuming C_id is the current category ID
    };

            // Execute the query
            int rowsAffected = _context.ExecuteNonQuery(query, parameters);

            // Check if the update was successful
            if (rowsAffected > 0)
            {
                return (true, "Category updated successfully!");
            }
            else
            {
                return (false, "Failed to update category. Category ID may not exist.");
            }
        }
        public bool DeleteCategory(int categoryId)
        {
            // Define the SQL query to delete a category by its ID
            string query = "DELETE FROM Categories WHERE CategoryId = @CategoryId";

            // Create the SQL parameter for the category ID
            SqlParameter[] parameters = { new SqlParameter("@CategoryId", categoryId) };

            // Execute the query and check if any rows were affected
            return _context.ExecuteNonQuery(query, parameters) > 0;
        }



    }
}
