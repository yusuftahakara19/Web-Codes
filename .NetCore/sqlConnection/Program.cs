using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using MySql.Data.MySqlClient;



namespace sqlConnection
{

    /*
    Data Access Layer (Veri Erişim Katmanı), bir uygulamanın veritabanı ile iletişim kurduğu ve veri işleme işlemlerini gerçekleştirdiği bir katmandır.
    */
    public interface IProductDal
    {
        List<Product> GetAllProducts();
        Product GetProductById(int id);
        List<Product> Find(string productName);
        void Create(Product p);
        void Update(Product p);
        void Delete(int productId);
        int Count();
    }

    public class MySQLProductDal : IProductDal
    {
        private MySqlConnection GetMySqlConnection()
        {
            string connectionString = @"server=localhost;port=3306;database=northwind;user=root;password=mysql123";

            return new MySqlConnection(connectionString);
        }

        public void Create(Product p)
        {
            using (var connection = GetMySqlConnection())
            {
                try
                {
                    connection.Open();
                    string sqlQuery = "insert into products (product_name,list_price,discontinued) values (@product_name,@listPrice,@discontinued)";
                    MySqlCommand command = new MySqlCommand(sqlQuery, connection);

                    command.Parameters.AddWithValue("@product_name", p.Name);
                    command.Parameters.AddWithValue("@listPrice", p.Price);
                    command.Parameters.AddWithValue("@discontinued", 1);

                    int result = command.ExecuteNonQuery();

                    Console.WriteLine($"{result} adet kayıt eklendi");
                }
                catch (System.Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public void Delete(int productId)
        {
            using (var connection = GetMySqlConnection())
            {
                try
                {
                    connection.Open();
                    string sqlQuery = "DELETE FROM products where id = @productId";
                    MySqlCommand command = new MySqlCommand(sqlQuery, connection);

                    command.Parameters.AddWithValue("@productId", productId);

                    int result = command.ExecuteNonQuery();

                    Console.WriteLine($"{result} adet kayıt silindi");
                }
                catch (System.Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public List<Product> GetAllProducts()
        {
            List<Product> products = null;
            using (var connection = GetMySqlConnection())
            {
                try
                {
                    connection.Open();

                    string sqlQuery = "Select * From Products";

                    MySqlCommand command = new MySqlCommand(sqlQuery, connection);

                    MySqlDataReader reader = command.ExecuteReader();

                    products = new List<Product>();


                    while (reader.Read())
                    {
                        products.Add(new Product
                        {
                            ProductId = int.Parse(reader["id"].ToString()),// gelen obje türünde o yüzden önce stringe sonra int'e çevirdik 
                            Name = reader["product_name"].ToString(),
                            Price = double.Parse(reader["list_price"]?.ToString())//null olabileceğini de belirttik
                        });


                    }

                    reader.Close();

                }
                catch (System.Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            return products;
        }

        public Product GetProductById(int id)
        {
            Product product = null;
            using (var connection = GetMySqlConnection())
            {
                try
                {
                    connection.Open();

                    // sql injection
                    string sqlQuery = "Select * From Products where id=@productId";

                    MySqlCommand command = new MySqlCommand(sqlQuery, connection);

                    command.Parameters.Add("@productId", MySqlDbType.Int32).Value = id; // önce tipi sonra hangi parametrenin gideceği.    

                    MySqlDataReader reader = command.ExecuteReader();

                    reader.Read();


                    // böyle bir kayıdın gelip gelmediği
                    if (reader.HasRows)
                    {
                        product = new Product()
                        {
                            ProductId = int.Parse(reader["id"].ToString()),

                            Name = reader["product_name"].ToString(),
                            Price = double.Parse(reader["list_price"]?.ToString())
                        };
                    }


                    reader.Close();
                }

                catch (System.Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            return product;
        }

        public void Update(Product p)
        {
            using (var connection = GetMySqlConnection())
            {
                try
                {
                    connection.Open();
                    string sqlQuery = "update products set product_name=@productname, list_price=@price where id = @productId";
                    MySqlCommand command = new MySqlCommand(sqlQuery, connection);

                    command.Parameters.AddWithValue("@productname", p.Name);
                    command.Parameters.AddWithValue("@price", p.Price);
                    command.Parameters.AddWithValue("@productId", p.ProductId);

                    int result = command.ExecuteNonQuery();

                    Console.WriteLine($"{result} adet kayıt guncellendi");
                }
                catch (System.Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public List<Product> Find(string productName)
        {
            List<Product> products = new List<Product>();
            using (var connection = GetMySqlConnection())
            {
                try
                {
                    connection.Open();

                    // sql injection
                    string sqlQuery = "Select * From Products where product_name LIKE @productName";

                    MySqlCommand command = new MySqlCommand(sqlQuery, connection);
                    command.Parameters.AddWithValue("@productName", "%" + productName + "%");

                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {

                        products.Add(
                          new Product
                          {
                              ProductId = int.Parse(reader["id"].ToString()),
                              Name = reader["product_name"].ToString(),
                              Price = double.Parse(reader["list_price"]?.ToString())
                          }
                        );


                    }

                    reader.Close();
                }

                catch (System.Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            return products;
        }

        public int Count()
        {
            int count = 0;
            using (var connection = GetMySqlConnection())
            {
                try
                {
                    connection.Open();

                    // sql injection
                    string sqlQuery = "Select Count(*) From Products";

                    MySqlCommand command = new MySqlCommand(sqlQuery, connection);

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        count = int.Parse(result.ToString());
                    }
                }

                catch (System.Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            return count;
        }
    }

    public class MsSQLProductDal : IProductDal
    {
        private SqlConnection GetMsSqlConnection()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=ShopApp;Integrated Security=SSPI;";

            return new SqlConnection(connectionString);
        }

        public void Create(Product p)
        {
            throw new NotImplementedException();
        }

        public void Delete(int productId)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllProducts()
        {
            List<Product> products = null;
            using (var connection = GetMsSqlConnection())
            {
                try
                {
                    connection.Open();

                    string sqlQuery = "Select * From Products";

                    SqlCommand command = new SqlCommand(sqlQuery, connection);

                    SqlDataReader reader = command.ExecuteReader();

                    products = new List<Product>();


                    while (reader.Read())
                    {
                        products.Add(new Product
                        {
                            ProductId = int.Parse(reader["ProductID"].ToString()),// gelen obje türünde o yüzden önce stringe sonra int'e çevirdik 
                            Name = reader["ProductName"].ToString(),
                            Price = double.Parse(reader["UnitPrice"]?.ToString())//null olabileceğini de belirttik
                        });


                    }

                    reader.Close();

                }
                catch (System.Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            return products;
        }

        public Product GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product p)
        {
            throw new NotImplementedException();
        }

        public List<Product> Find(string productName)
        {
            throw new NotImplementedException();
        }

        public int Count()
        {
            throw new NotImplementedException();
        }
    }

    public class ProductManager : IProductDal
    {

        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public int Count()
        {
            return _productDal.Count();
        }

        public void Create(Product p)
        {
            _productDal.Create(p);
        }

        public void Delete(int productId)
        {
            _productDal.Delete(productId);
        }

        public List<Product> Find(string productName)
        {
            return _productDal.Find(productName);
        }

        public List<Product> GetAllProducts()
        {
            return _productDal.GetAllProducts();
        }

        public Product GetProductById(int id)
        {
            return _productDal.GetProductById(id);
        }

        public void Update(Product p)
        {
            _productDal.Update(p);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            var productManager = new ProductManager(new MySQLProductDal());
            productManager.Delete(100);




        }

        static void GetSqlConnection()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=ShopApp;Integrated Security=SSPI;";

            // oluşturulan nesne using bloğu dışına çıkınca otomatik olarark silinir

            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Bağlantı sağlandı");
                }
                catch (System.Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

        }
    }

}
