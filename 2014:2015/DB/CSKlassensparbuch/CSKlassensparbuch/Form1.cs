using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CSKlassensparbuch
{
    public delegate void KontoStandUnterschritten(object sender, KontoEventArgs args);

    public partial class Form1 : Form
    {
        public event KontoStandUnterschritten Unterschritten;

        public virtual void OnUnterschritten(object sender, KontoEventArgs args)
        {
            if (Unterschritten != null)
            {
                Unterschritten(sender, args);
            }
        }

        public void UnterschrittenHandler(object sender, KontoEventArgs args)
        {
            if (args.uid != "" && args.kontoID != 0)
            {
                MessageBox.Show("KONTOSTAND UNTERSCHRITTEN: " + args.uid + " " + args.kontoID.ToString());
            }
            else
            {
                MessageBox.Show("ES WURDE EIN KONTOSTAND UNTERSCHRITTEN");
            }
        }

        MySqlConnection conn;
        MySqlCommand cmd;
        bool isLoggedIn = false;
        string uID;
        int kontoID;

        public Form1()
        {
            InitializeComponent();
        }

        private void updateList()
        {
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();

                cmd.CommandText = "SELECT * FROM KONTO;";
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Unterschritten += UnterschrittenHandler;

            string connectionString = "Server=localhost;Database=klassensparbuchdb;Uid=pos;Pwd=pospw;";
            conn = new MySqlConnection(connectionString);

            updateList();
        }

        private void einzahlenButton_Click(object sender, EventArgs e)
        {
            if (isLoggedIn)
            {
                if (einzahlenTextBox.Text != "")
                {
                    try
                    {
                        conn.Open();
                        cmd = conn.CreateCommand();
                        if (uID != "a1")
                        {
                            cmd.CommandText = "SELECT Kontostand FROM Konto WHERE idKonto='" + kontoID + "';";
                            cmd.ExecuteNonQuery();
                            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                            DataSet ds = new DataSet();
                            adap.Fill(ds);

                            double ks = double.Parse(ds.Tables[0].DefaultView[0][0].ToString());

                            cmd.CommandText = "UPDATE Konto SET Kontostand='" + (ks + int.Parse(einzahlenTextBox.Text)) + "' WHERE idKonto='" + kontoID + "';";
                            cmd.ExecuteNonQuery();
                        }
                        else if(uID == "a1")
                        {
                            cmd.CommandText = "SELECT Kontostand FROM Konto;";
                            cmd.ExecuteNonQuery();
                            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                            DataSet ds = new DataSet();
                            adap.Fill(ds);

                            foreach (var el in ds.Tables[0].DefaultView)
                            {
                                double ks = double.Parse(ds.Tables[0].DefaultView[0][0].ToString());

                                cmd.CommandText = "UPDATE Konto SET Kontostand='" + (ks + int.Parse(einzahlenTextBox.Text)) + "';";
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Es ist ein Fehler aufgetreten.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    finally
                    {
                        conn.Close();
                        updateList();
                        einzahlenTextBox.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Sie muessen zuerst einen Wert eingeben!");
                }
            }
            else
            {
                MessageBox.Show("Sie muessen sich einloggen!");
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(usernameTextBox.Text != ""){
                try
                {
                    conn.Open();
                    cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT PW, idKonto FROM NUTZER WHERE ID='" + usernameTextBox.Text + "'";
                    MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adap.Fill(ds);

                    if (ds.Tables[0] != null)
                    {
                        if (ds.Tables[0].DefaultView[0][0].ToString() == passwordTextBox.Text)
                        {
                            MessageBox.Show("Sie wurden erfolgreich eingeloggt!");
                            isLoggedIn = true;
                            uID = usernameTextBox.Text;
                            usernameTextBox.Visible = false;
                            passwordTextBox.Visible = false;
                            loginButton.Visible = false;

                            kontoID = int.Parse(ds.Tables[0].DefaultView[0][1].ToString());
                        }
                        else
                        {
                            MessageBox.Show("Sie konnten nicht eingeloggt werden!");
                            isLoggedIn = false;
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                    isLoggedIn = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    isLoggedIn = false;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void kontenErstellenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();

                for (int i = 0; i <= 20; i++)
                {
                    cmd.CommandText = "INSERT INTO KONTO (idKonto, Kontostand) VALUES(@ID, @KS);";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@ID", i);
                    cmd.Parameters.AddWithValue("@KS", 20 /*ausgangskontostand*/);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "INSERT INTO NUTZER (NAME, ID, PW, idKonto) VALUES(@NAME, @ID, @PW, @IDK);";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@ID", ("u" + i));
                    cmd.Parameters.AddWithValue("@NAME", ("u " + i));
                    cmd.Parameters.AddWithValue("@PW", ("pw" + i));
                    cmd.Parameters.AddWithValue("@IDK", i);

                    cmd.ExecuteNonQuery();
                }

                // admin anlegen
                cmd.CommandText = "INSERT INTO NUTZER(NAME,ID,PW,idKonto) VALUES ('admin', 'a1', 'pwa', '0');";
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Es ist ein Fehler mit der Datenbank aufgetreten.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
                updateList();
            }
        }

        private void abhebenButton_Click(object sender, EventArgs e)
        {
            if (isLoggedIn)
            {
                if (abhebenTextBox.Text != "")
                {
                    try
                    {
                        conn.Open();
                        cmd = conn.CreateCommand();
                        if (uID != "a1")
                        {
                            cmd.CommandText = "SELECT Kontostand FROM Konto WHERE idKonto='" + kontoID + "';";
                            cmd.ExecuteNonQuery();
                            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                            DataSet ds = new DataSet();
                            adap.Fill(ds);
                           
                            double ks = double.Parse(ds.Tables[0].DefaultView[0][0].ToString());

                            if ((ks - int.Parse(abhebenTextBox.Text) > 0))
                            {
                                cmd.CommandText = "UPDATE Konto SET Kontostand='" + (ks - int.Parse(abhebenTextBox.Text)) + "' WHERE idKonto='" + kontoID + "';";
                            }
                            else
                            {
                                Unterschritten(this, new KontoEventArgs(uID, kontoID));
                            }
                            cmd.ExecuteNonQuery();
                        }
                        else if (uID == "a1")
                        {
                            cmd.CommandText = "SELECT Kontostand FROM Konto;";
                            cmd.ExecuteNonQuery();
                            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                            DataSet ds = new DataSet();
                            adap.Fill(ds);

                            foreach (var el in ds.Tables[0].DefaultView)
                            {
                                double ks = double.Parse(ds.Tables[0].DefaultView[0][0].ToString());

                                if((ks - int.Parse(einzahlenButton.Text) > 0)){
                                    cmd.CommandText = "UPDATE Konto SET Kontostand='" + (ks - int.Parse(einzahlenTextBox.Text)) + "';";
                                }else{
                                    Unterschritten(this, new KontoEventArgs(uID, kontoID));
                                }
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Es ist ein Fehler aufgetreten.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    finally
                    {
                        conn.Close();
                        updateList();
                        einzahlenTextBox.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Sie muessen zuerst einen Wert eingeben!");
                }
            }
            else
            {
                MessageBox.Show("Sie muessen sich einloggen!");
            }
        }
    }
}
