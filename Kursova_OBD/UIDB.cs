using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.AxHost;
using System.Xml.Linq;

namespace Kursova_OBD
{
    public partial class UIDB : Form
    {
        private ConnectionDB dbconnection;
        private SqlConnection connection;
        public UIDB()
        {
            InitializeComponent();
            InitBoxes();
            dbconnection = new ConnectionDB();
            connection = dbconnection.GetConnection();
        }
        

        private void InitBoxes()// завантаження списків у комбо-бокси
        {
            // Отримання списку таблиць
            DataTable tables = connection.GetSchema("Tables");
            foreach (DataRow row in tables.Rows)
            {
                string tableName = row["TABLE_NAME"].ToString();
                cb_table.Items.Add(tableName);
            }
        }
        private void btn_s_Click(object sender, EventArgs e) // додання запису про нового жильця
        {

            // Отримання значень з елементів форми

            string passport = tb_passport_add.Text;
            bool state = rb_f_add.Checked;
            string sirname = tb_passport_add.Text;
            string name = tb_name_add.Text;
            string miile = tb_middle_add.Text;
            string famile = cb_famile_add.SelectedItem.ToString();
            DateTime date_of = dp_dob_add.Value;
            string peace = tb_pob_add.Text;
            string addres = tb_addres_add.Text;
            string phone = tp_phone_add.Text;

            string query = "INSERT INTO YourTable (Column1, Column2, Column3, Column4, Column5, ComboBoxColumn, DateTimeColumn, RadioButtonColumn) " +
                               "VALUES (@Value1, @Value2, @Value3, @Value4, @Value5, @ComboBoxValue, @DateTimeValue, @RadioButtonValue)";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Передача значень параметрам
                command.Parameters.AddWithValue("@Value1", passport);
                command.Parameters.AddWithValue("@Value2", state);
                command.Parameters.AddWithValue("@Value3", sirname);
                command.Parameters.AddWithValue("@Value4", name);
                command.Parameters.AddWithValue("@Value5", miile);
                command.Parameters.AddWithValue("@ComboBoxValue", famile);
                command.Parameters.AddWithValue("@DateTimeValue", date_of);
                command.Parameters.AddWithValue("@RadioButtonValue", peace);
                command.Parameters.AddWithValue("@RadioButtonValue", addres);
                command.Parameters.AddWithValue("@RadioButtonValue", phone);
                // Виконання SQL-запиту
                command.ExecuteNonQuery();
            }
        }

        private void btn_ardhive_Click(object sender, EventArgs e) // перенесення окремо мертвого жильця з однієї таблички в іншу. Всюди треба поміняти шлях
        {

            // Встановлення SQL-запиту для вибору запису з джерела
            string selectQuery = "SELECT * FROM SourceTable WHERE ID = @ID";

            // Встановлення SQL-запиту для вставки запису в призначення
            string insertQuery = "INSERT INTO DestinationTable (Column1, Column2, Column3) VALUES (@Value1, @Value2, @Value3)";

            // Встановлення SQL-запиту для видалення запису з джерела
            string deleteQuery = "DELETE FROM SourceTable WHERE ID = @ID";

            int recordID = 1; // ID запису, який ми хочемо скопіювати та видалити

            using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
            {
                selectCommand.Parameters.AddWithValue("@ID", recordID);

                using (SqlDataReader reader = selectCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Отримання значень зі зчитаного запису
                        string value1 = reader.GetString(reader.GetOrdinal("Column1"));
                        int value2 = reader.GetInt32(reader.GetOrdinal("Column2"));
                        string value3 = reader.GetString(reader.GetOrdinal("Column3"));

                        // Вставка запису в призначення
                        using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@Value1", value1);
                            insertCommand.Parameters.AddWithValue("@Value2", value2);
                            insertCommand.Parameters.AddWithValue("@Value3", value3);

                            insertCommand.ExecuteNonQuery();
                        }
                    }
                }
            }

            // Видалення запису з джерела
            using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
            {
                deleteCommand.Parameters.AddWithValue("@ID", recordID);

                deleteCommand.ExecuteNonQuery();
            }

        }

        private void btn_find_Click(object sender, EventArgs e) //пошук людині по паспорту, імені, фамілії
        {
            string selectQuery = "SELECT * FROM YourTable WHERE Passport = @Passport AND Surname = @Surname AND Name = @Name AND Maddlename = @Maddlename";

            string passport = tb_passport.Text;
            string sirname = tb_sirname.Text;
            string name = tb_name.Text;
            string middlename = tb_maddlename.Text;

            using (SqlCommand command = new SqlCommand(selectQuery, connection))
            {
                command.Parameters.AddWithValue("@Passport", passport);
                command.Parameters.AddWithValue("@Sirname", sirname);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Maddlename", middlename);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string family = reader.GetString(reader.GetOrdinal("Family"));
                        string pob = reader.GetString(reader.GetOrdinal("POB"));
                        DateTime dob = reader.GetDateTime(reader.GetOrdinal("DOB"));
                        string address = reader.GetString(reader.GetOrdinal("Address"));
                        string number = reader.GetString(reader.GetOrdinal("Number"));

                        // Виконайте необхідні дії зі знайденими значеннями
                        tb_family.Text = family;
                        tb_pob.Text = pob;
                        dp_dob.Text = dob.ToString(); // Перетворення DateTime на рядок
                        tb_addres.Text = address;
                        tb_number.Text = number;

                        MessageBox.Show("Запис знайдено.");
                    }
                    else
                    {
                        MessageBox.Show("Запис не знайдено.");
                    }
                }
            }
        }

        private void btn_change_Click(object sender, EventArgs e) // перехід у вкладку, де будуть змінені дані про знайденого жильця
        {
            tb_passport_add.Text = tb_passport.Text;
            tb_sirmane_add.Text = tb_sirname.Text;
            rb_f_add.Checked = rb_f.Checked; rb_m_add.Checked = rb_m.Checked;
            tb_name_add.Text = tb_name_add.Text;
            tb_middle_add.Text = tb_maddlename.Text;
            cb_famile_add.Text = tb_family.Text;
            tb_pob_add.Text = tb_pob.Text;
            dp_dob_add.Text = dp_dob.Text;
            tb_addres_add.Text = tb_addres.Text;
            tp_phone_add.Text = tb_number.Text;
        }

        private void btn_clean_Click(object sender, EventArgs e)// очищення полів налашутвання звіту
        {
            cb_type_report.SelectedIndex = -1;
            cb_table.SelectedItem = null;
            cb_column.SelectedIndex = -1;
            cb_sort.SelectedIndex = -1;
            cb_report_name.SelectedIndex = -1;
            dgv_report.Rows.Clear();
        }

        private void btn_save_Click(object sender, EventArgs e) // збереження звіту як ксв
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
            saveFileDialog.Title = "Save Report";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                // Відкриття файлу для запису
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Запис заголовків стовпців
                    for (int i = 0; i < dgv_report.Columns.Count; i++)
                    {
                        writer.Write(dgv_report.Columns[i].HeaderText);
                        if (i < dgv_report.Columns.Count - 1)
                        {
                            writer.Write(",");
                        }
                    }
                    writer.WriteLine();

                    // Запис даних рядків
                    foreach (DataGridViewRow row in dgv_report.Rows)
                    {
                        for (int i = 0; i < dgv_report.Columns.Count; i++)
                        {
                            if (row.Cells[i].Value != null)
                            {
                                writer.Write(row.Cells[i].Value.ToString());
                            }
                            if (i < dgv_report.Columns.Count - 1)
                            {
                                writer.Write(",");
                            }
                        }
                        writer.WriteLine();
                    }
                }

                MessageBox.Show("Звіт був успішно збережений.", "Зберегти звіт", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            string selectedTable = cb_table.SelectedItem.ToString();

            if (cb_type_report.SelectedIndex == 1)
            {
                string selectQuery = $"SELECT * FROM {cb_table.SelectedItem.ToString()} ORDER BY {cb_column.SelectedItem.ToString()} {cb_sort.SelectedItem.ToString()}";

                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    // Виконати запит на вибірку даних
                    SqlDataReader reader = command.ExecuteReader();

                    dgv_report.Rows.Clear();
                    dgv_report.Columns.Clear();

                    // Зчитування даних з SqlDataReader і заповнення DataGridView
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        // Додавання стовпців до DataGridView
                        dgv_report.Columns.Add(reader.GetName(i), reader.GetName(i));
                    }

                    while (reader.Read())
                    {
                        // Створення нового рядка DataGridView
                        DataGridViewRow row = new DataGridViewRow();

                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            // Додавання значень до рядка DataGridView
                            row.Cells.Add(new DataGridViewTextBoxCell { Value = reader[i] });
                        }

                        // Додавання рядка до DataGridView
                        dgv_report.Rows.Add(row);
                    }

                    // Закриття SqlDataReader
                    reader.Close();

                }
            }
            else
            {
                string selectedReportName = cb_report_name.SelectedItem.ToString();

                // Виконати дії для інших типів звітів
                // Наприклад, відобразити ім'я таблички CSV у DataGridView dgv_report
                dgv_report.Rows.Clear();
                dgv_report.Columns.Clear();

                // Завантажити дані з CSV-файлу
                DataTable csvData = LoadCSV(selectedReportName);

                // Додати стовпці до DataGridView
                foreach (DataColumn column in csvData.Columns)
                {
                    dgv_report.Columns.Add(column.ColumnName, column.ColumnName);
                }
                // Додати рядки з даними до DataGridView
                foreach (DataRow row in csvData.Rows)
                {
                    dgv_report.Rows.Add(row.ItemArray);
                }
            }
        }
        private DataTable LoadCSV(string filePath)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string[] headers = sr.ReadLine().Split(',');
                    foreach (string header in headers)
                    {
                        dataTable.Columns.Add(header);
                    }

                    while (!sr.EndOfStream)
                    {
                        string[] rows = sr.ReadLine().Split(',');
                        DataRow dataRow = dataTable.NewRow();
                        for (int i = 0; i < headers.Length; i++)
                        {
                            dataRow[i] = rows[i];
                        }
                        dataTable.Rows.Add(dataRow);
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return dataTable;
        }

        private void cb_table_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_table.Items.Count > 0)
            {
                string selectedTable = cb_table.Items[0].ToString();
                DataTable columns = connection.GetSchema("Columns", new string[] { null, null, selectedTable });
                foreach (DataRow row in columns.Rows)
                {
                    string columnName = row["COLUMN_NAME"].ToString();
                    cb_column.Items.Add(columnName);
                }
            }

        }

        private void cb_type_report_SelectedIndexChanged(object sender, EventArgs e)
        {

            p_new.Visible = !p_new.Visible; p_new.Enabled = !p_new.Enabled;
            p_ready.Visible = !p_ready.Visible; p_ready.Enabled = !p_ready.Enabled;

        }
    }
}
