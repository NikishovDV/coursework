using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace CourceDB
{
    internal class DB
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "server=localhost;port=3306;username=root;password=root;database=brand_shop";
            MySqlConnection conn = new MySqlConnection(sql);
            try
            {
                conn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Connection!\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return conn;
        }
        //public static void AddBrand(Brand brand)
        //{
        //    string sql = "INSERT INTO brand (brandname, adress) VALUES (@Brandname, @Adress)";
        //    MySqlConnection conn = GetConnection();
        //    MySqlCommand cmd = new MySqlCommand(sql, conn);
        //    cmd.CommandType = CommandType.Text;
        //    cmd.Parameters.Add("@Brandname", MySqlDbType.VarChar).Value = brand.Brandname;
        //    cmd.Parameters.Add("@Adress", MySqlDbType.Text).Value = brand.Adress;
        //    try
        //    {
        //        cmd.ExecuteNonQuery();
        //        MessageBox.Show("Бренд успешно добавлен.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    catch (MySqlException ex)
        //    {
        //        MessageBox.Show("Не удалось добавить бренд.\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    conn.Close();
        //}
        //public static void AddColor(Color color)
        //{
        //    string sql = "INSERT INTO color (colorname, hex_kod) VALUES (@Colorname, @Hex_kod)";
        //    MySqlConnection conn = GetConnection();
        //    MySqlCommand cmd = new MySqlCommand(sql, conn);
        //    cmd.CommandType = CommandType.Text;
        //    cmd.Parameters.Add("@Colorname", MySqlDbType.VarChar).Value = color.Colorname;
        //    cmd.Parameters.Add("@Hex_kod", MySqlDbType.VarChar).Value = color.Hex_kod;
        //    try
        //    {
        //        cmd.ExecuteNonQuery();
        //        MessageBox.Show("Цвет успешно добавлен.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    catch (MySqlException ex)
        //    {
        //        MessageBox.Show("Не удалось добавить цвет.\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    conn.Close();
        //}
        //public static void AddFabricator(Fabricator fabricator)
        //{
        //    string sql = "INSERT INTO fabricator (fabricatorname) VALUES (@Fabricatorname)";
        //    MySqlConnection conn = GetConnection();
        //    MySqlCommand cmd = new MySqlCommand(sql, conn);
        //    cmd.CommandType = CommandType.Text;
        //    cmd.Parameters.Add("@Fabricatorname", MySqlDbType.VarChar).Value = fabricator.Fabricatorname;
        //    try
        //    {
        //        cmd.ExecuteNonQuery();
        //        MessageBox.Show("Производитель успешно добавлен.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    catch (MySqlException ex)
        //    {
        //        MessageBox.Show("Не удалось добавить производителя.\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    conn.Close();
        //}
        //public static void AddMaterial(Material material)
        //{
        //    string sql = "INSERT INTO material (materialname, description) VALUES (@Materialname,@Description)";
        //    MySqlConnection conn = GetConnection();
        //    MySqlCommand cmd = new MySqlCommand(sql, conn);
        //    cmd.CommandType = CommandType.Text;
        //    cmd.Parameters.Add("@Materialname", MySqlDbType.VarChar).Value = material.Materialname;
        //    cmd.Parameters.Add("@Description", MySqlDbType.Text).Value = material.Description;
        //    try
        //    {
        //        cmd.ExecuteNonQuery();
        //        MessageBox.Show("Материал успешно добавлен.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    catch (MySqlException ex)
        //    {
        //        MessageBox.Show("Не удалось добавить материал.\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    conn.Close();
        //}
        //public static void AddName(Name name)
        //{
        //    string sql = "INSERT INTO name (naming) VALUES (@Naming)";
        //    MySqlConnection conn = GetConnection();
        //    MySqlCommand cmd = new MySqlCommand(sql, conn);
        //    cmd.CommandType = CommandType.Text;
        //    cmd.Parameters.Add("@Naming", MySqlDbType.VarChar).Value = name.Naming;
        //    try
        //    {
        //        cmd.ExecuteNonQuery();
        //        MessageBox.Show("Название успешно добавлено.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    catch (MySqlException ex)
        //    {
        //        MessageBox.Show("Не удалось добавить название.\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    conn.Close();
        //}

        public static void AddBrand(string brandname, string adress)
        {
            string sql = "INSERT INTO brand (brandname, adress) VALUES (@Brandname, @Adress)";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Brandname", MySqlDbType.VarChar).Value = brandname;
            cmd.Parameters.Add("@Adress", MySqlDbType.Text).Value = adress;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Бренд успешно добавлен.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Не удалось добавить бренд.\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        public static void AddColor(string colorname, string hexKod)
        {
            string sql = "INSERT INTO color (colorname, hex_kod) VALUES (@Colorname, @Hex_kod)";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Colorname", MySqlDbType.VarChar).Value = colorname;
            cmd.Parameters.Add("@Hex_kod", MySqlDbType.VarChar).Value = hexKod;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Цвет успешно добавлен.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Не удалось добавить цвет.\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        public static void AddFabricator(string fabricatorname)
        {
            string sql = "INSERT INTO fabricator (fabricatorname) VALUES (@Fabricatorname)";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Fabricatorname", MySqlDbType.VarChar).Value = fabricatorname;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Производитель успешно добавлен.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Не удалось добавить производителя.\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        public static void AddMaterial(string materialname, string description)
        {
            string sql = "INSERT INTO material (materialname, description) VALUES (@Materialname, @Description)";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Materialname", MySqlDbType.VarChar).Value = materialname;
            cmd.Parameters.Add("@Description", MySqlDbType.Text).Value = description;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Материал успешно добавлен.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Не удалось добавить материал.\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        public static void AddName(string naming)
        {
            string sql = "INSERT INTO name (naming) VALUES (@Naming)";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Naming", MySqlDbType.VarChar).Value = naming;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Название успешно добавлено.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Не удалось добавить название.\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }


        public static void AddTovar(Tovar tovar)
        {
            string sql = "INSERT INTO tovar (name, size, brand, sole_height, material, color, guarantee, fabricator, price, amount) VALUES (@Name, @Size, @Brand, @Sole_height, @Material, @Color, @Guarantee, @Fabricator, @Price, @Amount)";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Name", MySqlDbType.Int32).Value = tovar.Name.ID;
            cmd.Parameters.Add("@Size", MySqlDbType.Int32).Value = tovar.Size;
            cmd.Parameters.Add("@Brand", MySqlDbType.Int32).Value = tovar.Brand.ID;
            cmd.Parameters.Add("@Sole_height", MySqlDbType.Float).Value = tovar.Sole_height;
            cmd.Parameters.Add("@Material", MySqlDbType.Int32).Value = tovar.Material.ID;
            cmd.Parameters.Add("@Color", MySqlDbType.Int32).Value = tovar.Color.ID;
            cmd.Parameters.Add("@Guarantee", MySqlDbType.Int32).Value = tovar.Guarantee;
            cmd.Parameters.Add("@Fabricator", MySqlDbType.Int32).Value = tovar.Fabricator.ID;
            cmd.Parameters.Add("@Price", MySqlDbType.Int32).Value = tovar.Price;
            cmd.Parameters.Add("@Amount", MySqlDbType.Int32).Value = tovar.Amount;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Товар успешно добавлено.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Не удалось добавить товар.\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        public static void AddStaff(string surname, string name, long phone, string position)
        {
            string sql = "INSERT INTO staff (surname, name, phone, position) VALUES (@Surname, @Name, @Phone, @Position)";
            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@Surname", MySqlDbType.VarChar).Value = surname;
                cmd.Parameters.Add("@Name", MySqlDbType.VarChar).Value = name;
                cmd.Parameters.Add("@Phone", MySqlDbType.Int64).Value = phone;
                cmd.Parameters.Add("@Position", MySqlDbType.VarChar).Value = position;
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Сотрудник успешно добавлен.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Не удалось добавить сотрудника.\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        //public static void AddStaff(Staff staff)
        //{
        //    string sql = "INSERT INTO staff (surname, name, phone, position) VALUES (@Surname, @Name, @Phone, @Position)";
        //    MySqlConnection conn = GetConnection();
        //    MySqlCommand cmd = new MySqlCommand(sql, conn);
        //    cmd.CommandType = CommandType.Text;
        //    cmd.Parameters.Add("@Surname", MySqlDbType.VarChar).Value = staff.Surname;
        //    cmd.Parameters.Add("@Name", MySqlDbType.VarChar).Value = staff.Name;
        //    cmd.Parameters.Add("@Phone", MySqlDbType.Int64).Value = staff.Phone;
        //    cmd.Parameters.Add("@Position", MySqlDbType.VarChar).Value = staff.Position;
        //    try
        //    {
        //        cmd.ExecuteNonQuery();
        //        MessageBox.Show("Сотрудник успешно добавлено.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    catch (MySqlException ex)
        //    {
        //        MessageBox.Show("Не удалось добавить сотрудника.\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    conn.Close();
        //}
        //public static void AddSale(Sale sale)
        //{
        //    string sql = "INSERT INTO sale (tovar_kod, price, amount, staff, date) VALUES (@Tovar_kod, @Price, @Amount, @Staff, @Date)";
        //    MySqlConnection conn = GetConnection();
        //    MySqlCommand cmd = new MySqlCommand(sql, conn);
        //    cmd.CommandType = CommandType.Text;
        //    cmd.Parameters.Add("@Tovar_kod", MySqlDbType.Int32).Value = sale.Tovar.ID;
        //    cmd.Parameters.Add("@Price", MySqlDbType.Int32).Value = sale.Price;
        //    cmd.Parameters.Add("@Amount", MySqlDbType.Int32).Value = sale.Amount;
        //    cmd.Parameters.Add("@Staff", MySqlDbType.Int32).Value = sale.Staff.ID;
        //    cmd.Parameters.Add("@Date", MySqlDbType.Date).Value = sale.Date;
        //    try
        //    {
        //        cmd.ExecuteNonQuery();
        //    }
        //    catch (MySqlException ex)
        //    {
        //        MessageBox.Show("Не удалось добавить продажу.\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    conn.Close();
        //}

        public static void AddSale(Sale sale)
        {
            string sql = "INSERT INTO sale (tovar_kod, price, amount, staff, date) VALUES (@Tovar_kod, @Price, @Amount, @Staff, @Date)";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Tovar_kod", MySqlDbType.Int32).Value = sale.Tovar.ID;
            cmd.Parameters.Add("@Price", MySqlDbType.Int32).Value = sale.Price;
            cmd.Parameters.Add("@Amount", MySqlDbType.Int32).Value = sale.Amount;
            cmd.Parameters.Add("@Staff", MySqlDbType.Int32).Value = sale.Staff.ID;
            cmd.Parameters.Add("@Date", MySqlDbType.Date).Value = sale.Date;

            try
            {
                cmd.ExecuteNonQuery();

                // Уменьшаем количество товара на количество, указанное в продаже
                UpdateTovarAmount(sale.Tovar.ID, -sale.Amount);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Не удалось добавить продажу.\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public static void UpdateTovarAmount(int tovarId, int amountChange)
        {
            string selectSql = "SELECT amount FROM tovar WHERE kod_tovar = @Tovar_kod";
            MySqlConnection conn = GetConnection();
            MySqlCommand selectCmd = new MySqlCommand(selectSql, conn);
            selectCmd.Parameters.Add("@Tovar_kod", MySqlDbType.Int32).Value = tovarId;

            try
            {
                int currentAmount = Convert.ToInt32(selectCmd.ExecuteScalar());

                if (currentAmount + amountChange <= 0)
                {
                    // Удалить товар, если количество становится 0 или меньше
                    DeleteTovar(tovarId);
                }
                else
                {
                    // Обновить количество товара
                    string updateSql = "UPDATE tovar SET amount = amount + @AmountChange WHERE kod_tovar = @Tovar_kod";
                    MySqlCommand updateCmd = new MySqlCommand(updateSql, conn);
                    updateCmd.Parameters.Add("@AmountChange", MySqlDbType.Int32).Value = amountChange;
                    updateCmd.Parameters.Add("@Tovar_kod", MySqlDbType.Int32).Value = tovarId;
                    updateCmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Не удалось обновить количество товара.\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }


        public static void AddClient(Client client)
        {
            string sql = "INSERT INTO client (login) VALUES (@Login)";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;

            //string hashedLogin = HashString(client.Login);

            cmd.Parameters.Add("@Login", MySqlDbType.VarChar, 64).Value = client.Login;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Клиент зарегистрирован.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Не удалось провести регистрацию.\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        private static string HashString(string input)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        //public static void AddCart(Cart cart)
        //{
        //    string sql = "INSERT INTO cart (tovar_kod, client_login) VALUES (@Tovar_kod, @Client_login)";
        //    MySqlConnection conn = GetConnection();
        //    MySqlCommand cmd = new MySqlCommand(sql, conn);
        //    cmd.CommandType = CommandType.Text;
        //    cmd.Parameters.Add("@Tovar_kod", MySqlDbType.Int32).Value = cart.Tovar.ID;
        //    cmd.Parameters.Add("@Client_login", MySqlDbType.VarChar).Value = cart.Client.Login;
        //    try
        //    {
        //        cmd.ExecuteNonQuery();
        //        MessageBox.Show("Товар добавлен в корзину.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    catch (MySqlException ex)
        //    {
        //        MessageBox.Show("Не удалось добавить товар в корзину.\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    conn.Close();
        //}
        public static void AddCart(int tovarId, string clientLogin)
        {
            string sql = "INSERT INTO cart (tovar_kod, client_login) VALUES (@Tovar_kod, @Client_login)";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Tovar_kod", MySqlDbType.Int32).Value = tovarId;
            cmd.Parameters.Add("@Client_login", MySqlDbType.VarChar).Value = clientLogin;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Товар добавлен в корзину.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Уменьшаем количество товара на 1
                //UpdateTovarAmount(tovarId, -1);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Не удалось добавить товар в корзину.\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        public static void UpdateBrand(int id, string brandname, string address)
        {
            string sql = "UPDATE brand SET brandname = @Brandname, adress = @Address WHERE brand_kod = @ID";
            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@ID", MySqlDbType.Int32).Value = id;
                cmd.Parameters.Add("@Brandname", MySqlDbType.VarChar).Value = brandname;
                cmd.Parameters.Add("@Address", MySqlDbType.Text).Value = address;
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Информация о бренде успешно изменена.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Не удалось изменить информацию о бренде.\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void UpdateColor(int id, string colorname, string hex_kod)
        {
            string sql = "UPDATE color SET colorname = @Colorname, hex_kod = @Hex_kod WHERE color_kod = @ID";
            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@ID", MySqlDbType.Int32).Value = id;
                cmd.Parameters.Add("@Colorname", MySqlDbType.VarChar).Value = colorname;
                cmd.Parameters.Add("@Hex_kod", MySqlDbType.VarChar).Value = hex_kod;
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Информация о цвете успешно изменена.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Не удалось изменить информацию о цвете.\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void UpdateFabricator(int id, string fabricatorname)
        {
            string sql = "UPDATE fabricator SET fabricatorname = @Fabricatorname WHERE fabricator_kod = @ID";
            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@ID", MySqlDbType.Int32).Value = id;
                cmd.Parameters.Add("@Fabricatorname", MySqlDbType.VarChar).Value = fabricatorname;
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Информация о производителе успешно изменена.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Не удалось изменить информацию о производителе.\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void UpdateMaterial(int id, string materialname, string description)
        {
            string sql = "UPDATE material SET materialname = @Materialname, description = @Description WHERE material_kod = @ID";
            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@ID", MySqlDbType.Int32).Value = id;
                cmd.Parameters.Add("@Materialname", MySqlDbType.VarChar).Value = materialname;
                cmd.Parameters.Add("@Description", MySqlDbType.Text).Value = description;
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Информация о материале успешно изменена.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Не удалось изменить информацию о материале.\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void UpdateName(int id, string naming)
        {
            string sql = "UPDATE name SET naming = @Naming WHERE name_kod = @ID";
            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@ID", MySqlDbType.Int32).Value = id;
                cmd.Parameters.Add("@Naming", MySqlDbType.VarChar).Value = naming;
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Информация о названии успешно изменена.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Не удалось изменить информацию о названии.\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void UpdateStaff(int id, string surname, string name, long phone, string position)
        {
            string sql = "UPDATE staff SET surname = @Surname, name = @Name, phone = @Phone, position = @Position WHERE staff_kod = @ID";
            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@ID", MySqlDbType.Int32).Value = id;
                cmd.Parameters.Add("@Surname", MySqlDbType.VarChar).Value = surname;
                cmd.Parameters.Add("@Name", MySqlDbType.VarChar).Value = name;
                cmd.Parameters.Add("@Phone", MySqlDbType.Int64).Value = phone;
                cmd.Parameters.Add("@Position", MySqlDbType.VarChar).Value = position;
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Информация о персонале успешно изменена.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Не удалось изменить информацию о персонале.\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        //public static void UpdateBrand(Brand brand)
        //{
        //    string sql = "UPDATE brand SET brandname = @Brandnam, adress = @Adress WHERE brand_kod = @ID";
        //    MySqlConnection conn = GetConnection();
        //    MySqlCommand cmd = new MySqlCommand(sql, conn);
        //    cmd.CommandType = CommandType.Text;
        //    cmd.Parameters.Add("@ID", MySqlDbType.Int32).Value = brand.ID;
        //    cmd.Parameters.Add("@Brandname", MySqlDbType.VarChar).Value = brand.Brandname;
        //    cmd.Parameters.Add("@Adress", MySqlDbType.Text).Value = brand.Adress;
        //    try
        //    {
        //        cmd.ExecuteNonQuery();
        //        MessageBox.Show("Информация о бренде успешно изменена.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    catch (MySqlException ex)
        //    {
        //        MessageBox.Show("Не удалось изменить информацию о бренде.\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    conn.Close();
        //}
        //public static void UpdateColor(Color color)
        //{
        //    string sql = "UPDATE color SET colorname = @Colorname, hex_kod = @Hex_kod WHERE color_kod = @ID";
        //    MySqlConnection conn = GetConnection();
        //    MySqlCommand cmd = new MySqlCommand(sql, conn);
        //    cmd.CommandType = CommandType.Text;
        //    cmd.Parameters.Add("@ID", MySqlDbType.Int32).Value = color.ID;
        //    cmd.Parameters.Add("@Colorname", MySqlDbType.VarChar).Value = color.Colorname;
        //    cmd.Parameters.Add("@Hex_kod", MySqlDbType.VarChar).Value = color.Hex_kod;
        //    try
        //    {
        //        cmd.ExecuteNonQuery();
        //        MessageBox.Show("Информация о цвете успешно изменена.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    catch (MySqlException ex)
        //    {
        //        MessageBox.Show("Не удалось изменить информацию о цвете.\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    conn.Close();
        //}
        //public static void UpdateFabricator(Fabricator fabricator)
        //{
        //    string sql = "UPDATE fabricator SET fabricatorname = @Fabricatorname WHERE fabricator_kod = @ID";
        //    MySqlConnection conn = GetConnection();
        //    MySqlCommand cmd = new MySqlCommand(sql, conn);
        //    cmd.CommandType = CommandType.Text;
        //    cmd.Parameters.Add("@ID", MySqlDbType.Int32).Value = fabricator.ID;
        //    cmd.Parameters.Add("@Fabricatorname", MySqlDbType.VarChar).Value = fabricator.Fabricatorname;
        //    try
        //    {
        //        cmd.ExecuteNonQuery();
        //        MessageBox.Show("Информация о производителе успешно изменена.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    catch (MySqlException ex)
        //    {
        //        MessageBox.Show("Не удалось изменить информацию о производителе.\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    conn.Close();
        //}
        //public static void UpdateMaterial(Material material)
        //{
        //    string sql = "UPDATE material SET materialname = @Materialname, description = @Description WHERE material_kod = @ID";
        //    MySqlConnection conn = GetConnection();
        //    MySqlCommand cmd = new MySqlCommand(sql, conn);
        //    cmd.CommandType = CommandType.Text;
        //    cmd.Parameters.Add("@ID", MySqlDbType.Int32).Value = material.ID;
        //    cmd.Parameters.Add("@Materialname", MySqlDbType.VarChar).Value = material.Materialname;
        //    cmd.Parameters.Add("@Description", MySqlDbType.Text).Value = material.Description;
        //    try
        //    {
        //        cmd.ExecuteNonQuery();
        //        MessageBox.Show("Информация о производителе успешно изменена.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    catch (MySqlException ex)
        //    {
        //        MessageBox.Show("Не удалось изменить информацию о производителе.\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    conn.Close();
        //}
        //public static void UpdateName(Name name)
        //{
        //    string sql = "UPDATE name SET naming = @Naming WHERE name_kod = @ID";
        //    MySqlConnection conn = GetConnection();
        //    MySqlCommand cmd = new MySqlCommand(sql, conn);
        //    cmd.CommandType = CommandType.Text;
        //    cmd.Parameters.Add("@ID", MySqlDbType.Int32).Value = name.ID;
        //    cmd.Parameters.Add("@Naming", MySqlDbType.VarChar).Value = name.Naming;
        //    try
        //    {
        //        cmd.ExecuteNonQuery();
        //        MessageBox.Show("Информация о названии успешно изменена.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    catch (MySqlException ex)
        //    {
        //        MessageBox.Show("Не удалось изменить информацию о названии.\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    conn.Close();
        //}
        public static void UpdateTovar(Tovar tovar)
        {
            string sql = "UPDATE tovar SET name = @Name, size = @Size, brand = @Brand, sole_height = @Sole_height, material = @Material, color = @Color, guarantee = @Guarantee, fabricator = @Fabricator, price = @Price, amount = @Amount WHERE kod_tovar = @ID";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ID", MySqlDbType.Int32).Value = tovar.ID;
            cmd.Parameters.Add("@Name", MySqlDbType.Int32).Value = tovar.Name.ID;
            cmd.Parameters.Add("@Size", MySqlDbType.Int32).Value = tovar.Size;
            cmd.Parameters.Add("@Brand", MySqlDbType.Int32).Value = tovar.Brand.ID;
            cmd.Parameters.Add("@Sole_height", MySqlDbType.Float).Value = tovar.Sole_height;
            cmd.Parameters.Add("@Material", MySqlDbType.Int32).Value = tovar.Material.ID;
            cmd.Parameters.Add("@Color", MySqlDbType.Int32).Value = tovar.Color.ID;
            cmd.Parameters.Add("@Guarantee", MySqlDbType.Int32).Value = tovar.Guarantee;
            cmd.Parameters.Add("@Fabricator", MySqlDbType.Int32).Value = tovar.Fabricator.ID;
            cmd.Parameters.Add("@Price", MySqlDbType.Int32).Value = tovar.Price;
            cmd.Parameters.Add("@Amount", MySqlDbType.Int32).Value = tovar.Amount;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Информация о товаре успешно изменена.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Не удалось изменить информацию о товаре.\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
        //public static void UpdateStaff(Staff staff)
        //{
        //    string sql = "UPDATE staff SET surname = @Surname, name = @Name, phone = @Phone, position = @Position WHERE staff_kod = @ID";
        //    MySqlConnection conn = GetConnection();
        //    MySqlCommand cmd = new MySqlCommand(sql, conn);
        //    cmd.CommandType = CommandType.Text;
        //    cmd.Parameters.Add("@ID", MySqlDbType.Int32).Value = staff.ID;
        //    cmd.Parameters.Add("@Surname", MySqlDbType.VarChar).Value = staff.Surname;
        //    cmd.Parameters.Add("@Name", MySqlDbType.VarChar).Value = staff.Name;
        //    cmd.Parameters.Add("@Phone", MySqlDbType.Int64).Value = staff.Phone;
        //    cmd.Parameters.Add("@Position", MySqlDbType.VarChar).Value = staff.Position;
        //    try
        //    {
        //        cmd.ExecuteNonQuery();
        //        MessageBox.Show("Информация о персонале успешно изменена.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    catch (MySqlException ex)
        //    {
        //        MessageBox.Show("Не удалось изменить информацию о персонале.\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    conn.Close();
        //}
        public static void UpdateSale(Sale sale)
        {
            string sql = "UPDATE sale SET tovar_kod = @Tovar_kod, price = @Price, amount = @Amount, staff = @Staff, date = @Date WHERE sale_kod = @ID";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ID", MySqlDbType.Int32).Value = sale.ID;
            cmd.Parameters.Add("@Tovar_kod", MySqlDbType.Int32).Value = sale.Tovar.ID;
            cmd.Parameters.Add("@Price", MySqlDbType.Int32).Value = sale.Price;
            cmd.Parameters.Add("@Amount", MySqlDbType.Int32).Value = sale.Amount;
            cmd.Parameters.Add("@Staff", MySqlDbType.Int32).Value = sale.Staff.ID;
            cmd.Parameters.Add("@Date", MySqlDbType.Date).Value = sale.Date;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Информация о продаже успешно изменена.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Не удалось изменить информацию о продаже.\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
        public static void UpdateClient(Client client)
        {
            string sql = "UPDATE client SET login = @Login WHERE client_kod = @ID";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ID", MySqlDbType.Int32).Value = client.ID;
            cmd.Parameters.Add("@Login", MySqlDbType.VarChar).Value = client.Login;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Информация о клиенте успешно изменена.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Не удалось изменить информацию о клиенте.\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
        public static void UpdateCart(Cart cart)
        {
            string sql = "UPDATE cart SET tovar_kod = @Tovar_kod, client_login = @Client_login WHERE cart_kod = @ID";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ID", MySqlDbType.Int32).Value = cart.ID;
            cmd.Parameters.Add("@Tovar_kod", MySqlDbType.Int32).Value = cart.Tovar.ID;
            cmd.Parameters.Add("@Client_login", MySqlDbType.VarChar).Value = cart.Client.Login;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Информация о корзине успешно изменена.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Не удалось изменить информацию о корзине.\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
        public static void DeleteBrand(int id)
        {
            string sql = "DELETE FROM brand WHERE brand_kod = @Brand_kod";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Brand_kod", MySqlDbType.Int32).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Бренд успешно удален.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Не удалось удалить бренд.\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
        public static void DeleteColor(int id)
        {
            string sql = "DELETE FROM color WHERE color_kod = @Color_kod";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Color_kod", MySqlDbType.Int32).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Цвет успешно удален.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Не удалось удалить цвет.\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
        public static void DeleteFabricator(int id)
        {
            string sql = "DELETE FROM fabricator WHERE fabricator_kod = @Fabricator_kod";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Fabricator_kod", MySqlDbType.Int32).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Производитель успешно удален.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Не удалось удалить производителя.\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
        public static void DeleteMaterial(int id)
        {
            string sql = "DELETE FROM material WHERE material_kod = @Material_kod";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Material_kod", MySqlDbType.Int32).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Материал успешно удален.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Не удалось удалить материал.\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
        public static void DeleteName(int id)
        {
            string sql = "DELETE FROM name WHERE name_kod = @Name_kod";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Name_kod", MySqlDbType.Int32).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Название успешно удалено.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Не удалось удалить название.\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
        public static void DeleteTovar(int id)
        {
            string sql = "DELETE FROM tovar WHERE kod_tovar = @Tovar_kod";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Tovar_kod", MySqlDbType.Int32).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Товар успешно удален.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Не удалось удалить товар.\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
        public static void DeleteStaff(int id)
        {
            string sql = "DELETE FROM staff WHERE staff_kod = @Staff_kod";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Staff_kod", MySqlDbType.Int32).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Сотрудник успешно удален.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Не удалось удалить сотрудника.\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
        public static void DeleteSale(int id)
        {
            string sql = "DELETE FROM sale WHERE sale_kod = @Sale_kod";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Sale_kod", MySqlDbType.Int32).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Продажа успешно удалена.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Не удалось удалить продажу.\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
        public static void DeleteClient(int id)
        {
            string sql = "DELETE FROM client WHERE client_kod = @Client_kod";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Client_kod", MySqlDbType.Int32).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Клиент успешно удален.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Не удалось удалить клиента.\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
        public static void DeleteCart(string login)
        {
            string sql = "DELETE FROM cart WHERE client_login = @Client_login";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Client_login", MySqlDbType.VarChar).Value = login;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Не удалось очистить корзину.\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
        public static Client SelectClientByLogin(string login)
        {
            //string hashedLogin = HashString(login);
            string sql = "SELECT client_kod FROM client WHERE login = @Login";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Login", MySqlDbType.VarChar, 64).Value = login;
            Client client = null;
            object result = cmd.ExecuteScalar();
            if (result != null)
            {
                int clientKod = Convert.ToInt32(result);
                client = new Client(clientKod, login);
            }
            conn.Close();
            return client;
        }

        public static Dictionary<string, Name> SelectAllNames()
        {
            string sql = "SELECT name_kod, naming FROM name";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            Dictionary<string, Name> names = ds.Tables[0].AsEnumerable().ToDictionary<DataRow, string, Name>(dataRow => dataRow.Field<String>("naming"), dataRow => new Name(dataRow.Field<Int32>("name_kod"), dataRow.Field<String>("naming")));
            conn.Close();
            return names;
        }
        public static Dictionary<string, Brand> SelectAllBrand()
        {
            string sql = "SELECT brand_kod, brandname FROM brand";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            Dictionary<string, Brand> brands = ds.Tables[0].AsEnumerable().ToDictionary<DataRow, string, Brand>(dataRow => dataRow.Field<String>("brandname"), dataRow => new Brand(dataRow.Field<Int32>("brand_kod"), dataRow.Field<String>("brandname"), null));
            conn.Close();
            return brands;
        }
        public static Dictionary<string, Material> SelectAllMaterial()
        {
            string sql = "SELECT material_kod, materialname FROM material";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            Dictionary<string, Material> materials = ds.Tables[0].AsEnumerable().ToDictionary<DataRow, string, Material>(dataRow => dataRow.Field<String>("materialname"), dataRow => new Material(dataRow.Field<Int32>("material_kod"), dataRow.Field<String>("materialname"), null));
            conn.Close();
            return materials;
        }
        public static Dictionary<string, Color> SelectAllColor()
        {
            string sql = "SELECT color_kod, colorname FROM color";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            Dictionary<string, Color> colors = ds.Tables[0].AsEnumerable().ToDictionary<DataRow, string, Color>(dataRow => dataRow.Field<String>("colorname"), dataRow => new Color(dataRow.Field<Int32>("color_kod"), dataRow.Field<String>("colorname"), null));
            conn.Close();
            return colors;
        }
        //public static Dictionary<string, Fabricator> SelectAllFabricator()
        //{
        //    string sql = "SELECT fabricator_kod, fabricatorname FROM fabricator";
        //    MySqlConnection conn = GetConnection();
        //    MySqlCommand cmd = new MySqlCommand(sql, conn);
        //    cmd.CommandType = CommandType.Text;
        //    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
        //    DataSet ds = new DataSet();
        //    adapter.Fill(ds);

        //    Dictionary<string, Fabricator> fabricators = new Dictionary<string, Fabricator>();

        //    foreach (DataRow row in ds.Tables[0].Rows)
        //    {
        //        int fabricatorKod = Convert.ToInt32(row["fabricator_kod"]);
        //        string fabricatorName = row["fabricatorname"].ToString();
        //        string key = $"{fabricatorKod}_{fabricatorName}"; // Создание уникального ключа
        //        Fabricator fabricator = new Fabricator(fabricatorKod, fabricatorName);
        //        fabricators.Add(key, fabricator);
        //    }

        //    conn.Close();
        //    return fabricators;
        //}

        public static Dictionary<string, Fabricator> SelectAllFabricator()
        {
            string sql = "SELECT fabricator_kod, fabricatorname FROM fabricator";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            Dictionary<string, Fabricator> fabricators = ds.Tables[0].AsEnumerable().ToDictionary<DataRow, string, Fabricator>(dataRow => dataRow.Field<String>("fabricatorname"), dataRow => new Fabricator(dataRow.Field<Int32>("fabricator_kod"), dataRow.Field<String>("fabricatorname")));
            conn.Close();
            return fabricators;
        }

        public static void DisplayTovars(DataGridView dgv)
        {
            string sql = "SELECT kod_tovar AS 'ID', name.naming AS 'Name', size AS 'Size', brand.brandname AS 'Brand', sole_height AS 'Sole', material.materialname AS 'Material', color.colorname AS 'Color', guarantee AS 'Guarantee', fabricator.fabricatorname AS 'Fabricator', price AS 'Price', amount AS 'Amount' FROM tovar " +
                         "JOIN name ON tovar.name = name.name_kod " +
                         "JOIN brand ON tovar.brand = brand.brand_kod " +
                         "JOIN material ON tovar.material = material.material_kod " +
                         "JOIN color ON tovar.color = color.color_kod " +
                         "JOIN fabricator ON tovar.fabricator = fabricator.fabricator_kod";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            conn.Close();
        }

        public static void DisplayCart(DataGridView dgv, Client client)
        {
            string sql = "SELECT tovar.kod_tovar AS 'ID', name.naming AS 'Name', brand.brandname AS 'Brand', tovar.size AS 'Size', tovar.price AS 'Price' FROM cart " +
                         "JOIN tovar ON cart.tovar_kod = tovar.kod_tovar " +
                         "JOIN name ON tovar.name = name.name_kod " +
                         "JOIN brand ON tovar.brand = brand.brand_kod " +
                         "WHERE client_login = @Login";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Login", MySqlDbType.VarChar).Value = client.Login;
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            conn.Close();
        }

        public static void DisplaySale(DataGridView dgv)
        {
            string sql = "SELECT sale_kod, name.naming AS 'tovar', sale.price AS 'Price', sale.amount AS 'amount', staff.surname AS 'staff', date FROM sale " +
                         "JOIN tovar ON sale.tovar_kod = tovar.kod_tovar " +
                         "JOIN name ON tovar.name = name.name_kod " +
                         "JOIN staff ON staff.staff_kod = sale.staff";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            conn.Close();
        }

        public static List<Staff> GetAllStaffOnlyID()
        {
            string sql = "SELECT staff_kod FROM staff";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Staff> staffs = new List<Staff>();
            while (reader.Read())
            {
                staffs.Add(new Staff(Convert.ToInt32(reader["staff_kod"]), null, null, -1, null));
            }
            conn.Close();
            return staffs;
        }
        public static void DisplaySaleByTovar(DataGridView dgv, int id)
        {
            string sql = "SELECT sale_kod, name.naming AS 'tovar', sale.price AS 'Price', sale.amount AS 'amount', staff.surname AS 'staff', date FROM sale " +
                         "JOIN tovar ON sale.tovar_kod = tovar.kod_tovar " +
                         "JOIN name ON tovar.name = name.name_kod " +
                         "JOIN staff ON staff.staff_kod = sale.staff " +
                         "WHERE sale.tovar_kod = @id";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            conn.Close();
        }

        public static DataTable GetFabricators()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM fabricator";
            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                try
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Ошибка при получении списка производителей:\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return dt;
        }

        public static DataTable GetBrands()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM brand";
            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                try
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Ошибка при получении списка брендов:\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return dt;
        }

        public static DataTable GetMaterials()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM material";
            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                try
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Ошибка при получении списка материалов:\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return dt;
        }

        public static List<Staff> GetAllStaff()
        {
            List<Staff> staffList = new List<Staff>();

            string sql = "SELECT * FROM staff";

            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                try
                {
                    // Открываем соединение перед выполнением запроса
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["staff_kod"]);
                            string surname = reader["surname"].ToString();
                            string name = reader["name"].ToString();
                            long phone = Convert.ToInt64(reader["phone"]);
                            string position = reader["position"].ToString();

                            // Создаем объект сотрудника и добавляем его в список
                            Staff staff = new Staff(id, surname, name, phone, position);
                            staffList.Add(staff);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Ошибка при получении списка сотрудников:\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return staffList;
        }

        public static DataTable GetAllColors()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM color";
            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                try
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Ошибка при получении списка цветов:\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return dt;
        }

        public static DataTable GetAllNames()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM name";
            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                try
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Ошибка при получении списка имен:\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return dt;
        }

        public static DataTable GetAllStaffDT()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM staff";
            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                try
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Ошибка при получении списка сотрудников:\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return dt;
        }
    }
}
