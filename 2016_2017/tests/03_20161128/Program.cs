using System;
using System.IO;
using System.Xml;

namespace ConsoleApplication
{
    public class Program
    {
        const string SOURCE_FILE = "Datei1.xml";
        const string DEST_FILE = "Datei2.xml";
        public static void Main(string[] args)
        {
            if (!File.Exists(SOURCE_FILE))
            {
                Console.WriteLine("No source file");
                return;
            }

            XmlReader reader = XmlReader.Create(SOURCE_FILE);
            while (reader.Read())
            {
                int min = 0, max = 0, anz = 1;
                if (reader.Name == "Zufall")
                {
                    while (reader.Read())
                    {
                        switch (reader.Name)
                        {
                            case "Min":
                                min = reader.ReadElementContentAsInt();
                            break;
                            case "Max":
                                max = reader.ReadElementContentAsInt();
                            break;
                            case "Anzahl":
                                anz = reader.ReadElementContentAsInt();
                            break;
                        }
                    }
                        Management.settingsList.Add(new WuerfelSettings(min, max, anz));
                }
            }

            // Print out
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            using (XmlWriter writer = XmlWriter.Create(new FileStream(DEST_FILE, FileMode.OpenOrCreate), settings))
            {
                writer.WriteStartElement("Datei2");
                Console.WriteLine(Management.settingsList.Count);
                Management.settingsList.ForEach(s => {
                   s.Werte.ForEach(w => {
                       writer.WriteElementString("Ergebnis", w.ToString());
                   });
                   writer.WriteElementString("Durchschnitt", s.Durchschnitt.ToString());
                });
                writer.WriteFullEndElement();
            }
        }
    }
}
