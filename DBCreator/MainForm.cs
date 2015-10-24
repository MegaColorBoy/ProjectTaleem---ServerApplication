using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using MetroFramework.Forms;
using MetroFramework.Controls;
using MetroFramework;
using MySql.Data.MySqlClient;

/* This is for the main Ta'leem database which contains
 * the teacher login details, audio and image files tables
 * 
 * Easier to generate teacher database into a new device/PC
 * Easier to manage image and audio files
 * 
 * Able to import/export database as well
 * This is designed as a tool for the team members only.
 * and also built it for fun ! :D
 */
namespace DBCreator
{
    public partial class MainForm : MetroForm
    {
        String connStr = "Server=localhost; Port=3306; Uid=root; Pwd=admin;";
        public MainForm()
        {
            InitializeComponent();
            showDBList();
        }

        //This generates the main database that contains teacher login details, image and audio tables
        private void generateDB_Btn_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connStr);
            try
            {
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "CREATE SCHEMA IF NOT EXISTS taleemdatabase";
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    //Generates teacher login details, image and audio tables
                    generateTables();
                    connection.Close();
                }
            }
        }

        //Generates tables for the main db, which is 'taleemdatabase'
        private void generateTables()
        {
            String connStr = "Server=localhost; Port=3306; Database=taleemdatabase; Uid=root; Pwd=admin;";
            MySqlConnection connection = new MySqlConnection(connStr);
            connection.Open();
            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                MySqlCommand cmd2 = connection.CreateCommand();
                MySqlCommand cmd3 = connection.CreateCommand();
                MySqlCommand cmd4 = connection.CreateCommand();
                MySqlCommand cmd5 = connection.CreateCommand();
                MySqlCommand cmd6 = connection.CreateCommand();

                cmd.CommandText = @"CREATE TABLE IF NOT EXISTS teacherlogin (
                                    teacherID INT NOT NULL AUTO_INCREMENT,
                                    FirstName VARCHAR(45) NULL,
                                    LastName VARCHAR(45) NULL,
                                    ClassSection VARCHAR(45) NULL,
                                    Username VARCHAR(45) NULL,
                                    Password VARCHAR(45) NULL,
                                    PRIMARY KEY(teacherID));";

                cmd2.CommandText = @"CREATE TABLE IF NOT EXISTS image_db (
                                    imageID INT NOT NULL AUTO_INCREMENT,
                                    PhonicsName VARCHAR(45) NULL,
                                    Image MEDIUMBLOB NULL,
                                    PRIMARY KEY(imageID));";

                cmd3.CommandText = @"CREATE TABLE IF NOT EXISTS audio_db (
                                    audioID INT NOT NULL AUTO_INCREMENT,
                                    PhonicsName VARCHAR(45) NULL,
                                    Audio MEDIUMBLOB NULL,
                                    PRIMARY KEY(audioID));";

                cmd4.CommandText = @"CREATE TABLE IF NOT EXISTS flash_db (
                                     flashID INT NOT NULL AUTO_INCREMENT,
                                     Letters VARCHAR(45) NULL,
                                     Flash MEDIUMBLOB NULL,
                                     PRIMARY KEY(flashID));";

                cmd5.CommandText = @"CREATE TABLE IF NOT EXISTS wordbank_db (
                                     wordID INT NOT NULL AUTO_INCREMENT,
                                     Word VARCHAR(45) NULL,
                                     Image MEDIUMBLOB NULL,
                                     Audio MEDIUMBLOB NULL,
                                     PRIMARY KEY(wordID));";

                cmd6.CommandText = @"CREATE TABLE IF NOT EXISTS spelltable_db (
                                     wordID INT NOT NULL AUTO_INCREMENT,
                                     Word VARCHAR(45) NULL,
                                     Image MEDIUMBLOB NULL,
                                     PRIMARY KEY(wordID));";

                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();
                cmd4.ExecuteNonQuery();
                cmd5.ExecuteNonQuery();
                cmd6.ExecuteNonQuery();

                MessageBox.Show("Database generated !");
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

        //Upload audio files to DB
        private void upldAudioBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select folder which contains the audio files:";
            DialogResult result = fbd.ShowDialog();
            if (fbd.SelectedPath.Length > 0)
            {
                String[] files = Directory.GetFiles(fbd.SelectedPath, "*.wav");
                String connStr = "Server=localhost; Port=3306; Database=taleemdatabase; Uid=root; Pwd=admin;";
                MySqlConnection connection = new MySqlConnection(connStr);
                MySqlCommand cmd;
                FileStream fs;
                BinaryReader br;
                connection.Open();

                try
                {
                    for (int i = 0; i < files.Length; i++)
                    {
                        String filename = files[i];
                        byte[] AudioData;
                        fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
                        br = new BinaryReader(fs);
                        AudioData = br.ReadBytes((int)fs.Length);
                        br.Close();
                        fs.Close();

                        String cmdString = "INSERT INTO audio_db (PhonicsName, Audio) VALUES (@PhonicsName, @Audio)";
                        cmd = new MySqlCommand(cmdString, connection);

                        cmd.Parameters.AddWithValue("@PhonicsName", splitDir(filename));
                        cmd.Parameters.AddWithValue("@Audio", AudioData);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("All audio files have been uploaded !");
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
        }

        //Upload images to DB
        private void upldImgBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select folder which contains the image files:";
            DialogResult result = fbd.ShowDialog();

            if (fbd.SelectedPath.Length > 0)
            {
                String[] files = Directory.GetFiles(fbd.SelectedPath, "*.jpg");
                String connStr = "Server=localhost; Port=3306; Database=taleemdatabase; Uid=root; Pwd=admin;";
                MySqlConnection connection = new MySqlConnection(connStr);
                MySqlCommand cmd;
                FileStream fs;
                BinaryReader br;
                connection.Open();

                try
                {
                    for (int i = 0; i < files.Length; i++)
                    {
                        String filename = files[i];
                        byte[] ImageData;
                        fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
                        br = new BinaryReader(fs);
                        ImageData = br.ReadBytes((int)fs.Length);
                        br.Close();
                        fs.Close();

                        String cmdString = "INSERT INTO image_db (PhonicsName, Image) VALUES (@PhonicsName, @Image)";
                        cmd = new MySqlCommand(cmdString, connection);

                        cmd.Parameters.AddWithValue("@PhonicsName", splitDir(filename));
                        cmd.Parameters.AddWithValue("@Image", ImageData);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("All images have been uploaded !");
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
        }

        //Downloads audio files
        private void dwnldAudioBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select folder to save the audio files:";
            DialogResult result = fbd.ShowDialog();
            if (fbd.SelectedPath.Length > 0)
            {
                String dir = fbd.SelectedPath;
                String connStr = "Server=localhost; Port=3306; Database=taleemdatabase; Uid=root; Pwd=admin;";
                MySqlConnection connection = new MySqlConnection(connStr);
                MySqlDataReader reader;
                connection.Open();

                try
                {
                    String audioName;
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "SELECT PhonicsName, Audio FROM audio_db";
                    FileStream fs;
                    BinaryWriter bw;
                    int bufferSize = 1024;
                    byte[] AudioData = new byte[bufferSize];
                    long nBytesReturned, startIndex = 0;

                    reader = cmd.ExecuteReader(CommandBehavior.SequentialAccess);
                    if (!Directory.Exists(dir + "\\Audio"))
                    {
                        Directory.CreateDirectory(dir + "\\Audio");
                    }

                    while (reader.Read())
                    {
                        audioName = reader.GetString(0);
                        fs = new FileStream(dir + "\\Audio\\" + audioName.ToString() + ".wav", FileMode.OpenOrCreate, FileAccess.Write);
                        bw = new BinaryWriter(fs);
                        startIndex = 0;
                        nBytesReturned = reader.GetBytes(1, startIndex, AudioData, 0, bufferSize);
                        while (nBytesReturned == bufferSize)
                        {
                            bw.Write(AudioData);
                            bw.Flush();
                            startIndex += bufferSize;
                            nBytesReturned = reader.GetBytes(1, startIndex, AudioData, 0, bufferSize);
                        }
                        bw.Write(AudioData, 0, (int)nBytesReturned - 1);
                        bw.Close();
                        fs.Close();
                    }
                    reader.Close();
                    MessageBox.Show("Download complete!");
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
        }

        //Download images
        private void dwnldImgBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select folder to save the images files:";
            DialogResult result = fbd.ShowDialog();
            if (fbd.SelectedPath.Length > 0)
            {
                String dir = fbd.SelectedPath;
                String connStr = "Server=localhost; Port=3306; Database=taleemdatabase; Uid=root; Pwd=admin;";
                MySqlConnection connection = new MySqlConnection(connStr);
                MySqlDataReader reader;
                connection.Open();

                try
                {
                    String imgName;
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "SELECT PhonicsName, Image FROM image_db";
                    FileStream fs;
                    BinaryWriter bw;
                    int bufferSize = 1024;
                    byte[] ImageData = new byte[bufferSize];
                    long nBytesReturned, startIndex = 0;

                    reader = cmd.ExecuteReader(CommandBehavior.SequentialAccess);
                    if (!Directory.Exists(dir + "\\Images"))
                    {
                        Directory.CreateDirectory(dir + "\\Images");
                    }

                    while (reader.Read())
                    {
                        imgName = reader.GetString(0);
                        fs = new FileStream(dir + "\\Images\\" + imgName.ToString() + ".jpg", FileMode.OpenOrCreate, FileAccess.Write);
                        bw = new BinaryWriter(fs);
                        startIndex = 0;
                        nBytesReturned = reader.GetBytes(1, startIndex, ImageData, 0, bufferSize);
                        while (nBytesReturned == bufferSize)
                        {
                            bw.Write(ImageData);
                            bw.Flush();
                            startIndex += bufferSize;
                            nBytesReturned = reader.GetBytes(1, startIndex, ImageData, 0, bufferSize);
                        }
                        bw.Write(ImageData, 0, (int)nBytesReturned - 1);
                        bw.Close();
                        fs.Close();
                    }
                    reader.Close();
                    MessageBox.Show("Download complete!");
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
        }

        //Extracts the filename
        private String splitDir(String filename)
        {
            String[] splitArr = filename.Split('\\');
            String[] splitJPG = splitArr[splitArr.Length - 1].Split('.');
            return splitJPG[0];
        }

        //Exit application
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        //Import database
        private void importDB_Btn_Click(object sender, EventArgs e)
        {
            String database = null;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select directory to import SQL";
            ofd.Filter = "SQL Files (.sql)|*.sql";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                database = ofd.FileName;
            }

            String connStr = "Server=localhost; Port=3306; Uid=root; Pwd=admin;";
            MySqlConnection connection = new MySqlConnection(connStr);
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                MySqlBackup backup = new MySqlBackup(cmd);
                cmd.Connection = connection;
                connection.Open();
                backup.ImportInfo.TargetDatabase = splitDir(database);
                backup.ImportInfo.DatabaseDefaultCharSet = "utf8";
                backup.ImportFromFile(database);
                MessageBox.Show("Backup has been imported");
            }
            catch (Exception)
            {
                if (database == null)
                {
                    MessageBox.Show("Please select a database to export");
                }
            }
            finally
            {
                if (connection == null)
                {
                    //Do nothing !       
                }
                else if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                    listBox1.Items.Clear();
                    showDBList();
                }
            }
        }

        //Export database
        private void exportDB_Btn_Click(object sender, EventArgs e)
        {
            String database = null;
            String connStr = null;
            MySqlConnection connection = null;
            MySqlCommand cmd = null;
            try
            {
                database = listBox1.SelectedItem.ToString();
                connStr = "Server=localhost; Port=3306; Database=" + database + "; Uid=root; Pwd=admin;";
                connection = new MySqlConnection(connStr);
                cmd = new MySqlCommand();
                MySqlBackup backup = new MySqlBackup(cmd);
                cmd.Connection = connection;
                connection.Open();

                //Select the folder you want to save it in
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                DialogResult result = fbd.ShowDialog();
                String file = fbd.SelectedPath + "\\" + database + "_backup.sql";
                
                backup.ExportInfo.AddCreateDatabase = true;
                backup.ExportInfo.ExportTableStructure = true;
                backup.ExportInfo.ExportRows = true;
                backup.ExportToFile(file);
                MessageBox.Show("Backup has been exported");

            }
            catch (Exception)
            {
                if (database == null)
                {
                    MessageBox.Show("Please select a database to export");
                }
            }
            finally
            {
                if (connection == null)
                {
                    //Do nothing !       
                }
                else if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        //Displays the list of databases available in the server. 
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

                while (reader.Read())
                {
                    String row = "";
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        row += reader.GetValue(i).ToString();
                    }
                    listBox1.Items.Add(row);
                }
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

        //Upload Flash files
        private void upldSWFBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select folder which contains the flash files:";
            DialogResult result = fbd.ShowDialog();

            if (fbd.SelectedPath.Length > 0)
            {
                String[] files = Directory.GetFiles(fbd.SelectedPath, "*.swf");
                String connStr = "Server=localhost; Port=3306; Database=taleemdatabase; Uid=root; Pwd=admin;";
                MySqlConnection connection = new MySqlConnection(connStr);
                MySqlCommand cmd;
                FileStream fs;
                BinaryReader br;
                connection.Open();

                try
                {
                    for (int i = 0; i < files.Length; i++)
                    {
                        String filename = files[i];
                        byte[] FlashData;
                        fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
                        br = new BinaryReader(fs);
                        FlashData = br.ReadBytes((int)fs.Length);
                        br.Close();
                        fs.Close();

                        String cmdString = "INSERT INTO flash_db (Letters, Flash) VALUES (@Letters, @Flash)";
                        cmd = new MySqlCommand(cmdString, connection);

                        cmd.Parameters.AddWithValue("@Letters", splitDir(filename));
                        cmd.Parameters.AddWithValue("@Flash", FlashData);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("All flash files have been uploaded !");
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
        }

        //Download Flash files
        private void dwnldSWFBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select folder to save the flash files:";
            DialogResult result = fbd.ShowDialog();
            if (fbd.SelectedPath.Length > 0)
            {
                String dir = fbd.SelectedPath;
                String connStr = "Server=localhost; Port=3306; Database=taleemdatabase; Uid=root; Pwd=admin;";
                MySqlConnection connection = new MySqlConnection(connStr);
                MySqlDataReader reader;
                connection.Open();

                try
                {
                    String swfName;
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "SELECT Letters, Flash FROM flash_db";
                    FileStream fs;
                    BinaryWriter bw;
                    int bufferSize = 1024;
                    byte[] FlashData = new byte[bufferSize];
                    long nBytesReturned, startIndex = 0;

                    reader = cmd.ExecuteReader(CommandBehavior.SequentialAccess);
                    if (!Directory.Exists(dir + "\\Flash"))
                    {
                        Directory.CreateDirectory(dir + "\\Flash");
                    }

                    while (reader.Read())
                    {
                        swfName = reader.GetString(0);
                        fs = new FileStream(dir + "\\Flash\\" + swfName.ToString() + ".swf", FileMode.OpenOrCreate, FileAccess.Write);
                        bw = new BinaryWriter(fs);
                        startIndex = 0;
                        nBytesReturned = reader.GetBytes(1, startIndex, FlashData, 0, bufferSize);
                        while (nBytesReturned == bufferSize)
                        {
                            bw.Write(FlashData);
                            bw.Flush();
                            startIndex += bufferSize;
                            nBytesReturned = reader.GetBytes(1, startIndex, FlashData, 0, bufferSize);
                        }
                        bw.Write(FlashData, 0, (int)nBytesReturned - 1);
                        bw.Close();
                        fs.Close();
                    }
                    reader.Close();
                    MessageBox.Show("Download complete!");
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
        }

        //Add/Edit/Delete teacher profile
        private void editProfileBtn_Click(object sender, EventArgs e)
        {
            AEDTeacherProfile editProfile = new AEDTeacherProfile();
            editProfile.Show();
        }

        //General function to DROP schemas and columns and ADD columns to existing tables as well
        private void modifyDBBtn_Click(object sender, EventArgs e)
        {
            ModifyDB modify = new ModifyDB();
            modify.Show();
        }
    }
}
