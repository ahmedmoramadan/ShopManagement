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
    public class ProductServices
    {
        private readonly DbContext _context;
        public ProductServices(string con)
        {
            _context = new DbContext(con);
        }

        public DataTable GetAllProducts()
        {
            string query = "SELECT ProductId,ProductName ,Price ,CategoryId FROM Products";
            return _context.ExecuteQuery(query, null);
        }

        public DataTable GetById(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("ProductId ID must be greater than zero.");
            }

            // Define the SQL query
            string query = "SELECT ProductId,ProductName ,Price ,CategoryId FROM Products WHERE ProductId = @ProductId";

            // Create the SqlParameter for the ID
            SqlParameter[] parameters =
            {
        new SqlParameter("@ProductId", id)
    };

            // Execute the query and return the resulting DataTable
            return _context.ExecuteQuery(query, parameters);
        }

        public (bool Success, string Message) Update(string ProductName,decimal Price , int Pid, int cid)
        {
            // Validate the input
            if (string.IsNullOrWhiteSpace(ProductName) || Price <= 0 || cid <=0)
            {
                return (false, "fields can\'t be empty.");
            }

            // Define the SQL query
            string query = " UPDATE Products SET ProductName = @ProductName , price = @price , CategoryId = @CategoryId WHERE ProductId = @ProductId";



            // Create the SqlParameter array
            SqlParameter[] parameters =
            {
                 new SqlParameter("@ProductName", ProductName),
                 new SqlParameter("@price" , Price),
                 new SqlParameter("@ProductId",Pid ),
                 new SqlParameter("@CategoryId", cid) 
            };

            // Execute the query
            int rowsAffected = _context.ExecuteNonQuery(query, parameters);

            // Check if the update was successful
            if (rowsAffected > 0)
            {
                return (true, "Product updated successfully!");
            }
            else
            {
                return (false, "Failed to update Product.");
            }
        }
        public bool Delete(int ProductId)
        {
            // Define the SQL query to delete a category by its ID
            string query = "DELETE FROM Products WHERE ProductId = @ProductId";

            // Create the SQL parameter for the category ID
            SqlParameter[] parameters = { new SqlParameter("@ProductId", ProductId) };

            // Execute the query and check if any rows were affected
            return _context.ExecuteNonQuery(query, parameters) > 0;
        }

        public (bool Success, string Message) Add(string ProductName , decimal price , int Cid )
        {
            if (string.IsNullOrWhiteSpace(ProductName) || price <= 0 || Cid<=0 )
            {
                return (false, "fields cannot be empty.");
            }

            try
            {
                string query = "INSERT INTO [Products] (ProductName ,Price , CategoryId)   VALUES (@ProductName ,@Price , @CategoryId )";
                SqlParameter[] parameters =
                {
            new SqlParameter("@ProductName", ProductName),
            new SqlParameter("@price",price),
            new SqlParameter("@CategoryId",Cid)
        };

                int rowsAffected = _context.ExecuteNonQuery(query, parameters);
                if (rowsAffected > 0)
                {
                    return (true, "Product added successfully!");
                }
                else
                {
                    return (false, "Failed to add Product.");
                }
            }
            catch (Exception ex)
            {
                // Log the exception (consider using a logging framework like NLog, Serilog, etc.)
                // Logger.LogError(ex, "An error occurred while adding a category.");

                return (false, $"An error occurred: {ex.Message}");
            }
        }



    }
}
