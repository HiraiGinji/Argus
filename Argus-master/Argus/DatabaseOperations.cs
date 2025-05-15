using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls;
using System;
using System.Data;
using System.IO;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using MessagingToolkit.Barcode;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections.Generic;


namespace Argus
{
    public class DatabaseOperations
    {
        private MySqlConnection connection;
        private readonly byte[] EncryptionKey = Encoding.UTF8.GetBytes("pogiakohahaxd123");
        public DatabaseOperations()
        {
            string connectionString = "server=localhost;database=argus;user=root;password=;";
            connection = new MySqlConnection(connectionString);
        }

        public MySqlConnection getConnect
        {
            get { return connection; }
        }

        public void OpenConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error opening connection: " + ex.Message);
            }
        }

        public void CloseConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error closing connection: " + ex.Message);
            }
        }

        public bool InsertAccount(string firstName, string lastName, string email, string contactNo, string telephone, string password, string region, string city)
        {
            try
            {
                OpenConnection();

                string EncryptedPassword = EncryptPassword(password);

                string query = "INSERT INTO accounts (FIRSTNAME, LASTNAME, EMAIL, CONTACTNO, TELEPHONE, PASSWORD, REGION, CITY) " +
                               "VALUES (@FIRSTNAME, @LASTNAME, @EMAIL, @CONTACTNO, @TELEPHONE, @PASSWORD, @REGION, @CITY)";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@FIRSTNAME", firstName);
                cmd.Parameters.AddWithValue("@LASTNAME", lastName);
                cmd.Parameters.AddWithValue("@EMAIL", email);
                cmd.Parameters.AddWithValue("@CONTACTNO", contactNo);
                cmd.Parameters.AddWithValue("@TELEPHONE", telephone);
                cmd.Parameters.AddWithValue("@PASSWORD", EncryptedPassword);
                cmd.Parameters.AddWithValue("@REGION", region);
                cmd.Parameters.AddWithValue("@CITY", city);

                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error inserting account: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public bool ValidateLogin(string email, string password)
        {
            try
            {
                OpenConnection();

                string query = "SELECT PASSWORD FROM accounts WHERE EMAIL = @EMAIL";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@EMAIL", email);

                object result = cmd.ExecuteScalar();
                if (result == null)
                {
                    MessageBox.Show("Invalid login.");
                    return false;
                }

                string EncryptedPassword = result.ToString();
                string DecryptedPassword = DecryptPassword(EncryptedPassword);

                return password == DecryptedPassword;
            }
            catch (Exception ex)
            {
                throw new Exception("Error validating login: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public (string FirstName, string Password, int IsAdmin, int uid) GetUserCredentials(string email)
        {
            try
            {
                OpenConnection();

                string query = "SELECT FIRSTNAME, PASSWORD, ISADMIN, USERID FROM accounts WHERE EMAIL = @EMAIL";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@EMAIL", email);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int uid = reader.GetInt32("USERID");
                    string firstName = reader.GetString("FIRSTNAME");
                    string EncryptedPassword = reader.GetString("PASSWORD");
                    int isAdmin = reader.GetInt32("ISADMIN");

                    string DecryptedPassword = DecryptPassword(EncryptedPassword);
                    return (firstName, DecryptedPassword, isAdmin, uid);
                }
                else
                {
                    return (null, null, -1, -1);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving user credentials: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public string EncryptPassword(string plainText)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = EncryptionKey;
                aes.IV = new byte[16];

                using (var encryptor = aes.CreateEncryptor(aes.Key, aes.IV))
                using (var ms = new MemoryStream())
                using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                {
                    byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);
                    cs.Write(plainBytes, 0, plainBytes.Length);
                    cs.FlushFinalBlock();
                    return Convert.ToBase64String(ms.ToArray());
                }
            }
        }

        public string DecryptPassword(string encryptedText)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = EncryptionKey;
                aes.IV = new byte[16];

                using (var decryptor = aes.CreateDecryptor(aes.Key, aes.IV))
                using (var ms = new MemoryStream(Convert.FromBase64String(encryptedText)))
                using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                using (var reader = new StreamReader(cs))
                {
                    return reader.ReadToEnd();
                }
            }
        }
        string query;

        public DataTable ShowInventory(MySqlCommand query)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(query);
            DataTable inv = new DataTable();
            adapter.Fill(inv);
            return inv;
        }

        public string GenerateRandomID(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var randomID = new char[length];

            for (int i = 0; i < length; i++)
            {
                randomID[i] = chars[random.Next(chars.Length)];
            }

            return new string(randomID);
        }


        public void addRecord(string name, decimal price, int quantity, DateTime selectedDate)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Product name cannot be empty.");
                    return;
                }

                if (price <= 0)
                {
                    MessageBox.Show("Price must be greater than zero.");
                    return;
                }

                if (quantity <= 0 || quantity > 500)
                {
                    MessageBox.Show("Quantity must be between 1 and 500.");
                    return;
                }

                OpenConnection();

                string checkQuery = "SELECT PID FROM INVENTORY WHERE PNAME = @name";
                using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, connection))
                {
                    checkCmd.Parameters.AddWithValue("@name", name);
                    object result = checkCmd.ExecuteScalar();

                    if (result != null) 
                    {
                        MessageBox.Show("Product already exists with ID: " + result.ToString());
                        CloseConnection();
                        return;
                    }
                }

                
                string randomID = GenerateRandomID(8);

                string insertQuery = "INSERT INTO INVENTORY (PID, PNAME, ITEMPRICE, QTY, EXPIRY_DATE) VALUES (@id, @name, @price, @quantity, @selectedDate)";
                using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, connection))
                {
                    insertCmd.Parameters.AddWithValue("@id", randomID);
                    insertCmd.Parameters.AddWithValue("@name", name);
                    insertCmd.Parameters.AddWithValue("@price", price);
                    insertCmd.Parameters.AddWithValue("@quantity", quantity);
                    insertCmd.Parameters.AddWithValue("@selectedDate", selectedDate);
                    insertCmd.ExecuteNonQuery();
                }

                GenerateAndSaveBarcode(randomID);

                MessageBox.Show("Product added successfully.");
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
            finally
            {
                CloseConnection();
            }
        }


        public void updateRecord(string name, string price, string quantity, DateTime selectedDate, string pid)
        {
            try
            {
                OpenConnection();

                string query = "UPDATE INVENTORY SET PNAME = @name, ITEMPRICE = @price, " +
                               "QTY = @quantity, EXPIRY_DATE = @expiry WHERE PID = @pid";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(price));  
                cmd.Parameters.AddWithValue("@quantity", Convert.ToInt32(quantity)); 
                cmd.Parameters.AddWithValue("@expiry", selectedDate.ToString("yyyy-MM-dd")); 
                cmd.Parameters.AddWithValue("@pid", pid);

                cmd.ExecuteNonQuery();
                CloseConnection();

                MessageBox.Show("Record is updated");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void deleteRecord(string pid)
        {
            try
            {
                OpenConnection();

                MySqlCommand query = new MySqlCommand($"SELECT COUNT(*) FROM INVENTORY WHERE PID = '{pid}'", connection);
                int exists = Convert.ToInt32(query.ExecuteScalar());

                if (exists == 0)
                {
                    MessageBox.Show("Record does not exist.");
                }
                else if (exists == 1)
                {
                    MySqlCommand cmd = new MySqlCommand($"DELETE FROM INVENTORY WHERE PID = '{pid}'", connection);
                    cmd.ExecuteNonQuery();

                    CloseConnection();

                    MessageBox.Show("Record is deleted.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void GenerateAndSaveBarcode(string productId)
        {
            BarcodeEncoder generator = new BarcodeEncoder();
            generator.IncludeLabel = true;
            generator.CustomLabel = productId;

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string barcodeDirectory = Path.Combine(desktopPath, "Barcodes");

            if (!Directory.Exists(barcodeDirectory))
            {
                Directory.CreateDirectory(barcodeDirectory);
            }

            string barcodePath = Path.Combine(barcodeDirectory, productId + ".png");

            Bitmap barcodeImage = new Bitmap(generator.Encode(BarcodeFormat.Code39Extended, productId));
            barcodeImage.Save(barcodePath, System.Drawing.Imaging.ImageFormat.Png);
        }

        public string GetProductId(string pname)
        {
            string productId = "";
            try
            {
                string query = "SELECT PID FROM INVENTORY WHERE PNAME = @PNAME LIMIT 1";

                MySqlCommand cmd = new MySqlCommand(query, getConnect);
                cmd.Parameters.AddWithValue("@PNAME", pname);

                getConnect.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    productId = reader["PID"].ToString();
                }

                getConnect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return productId;
        }

        public string GetProductName(string pid)
        {
            string productname = "";
            try
            {
                string query = "SELECT PNAME FROM INVENTORY WHERE PID = @PID LIMIT 1";

                MySqlCommand cmd = new MySqlCommand(query, getConnect);
                cmd.Parameters.AddWithValue("@PID", pid);

                getConnect.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    productname = reader["PNAME"].ToString();
                }

                getConnect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return productname;
        }
        public List<string> ProductSearchSuggestions(string searchText)
        {
            List<string> suggestions = new List<string>();

            if (string.IsNullOrEmpty(searchText))
            {
                return suggestions;
            }

            string query = "SELECT ProductID, PNAME FROM INVENTORY WHERE PRODUCTID LIKE @searchText OR PNAME LIKE @searchText LIMIT 10";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

                    connection.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string productID = reader["ProductID"].ToString();
                            string productName = reader["PNAME"].ToString();
                            suggestions.Add($"{productID} - {productName}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }

            return suggestions;
        }
        public void DisplaySearchResults(string searchText, DataGridView tbl_records)
        {
            try
            {
                OpenConnection();

                string query = "SELECT PNAME, ITEMPRICE, CATEGORY, BRAND FROM INVENTORY WHERE ProductID LIKE @searchText OR PNAME LIKE @searchText";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                tbl_records.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                CloseConnection();
            }
        }

        public bool CheckLowStocks()
        {
            bool hasLowStock = false;

            try
            {
                OpenConnection();

                string query = "SELECT COUNT(*) FROM INVENTORY WHERE QUANTITY < 50";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                hasLowStock = count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking low stock: {ex.Message}");
                return false;
            }
            finally
            {
                CloseConnection();
            }

            return hasLowStock;
        }
        public DataTable GetProductSales()
        {
            DataTable productSales = new DataTable();
            try
            {
                OpenConnection();

                string query = "SELECT ITEMNAME, SUM(QUANTITY) AS TotalQuantity FROM item_transaction GROUP BY ITEMNAME " +
                    "ORDER BY TotalQuantity DESC LIMIT 3";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                adapter.Fill(productSales);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving product sales data: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return productSales;
        }
        public string GetHighestSellingProductName()
        {
            try
            {
                OpenConnection();
                string query = @"SELECT ITEMNAME, SUM(QUANTITY) AS ITEMS_SOLD FROM item_transaction GROUP BY ITEMNAME 
            ORDER BY SUM(QUANTITY) DESC LIMIT 1"
                ;


                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string productName = reader["ITEMNAME"].ToString();
                        string itemsSold = reader["ITEMS_SOLD"].ToString();

                        string highestselling = productName + " - " + itemsSold + " items sold";

                        return highestselling;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving highest selling product: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        public DataTable GetReturnedProducts()
        {
            DataTable productReturns = new DataTable();
            try
            {
                OpenConnection();

                string query = "SELECT ITEMNAME, SUM(QUANTITY) AS TotalQuantity FROM return_logs GROUP BY ITEMNAME " +
                    "ORDER BY TotalQuantity DESC LIMIT 3";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                adapter.Fill(productReturns);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving product returns data: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return productReturns;
        }
        public string GetHighestReturnedProductName()
        {
            try
            {
                OpenConnection();
                string query = @"SELECT ITEMNAME, SUM(QUANTITY) AS ITEMS_RETURNED FROM return_logs GROUP BY ITEMNAME 
            ORDER BY SUM(QUANTITY) DESC LIMIT 1"
                ;

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string productName = reader["ITEMNAME"].ToString();
                        string itemsReturned = reader["ITEMS_RETURNED"].ToString();

                        string highestreturning = productName + " - " + itemsReturned + " items returned";

                        return highestreturning;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving highest returning product: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public decimal GetIncomePerDate(int number)
        {
            try
            {
                OpenConnection();

                string query = "";

                if (number == 0)
                {
                    query = @"SELECT SUM(PRICE) AS TOTALBILL from item_transaction WHERE YEAR(DATE) = YEAR(CURRENT_DATE) 
                AND MONTH(DATE) = MONTH(CURRENT_DATE)";
                }
                else if (number == 1)
                {
                    query = @"SELECT SUM(PRICE) AS TOTALBILL from item_transaction WHERE YEAR(DATE) = YEAR(CURRENT_DATE)";
                }
                else if (number == 2)
                {
                    query = @"SELECT SUM(PRICE) AS TOTALBILL from item_transaction";
                }
                else if (number == 111)
                {
                    query = @"SELECT SUM(PRICE) AS TOTALBILL from item_transaction WHERE DATE(DATE) = DATE(CURRENT_DATE)";
                }

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read() && reader["TOTALBILL"] != DBNull.Value)
                    {
                        return Convert.ToDecimal(reader["TOTALBILL"]);
                    }
                }
                return 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving income!: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public DataTable GetIncome(string groupBy)
        {
            DataTable incomeData = new DataTable();
            try
            {
                OpenConnection();

                string query = "";

                if (groupBy == "Year")
                {
                    query = "SELECT YEAR(DATE) AS Year, SUM(PRICE) AS AnnualIncome " +
                            "FROM item_transaction GROUP BY YEAR(DATE) ORDER BY YEAR(DATE)";
                }
                else if (groupBy == "Month")
                {
                    query = "SELECT YEAR(DATE) AS Year, MONTH(DATE) AS Month, SUM(PRICE) AS MonthlyIncome " +
                            "FROM item_transaction WHERE YEAR(DATE) = YEAR(CURRENT_DATE) GROUP BY YEAR(DATE), " +
                            "MONTH(DATE) ORDER BY YEAR(DATE), MONTH(DATE)";
                }
                else if (groupBy == "Day")
                {
                    query = "SELECT DATE(DATE) AS TransactionDate, SUM(PRICE) AS DailyIncome " +
                            "FROM item_transaction WHERE YEAR(DATE) = YEAR(CURRENT_DATE) AND MONTH(DATE) = MONTH(CURRENT_DATE) " +
                            "GROUP BY DATE(DATE) ORDER BY DATE(DATE)";
                }
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(incomeData);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving income!: {ex.Message}");
            }
            finally
            {
                CloseConnection();
            }
            return incomeData;
        }

        public DataTable searchTransactId(string tid)
        {
            DataTable search = new DataTable();
            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand($"SELECT * FROM item_transaction WHERE TRANSACTIONID = '{tid}'",
                    connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(search);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { CloseConnection(); }

            return search;
        }

        public DataTable searchProduct(string pid)
        {
            DataTable search = new DataTable();
            try
            {
                OpenConnection();

                MySqlCommand cmd = new MySqlCommand($"SELECT * FROM INVENTORY WHERE PID = '{pid}'", connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(search);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { CloseConnection(); }

            return search;
        }

    }
}
