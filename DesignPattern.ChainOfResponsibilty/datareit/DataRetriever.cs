using DesignPattern.ChainOfResponsibilty.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.ChainOfResponsibilty.datareit
{
    public class DataRetriever
    {
        public List<CustomerProcessViewModel> GetCustomerProcessesFromDatabase()
        {
            List<CustomerProcessViewModel> customerProcesses = new List<CustomerProcessViewModel>();

            string connectionString = "server=DESKTOP-J1MPADH\\SABRI; database=DesignPattern1;integrated security=true";
            string query = "SELECT * FROM CustomerProcesses";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            CustomerProcessViewModel process = new CustomerProcessViewModel
                            {
                                CustomerProcessID = Convert.ToInt32(reader["CustomerProcessID"]),
                                Name = reader["Name"].ToString(),
                                Amount = Convert.ToInt32(reader["Amount"]),
                                EmployeeName = reader["EmployeeName"].ToString(),
                                Description = reader["Description"].ToString()
                            };

                            customerProcesses.Add(process);
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        // Hata yönetimi burada yapılabilir, örneğin bir hata sayfasına yönlendirme
                    }
                }
            }

            return customerProcesses;
        }
    }
}
