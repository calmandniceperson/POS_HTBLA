using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CSFormsDB
{
    public delegate void BerechtigungsHandler();

    public partial class Form1 : Form
    {
        public event BerechtigungsHandler Erlaubt;
        public event BerechtigungsHandler Verboten;

        public virtual void OnErlaubt()
        {
            if (Erlaubt != null)
            {
                Erlaubt();
            }
        }

        public virtual void OnVerboten()
        {
            if (Verboten != null)
            {
                Verboten();
            }
        }

        public static void ErlaubtHandler()
        {
            MessageBox.Show("Zugriff erlaubt");
        }

        public static void VerbotenHandler()
        {
            MessageBox.Show("Zugriff verweigert.");
        }

        MySqlConnection conn;
        MySqlCommand cmd;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Erlaubt += ErlaubtHandler;
            Verboten += VerbotenHandler;
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Server=localhost;Database=posdb;Uid=pos;Pwd=pospw;";
                conn = new MySqlConnection(connectionString);

                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO user (ID, Name, Berechtigungen) VALUES(@ID, @Name, @Berechtigungen);";
                for (int i = 1; i <= 50; i++)
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@ID", ("u" + i));
                    cmd.Parameters.AddWithValue("@Name", ("User " + i));
                    cmd.Parameters.AddWithValue("@Berechtigungen", ("f" + i));
                    cmd.ExecuteNonQuery();
                }

                cmd.CommandText = "INSERT INTO funktion (ID, Name) VALUES(@ID, @Name);";
                for (int i = 1; i <= 50; i++)
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@ID", ("f" + i));
                    cmd.Parameters.AddWithValue("@Name", ("Funktion " + i));
                    //cmd.Parameters.AddWithValue("@ID1", ("u" + i));
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                //MessageBox.Show("Es ist ein Fehler aufgetreten. Vielleicht exisiert einer der erstellten Benutzer bereits.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * from user";
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0].DefaultView;

                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * from funktion";
                adap = new MySqlDataAdapter(cmd);
                ds = new DataSet();
                adap.Fill(ds);

                dataGridView2.DataSource = ds.Tables[0].DefaultView;
            }
        }

        private void checkFunctionsButton_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Server=localhost;Database=posdb;Uid=pos;Pwd=pospw;";
                conn = new MySqlConnection(connectionString);
                conn.Open();

                string uid = UserIDBox.Text;
                string funktionsid = functionsTextBox.Text;

                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * from user WHERE ID = '" + uid + "';";
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);

                //MessageBox.Show(ds.Tables[0].DefaultView[0][2].ToString());

                if (ds.Tables[0].DefaultView[0][2].ToString() == funktionsid)
                {
                    OnErlaubt();
                }
                else
                {
                    OnVerboten();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}