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

namespace DBCreator
{
    public partial class AEDTeacherProfile : MetroForm
    {
        String connStr = "Server=localhost; Port=3306; Database=taleemdatabase; Uid=root; Pwd=admin;";
        public AEDTeacherProfile()
        {
            InitializeComponent();
            showTeacherList();
        }

        private void showTeacherList()
        {
            MySqlConnection connection = new MySqlConnection(connStr);
            connection.Open();

            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT FirstName, LastName FROM teacherlogin";
                MySqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    String name = reader.GetString(0) + " " + reader.GetString(1);
                    teacherListBox.Items.Add(name);
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

        //Displays the teacher's details from the DB
        private void showTeacherDetails()
        {
            String[] splitName = teacherListBox.SelectedItem.ToString().Split(' ');
            String fname = splitName[0], lname = splitName[1];
            MySqlConnection connection = new MySqlConnection(connStr);
            connection.Open();
            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT FirstName, LastName, ClassSection, Username, Password FROM teacherlogin WHERE FirstName='" + fname + "' AND LastName='" + lname + "' ;";
                MySqlDataReader reader = cmd.ExecuteReader();

                int count = 0;
                while(reader.Read())
                {
                    count++;
                }
                if(count == 1)
                {
                    fnameText.Text = reader.GetString(0);
                    lnameText.Text = reader.GetString(1);
                    classSecText.Text = reader.GetString(2);
                    userText.Text = reader.GetString(3);
                    passText.Text = reader.GetString(4);
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

        //Listbox event
        private void teacherListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            showTeacherDetails();
        }

        //Checks if fields are empty or not
        private bool checkFields()
        {
            if(fnameText.Text.Length > 0 && lnameText.Text.Length > 0 && classSecText.Text.Length > 0
                && userText.Text.Length > 0 && passText.Text.Length > 0)
            {
                return true;
            }
            return false;
        }

        //Edit teacher profile
        private void editProfileBtn_Click(object sender, EventArgs e)
        {
            String[] splitName = null;
            String fname = null, lname = null;

            MySqlConnection connection = new MySqlConnection(connStr);
            connection.Open();

            if(checkFields() == true)
            {
                try
                {
                    splitName = teacherListBox.SelectedItem.ToString().Split(' ');
                    fname = splitName[0];
                    lname = splitName[1];
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = @"UPDATE teacherlogin SET FirstName='" + fnameText.Text + "', LastName='" 
                    + lnameText.Text + "', ClassSection='" + classSecText.Text + "', Username='" + userText.Text
                    + "', Password='" + passText.Text + "' WHERE FirstName='" + fname + "' AND LastName='" + lname + "'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Teacher profile updated !");
                }
                catch(Exception)
                {
                    if (splitName == null || fname == null || lname == null)
                    {
                        MessageBox.Show("Select a teacher !");
                    }
                }
                finally
                {
                    if(connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                        clearFields();
                        teacherListBox.Items.Clear();
                        showTeacherList();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill in the fields");
            }
        }

        //Add teacher profile
        private void addProfileBtn_Click(object sender, EventArgs e)
        {
            if (checkFields() == true)
            {
                String firstName = fnameText.Text;
                String lastName = lnameText.Text;
                String classSection = classSecText.Text;
                String userName = userText.Text;
                String password = passText.Text;

                String connectionStr = "Server=localhost; Port=3306; Database=taleemdatabase; Uid=root; Pwd=admin;";
                MySqlConnection connection = new MySqlConnection(connectionStr);
                MySqlCommand cmd;
                connection.Open();

                try
                {
                    cmd = connection.CreateCommand();
                    cmd.CommandText = "INSERT INTO teacherlogin (FirstName, LastName, ClassSection, Username, Password) VALUES (@FirstName, @LastName, @ClassSection, @Username, @Password)";
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    cmd.Parameters.AddWithValue("@ClassSection", classSection);
                    cmd.Parameters.AddWithValue("@Username", userName);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Teacher profile added !");
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        clearFields();
                        teacherListBox.Items.Clear();
                        showTeacherList();
                        //Create DB and Create Tables
                        CreateNewDB(classSection);
                        CreateNewTables(classSection);
                        connection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Fill in the blanks !");
            }
        }

        //Create Schema/Database for new users
        private void CreateNewDB(String classSection)
        {
            String connectionStr = "Server=localhost; Port=3306; Uid=root; Pwd=admin;";
            MySqlConnection connection = new MySqlConnection(connectionStr);

            try
            {
                connection.Open();
                MySqlCommand cmd;
                cmd = connection.CreateCommand();
                //e.g: class1a_db
                cmd.CommandText = "CREATE SCHEMA IF NOT EXISTS class" + classSection + "_db";
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        //Insert new tables for new users
        private void CreateNewTables(String classSection)
        {
            String database = "class" + classSection + "_db";
            String connectionStr = "Server=localhost; Port=3306; Database=" + database + "; Uid=root; Pwd=admin;";
            MySqlConnection connection = new MySqlConnection(connectionStr);

            try
            {
                String cmdString = @"CREATE TABLE IF NOT EXISTS studentinfo (
                                    idStudent INT NOT NULL AUTO_INCREMENT,
                                    FirstName VARCHAR(45) NULL,
                                    LastName VARCHAR(45) NULL,
                                    DOB VARCHAR(45) NULL,
                                    isColorBlind VARCHAR(45) NULL,
                                    isBlind VARCHAR(45) NULL,
                                    Image MEDIUMBLOB NULL,
                                    PRIMARY KEY(idStudent));";

                String cmdString2 = @"CREATE TABLE IF NOT EXISTS levelmngr (
                                    idPhases INT NOT NULL AUTO_INCREMENT,
                                    Phases INT NOT NULL,
                                    Levels VARCHAR(45) NULL,
                                    isSet VARCHAR(45) NULL,
                                    PRIMARY KEY(idPhases));";

                MySqlCommand cmd = new MySqlCommand(cmdString, connection);
                MySqlCommand cmd2 = new MySqlCommand(cmdString2, connection);

                connection.Open();
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
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


        private void clearFields()
        {
            fnameText.Clear();
            lnameText.Clear();
            classSecText.Clear();
            userText.Clear();
            passText.Clear();
        }

        private void deleteDB(String classSec)
        {
            String database = "class" + classSec + "_db";
            String connStr = "Server=localhost; Port=3306; Uid=root; Pwd=admin;";
            MySqlConnection connection = new MySqlConnection(connStr);
            connection.Open();
            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "DROP SCHEMA IF EXISTS ";
                cmd.CommandText = "DROP SCHEMA IF EXISTS " + database;
                cmd.ExecuteNonQuery();
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

        //Delete teacher profile
        private void delProfileBtn_Click(object sender, EventArgs e)
        {
            String[] splitName = null;
            String fname = null, lname = null;
            String classSec = null;
            MySqlConnection connection = null;
            try
            {
                splitName = teacherListBox.SelectedItem.ToString().Split(' ');
                fname = splitName[0];
                lname = splitName[1];
                classSec = classSecText.Text;
                connection = new MySqlConnection(connStr);
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "DELETE from teacherlogin WHERE FirstName='" + fname + "' AND LastName='" + lname + "';";
                MessageBox.Show("Teacher profile deleted !");
                cmd.ExecuteNonQuery();
            }
            catch(Exception)
            {
                if(splitName == null || fname == null || lname == null || classSec == null)
                {
                    MessageBox.Show("Select a teacher !");
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
                    deleteDB(classSec);
                    clearFields();
                    teacherListBox.Items.Clear();
                    showTeacherList();
                }
            }
        }
    }
}
