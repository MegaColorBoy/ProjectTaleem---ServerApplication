using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MetroFramework.Forms;
using MetroFramework.Controls;
using MetroFramework;
using MySql.Data.MySqlClient;

//An important feature to manage databases, tables and columns !
namespace DBCreator
{
    public partial class ModifyDB : MetroForm
    {
        public ModifyDB()
        {
            InitializeComponent();
            showDBList();
            showDBList2();
            showDBList3();
            showTypeList();
        }

        //Shows a list of databases
        private void showDBList()
        {
            String connStr = "Server=localhost; Port=3306; Uid=root; Pwd=admin;";
            MySqlConnection connection = new MySqlConnection(connStr);
            connection.Open();

            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SHOW DATABASES";
                MySqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    String row = "";
                    for(int i=0; i<reader.FieldCount; i++)
                    {
                        row += reader.GetValue(i).ToString();
                    }
                    dbListBox.Items.Add(row);
                }
                reader.Close();
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                if(connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

        }

        private void showDBList2()
        {
            String connStr = "Server=localhost; Port=3306; Uid=root; Pwd=admin;";
            MySqlConnection connection = new MySqlConnection(connStr);
            connection.Open();

            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SHOW DATABASES";
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    String row = "";
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        row += reader.GetValue(i).ToString();
                    }
                    dbListBox2.Items.Add(row);
                }
                reader.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void showDBList3()
        {
            String connStr = "Server=localhost; Port=3306; Uid=root; Pwd=admin;";
            MySqlConnection connection = new MySqlConnection(connStr);
            connection.Open();

            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SHOW DATABASES";
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    String row = "";
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        row += reader.GetValue(i).ToString();
                    }
                    dbListBox3.Items.Add(row);
                }
                reader.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void showTables()
        {
            String database = dbListBox2.SelectedItem.ToString();
            String connStr = "Server=localhost; Port=3306; Database=" + database + "; Uid=root; Pwd=admin;";
            MySqlConnection connection = new MySqlConnection(connStr);
            connection.Open();
            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SHOW TABLES";
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    String row = "";
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        row += reader.GetValue(i).ToString();
                    }
                    tableListBox.Items.Add(row);
                }
                reader.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void showTables2()
        {
            String database = dbListBox.SelectedItem.ToString();
            String connStr = "Server=localhost; Port=3306; Database=" + database + "; Uid=root; Pwd=admin;";
            MySqlConnection connection = new MySqlConnection(connStr);
            connection.Open();
            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SHOW TABLES";
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    String row = "";
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        row += reader.GetValue(i).ToString();
                    }
                    tableListBox2.Items.Add(row);
                }
                reader.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void showTables3()
        {
            String database = dbListBox3.SelectedItem.ToString();
            String connStr = "Server=localhost; Port=3306; Database=" + database + "; Uid=root; Pwd=admin;";
            MySqlConnection connection = new MySqlConnection(connStr);
            connection.Open();
            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SHOW TABLES";
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    String row = "";
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        row += reader.GetValue(i).ToString();
                    }
                    tableListBox3.Items.Add(row);
                }
                reader.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void showColumns()
        {
            String database = null;
            String table = null;
            String connStr = null;
            MySqlConnection connection = null;

            try
            {
                database = dbListBox2.SelectedItem.ToString();
                table = tableListBox.SelectedItem.ToString();
                connStr = "Server=localhost; Port=3306; Database=" + database + "; Uid=root; Pwd=admin;";
                connection = new MySqlConnection(connStr);
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SHOW COLUMNS FROM " + table;
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    String row = "";
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        row += reader.GetValue(i).ToString() + " ";
                    }
                    columnListBox.Items.Add(splitStr(row));
                }
                reader.Close();
            }
            catch (Exception)
            {
                if (database == null || table == null)
                {
                    MessageBox.Show("Please select db and table");
                }
            }
            finally
            {
                if(connection == null)
                {

                }
                else  if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private String splitStr(String str)
        {
            String[] splitArr = str.Split(' ');
            return splitArr[0];
        }

        //Add database
        private void addDBBtn_Click(object sender, EventArgs e)
        {
            String database = null;
            String connStr = null;
            MySqlConnection connection = null;

            try
            {
                database = dbText.Text;
                connStr = "Server=localhost; Port=3306; Uid=root; Pwd=admin;";
                connection = new MySqlConnection(connStr);
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "CREATE SCHEMA IF NOT EXISTS " + database + ";";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Database added !");
            }
            catch(Exception)
            {
                if(database == null)
                {
                    MessageBox.Show("Enter a database name !");
                }
            }
            finally
            {
                if(connection.State == ConnectionState.Open)
                {
                    connection.Close();
                    dbText.Clear();
                    dbListBox.Items.Clear();
                    dbListBox2.Items.Clear();
                    dbListBox3.Items.Clear();
                    showDBList();
                    showDBList2();
                    showDBList3();
                }
            }
        }

        //Delete database
        private void delDBBtn_Click(object sender, EventArgs e)
        {
            String database = null;
            String connStr = null;
            MySqlConnection connection = null;
            MySqlCommand cmd = null;
            try
            {
                database = dbListBox.SelectedItem.ToString();
                connStr = "Server=localhost; Port=3306; Uid=root; Pwd=admin;";
                connection = new MySqlConnection(connStr);
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandText = "DROP SCHEMA IF EXISTS " + database;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Database deleted !");
            }
            catch(Exception)
            {
                if(database == null)
                {
                    MessageBox.Show("Please select a DB to delete");
                }
            }
            finally
            {
                if(connection == null)
                {
                    //Do nothing
                }
                else if(connection.State == ConnectionState.Open)
                {
                    connection.Close();
                    dbListBox.Items.Clear();
                    dbListBox2.Items.Clear();
                    dbListBox3.Items.Clear();
                    showDBList();
                    showDBList2();
                    showDBList3();
                }
            }
        }

        //Listbox events
        //-----------------------------------------------------------------------//
        private void dbListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            tableListBox.Items.Clear();
            showTables();
        }

        private void tableListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            columnListBox.Items.Clear();
            showColumns();
        }

        private void dbListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            tableListBox2.Items.Clear();
            showTables2();
        }

        private void dbListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            tableListBox3.Items.Clear();
            showTables3();
        }
        //-----------------------------------------------------------------------//

        //Type of data for columns
        private void showTypeList()
        {
            typeListBox.Items.Add("STRING");
            typeListBox.Items.Add("BLOB");
            typeListBox.Items.Add("INT");
            typeListBox.Items.Add("FLOAT");
            typeListBox.Items.Add("DOUBLE");
        }

        //String builder for adding a column
        private String setColumnDataType(String dataType, String table, String column)
        {
            if(dataType == "BLOB")
            {
                return "ALTER TABLE " + table + " ADD " + column + " MEDIUMBLOB NULL";
            }
            else if(dataType == "INT")
            {
                return "ALTER TABLE " + table + " ADD " + column + " INT NOT NULL";
            }
            else if (dataType == "DOUBLE")
            {
                return "ALTER TABLE " + table + " ADD " + column + " DOUBLE NOT NULL";
            }
            else if (dataType == "FLOAT")
            {
                return "ALTER TABLE " + table + " ADD " + column + " FLOAT NOT NULL";
            }
            else
            {
                return "ALTER TABLE " + table + " ADD " + column + " VARCHAR(45) NULL";
            }
        }

        //Add a column
        private void addColumnBtn_Click(object sender, EventArgs e)
        {
            String database = null;
            String table = null;
            String dataType = null;
            String column = null;
            String connStr = null;
            MySqlConnection connection = null;

            try
            {
                database = dbListBox.SelectedItem.ToString();
                table = tableListBox2.SelectedItem.ToString();
                column = columnText.Text;
                dataType = typeListBox.SelectedItem.ToString();

                connStr = "Server=localhost; Port=3306; Database=" + database + "; Uid=root; Pwd=admin;";
                connection = new MySqlConnection(connStr);
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = setColumnDataType(dataType, table, column);
                MessageBox.Show("New column added !");
                cmd.ExecuteNonQuery();
            }
            catch(Exception)
            {
                if(database == null || table == null || column == null || dataType == null)
                {
                    MessageBox.Show("Please select a db and table!\nOr enter a name for column and select a datatype!");
                }
                else
                {
                    throw;
                }
            }
            finally
            {
                if(connection == null)
                {
                    //Do nothing !
                }
                else if(connection.State == ConnectionState.Open)
                {
                    connection.Close();
                    columnText.Clear();
                    columnListBox.Items.Clear();
                    showColumns();
                }
            }
        }

        //Deletes a column
        private void delColumnBtn_Click(object sender, EventArgs e)
        {
            String database = null;
            String table = null;
            String column = null;
            String connStr = null;
            MySqlConnection connection = null;
            
            try
            {
                database = dbListBox2.SelectedItem.ToString();
                table = tableListBox.SelectedItem.ToString();
                column = columnListBox.SelectedItem.ToString();
                connStr = "Server=localhost; Port=3306; Database=" + database + "; Uid=root; Pwd=admin;";
                connection = new MySqlConnection(connStr);
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "ALTER TABLE " + table + " DROP COLUMN " + column + ";";
                MessageBox.Show("Column deleted !");
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                if (database == null || table == null || column == null)
                {
                    MessageBox.Show("Please select db, table and column");
                }
            }
            finally
            {
                if(connection == null)
                {
                    //Do nothing !
                }
                else if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                    columnListBox.Items.Clear();
                    showColumns();
                }
            }
        }

        //Add table
        private void addTableBtn_Click(object sender, EventArgs e)
        {
            String database = null;
            String table = null;
            String connStr = null;
            MySqlConnection connection = null;

            try
            {
                database = dbListBox3.SelectedItem.ToString();
                table = tableText.Text;
                connStr = "Server=localhost; Port=3306; Database=" + database + "; Uid=root; Pwd=admin;";
                connection = new MySqlConnection(connStr);
                connection.Open();

                MySqlCommand cmd = connection.CreateCommand();
                //Creates with a default PRIMARY KEY ID Column, if you want to add more columns
                //Use the "Add Columns" feature !
                cmd.CommandText = "CREATE TABLE IF NOT EXISTS " + table + "(" + table + "ID INT NOT NULL AUTO_INCREMENT, PRIMARY KEY(" + table + "ID));";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Table added !");
            }
            catch(Exception)
            {
                if(database == null || table == null | connStr == null)
                {
                    MessageBox.Show("Please select a DB or enter a table name !");
                }
            }
            finally
            {
                if(connection == null)
                {
                    //Do nothing !
                }
                else if(connection.State == ConnectionState.Open)
                {
                    connection.Close();
                    tableText.Clear();
                    tableListBox3.Items.Clear();
                    showTables3();
                }
            }
        }

        //Delete table
        private void delTableBtn_Click(object sender, EventArgs e)
        {
            String database = null;
            String table = null;
            String connStr = null;
            MySqlConnection connection = null;

            try
            {
                database = dbListBox3.SelectedItem.ToString();
                table = tableListBox3.SelectedItem.ToString();
                connStr = "Server=localhost; Port=3306; Database=" + database + "; Uid=root; Pwd=admin;";
                connection = new MySqlConnection(connStr);
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "DROP TABLE " + table + ";";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Table deleted !");
            }
            catch(Exception)
            {
                if(database == null || table == null || connStr == null)
                {
                    MessageBox.Show("Please select a db and a table");
                }
            }
            finally
            {
                if(connection == null)
                {
                    //Do nothing !
                }
                else if(connection.State == ConnectionState.Open)
                {
                    connection.Close();
                    tableListBox3.Items.Clear();
                    showTables3();
                }
            }
        }




    }
}
