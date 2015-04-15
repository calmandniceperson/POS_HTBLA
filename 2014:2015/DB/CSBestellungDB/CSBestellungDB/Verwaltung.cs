using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace CSBestellungDB
{
    public delegate void UnterMLagerStand(object sender, UnterschrittenEventArgs e);
    public delegate void ProduktNichtVorhanden(object sender, NichtVorhandenEventArgs e);

    class Verwaltung
    {
        public event UnterMLagerStand umls;
        public event ProduktNichtVorhanden pnv;

        public void OnUnterSchritten(int pid)
        {
            if (umls != null)
            {
                umls(this, new UnterschrittenEventArgs(pid));
            }
        }

        public void OnProduktNichtVorhanden(int pid)
        {
            if (pnv != null)
            {
                pnv(this, new NichtVorhandenEventArgs(pid));
            }
        }

        public void UnterschrittenHandler(object sender, UnterschrittenEventArgs e)
        {
            Console.WriteLine("\nDas Produkt mit ProduktID {0} hat den Mindestlagerstand unterschritten.", e.produkt_id);
        }

        public void NichtVorhandenHandler(object sender, NichtVorhandenEventArgs e)
        {
            Console.WriteLine("WARNUNG: " + e.produkt_id + " im Lager existiert nicht in der Produktliste!");
            Console.Write("Soll der Eintrag entfernt werden? (j/n) ");
            string ant = Console.ReadLine();
            if (ant.ToLower().StartsWith("j"))
            {
                LagerDict.Remove(e.produkt_id);

                cmd = new OleDbCommand("DELETE FROM LAGER WHERE ID=?", conn);
                param = cmd.Parameters.AddWithValue("ID", e.produkt_id);


                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (OleDbException ex)
                {
                    Console.WriteLine(ex.ToString() + "\n" + ex.Source);
                }
            }
        }

        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataReader reader;
        OleDbParameter param;
        Dictionary<int, Stamm> StammDict;
        Dictionary<int, Lager> LagerDict;

        public Verwaltung()
        {
            StammDict = new Dictionary<int, Stamm>();
            LagerDict = new Dictionary<int, Lager>();
            conn = new OleDbConnection(Properties.Settings.Default.BestellConnectionString);
            conn.Open();

            umls += UnterschrittenHandler;
            pnv += NichtVorhandenHandler;
        }

        public void Lesen()
        { 
           cmd = new OleDbCommand("SELECT * FROM LAGER", conn);
           reader = cmd.ExecuteReader();
           try
           {
               while (reader.Read())
               {
                   LagerDict.Add(
                       int.Parse(reader["ID" /*name des felds, das man haben will*/].ToString()),
                       new Lager(
                           int.Parse(reader["ID"].ToString()),
                           int.Parse(reader["ProdID"].ToString()),
                           double.Parse(reader["Lagerstand"].ToString())
                       )
                   );
               }
           }
           catch (OleDbException ex)
           {
               Console.WriteLine(ex.ToString() + "\n" + ex.Source);
           }
           catch (Exception ex)
           {
               Console.WriteLine(ex.ToString() + "\n" + ex.Source);
           }
            finally
            {
                reader.Close();
            }

            cmd = new OleDbCommand("SELECT * FROM STAMM", conn);
            reader = cmd.ExecuteReader();

            try
            {
                while (reader.Read())
                {
                    StammDict.Add(
                        int.Parse(reader["ID" /*name des felds, das man haben will*/].ToString()),
                        new Stamm(
                            int.Parse(reader["ID"].ToString()),
                            reader["Produkt"].ToString(),
                            double.Parse(reader["Mindestlager"].ToString()),
                            double.Parse(reader["Preis"].ToString())
                        )
                    );
                }
            }
            catch (OleDbException ex)
            {
                Console.WriteLine(ex.ToString() + "\n" + ex.Source);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString() + "\n" + ex.Source);
            }
            finally
            {
                reader.Close();
            }
        }

        public void LagerWert()
        {
            // ausgeben aller Lager anhand des Dictionarys Stamm (ist ein Produkt)
            // mit aktuellem Lagerstand  (aus Dict. Lager)
            //
            // stamm: welche produkte gibt es (mit id), wieviel kostet es und wieviel sollte da sein
            // lager: produkt (id), wieviel ist da?
            // 
            // Ausgabe: alle felder + lagerwert (preis * lagerstand)

            foreach(KeyValuePair<int, Lager> kvp in LagerDict){
                if (!StammDict.ContainsKey(kvp.Key))
                {
                    // WARNUNG!
                    OnProduktNichtVorhanden(kvp.Key);
                }
            }

            foreach (KeyValuePair<int, Stamm> kvpS in StammDict)
            {
                foreach (KeyValuePair<int, Lager> kvpL in LagerDict)
                {
                    if (kvpS.Key == kvpL.Key)
                    {
                        if (kvpL.Value.Lagerstand < kvpS.Value.MinLagerstand)
                        {
                            OnUnterSchritten(kvpL.Key);
                        }
                        Console.WriteLine("ProduktID:\tName:\t\tMindestlagerstand:\tLagerstand\n{0}\t\t{1}\t\t{2}\t\t\t{3}\n", kvpS.Key, kvpS.Value.Bezeichnung, kvpS.Value.MinLagerstand, kvpL.Value.Lagerstand);
                    }
                }
            }
        }
    }
}
