/*
	MICHAEL KÖPPL 3AHIF
	2014/2015
	CSMaklerbuero

	MenuClass (alle Menues hier)
*/

using System;

namespace CSMaklerbuero
{
    public class MenuClass
    {

        /*
         * BASISMENUE
         * (Einstiegsmenue)
         */
        public int showMenu()
        {
            Console.Clear();
            Console.WriteLine("\tWas wollen Sie tun?\t");
            Console.WriteLine("1 ... Neues Objekt anlegen");
            Console.WriteLine("2 ... Bestimmtes Objekt löschen");
            Console.WriteLine("3 ... Bestimmtes Objekt bearbeiten");
            Console.WriteLine("4 ... Liste ausgeben");
            Console.WriteLine("5 ... Nach bestimmten Kriterien ausgeben");
            Console.WriteLine("6 ... Billigstes/Teuerstes/Durchschnitt");
			Console.WriteLine ("7 ... Provision ausgeben");


            return int.Parse(Console.ReadLine());
        }

        /*
         * Menue fuer die eigenschaftsorientierte Ausgabe
         * z.B.: zur Ausgabe aller Objekte, die zu Mieten sind
         */
        public int showSpecificSelectionMenu()
        {
            Console.Clear();
            Console.WriteLine("\tWas wollen Sie ausgeben?\t");
            Console.WriteLine("1 ... Geben Sie ein Objekt mit einer bestimmten Nummer aus");
            Console.WriteLine("2 ... Alle Objekte ausgeben, die zu Kaufen sind");
            Console.WriteLine("3 ... Alle Objekte ausgeben, die zu Mieten sind");
            Console.WriteLine("4 ... Alle Objekte ausgeben, die Häuser sind");
            Console.WriteLine("5 ... Alle Objekte ausgeben, die Wohnungen sind");
            Console.WriteLine("6 ... Alle Objekte ausgeben, die reine Grundstücke sind");

            return int.Parse(Console.ReadLine());
        }

        /*
         * Menue für das Editieren von Objekten
         */
        public int showEditMenu(string type)
        {
            Console.WriteLine("\tWas wollen Sie editieren?\t");
            Console.WriteLine("1 ... Maklername");
            Console.WriteLine("2 ... Kaufen/Mieten");
            Console.WriteLine("3 ... Preis");
            Console.WriteLine("4 ... Fläche");
            switch (type /*Haus, Wohnung oder Grundstueck*/)
            {
                //jeder Typ hat nochmal ein eigenes Untermenue (sieht "hübscher" aus)
                case "Wohnung":
                    Console.WriteLine("5 ... Anzahl Zimmer");
                    Console.WriteLine("6 ... Badewanne/Dusche");
                    break;
                case "Haus":
                    Console.WriteLine("5 ... Mehrfamilienhaus (Ja/Nein)");
                    Console.WriteLine("6 ... Anzahl Etagen");
                    Console.WriteLine("7 ... Keller (Ja/Nein)");
                    break;
                case "Grundstueck":
                    Console.WriteLine("5 ... Widmung");
                    Console.WriteLine("6 ... Einheitswert");
                    break;
            }

            int temp = int.Parse(Console.ReadLine());

            /*
             * falls die Auswahl des Nutzers außerhalb des Bereichs liegt, der fuer alle Objekte gilt
             * z.B.: wohnungsspezifische Optionen
             */
            if (temp == 5 || temp == 6 || temp == 7)
            {
                switch (type)
                {
                    /*
                     * Wohnung faellt weg, weil es der Standard fuer 5 und 6 ist, weil es oben als 1. gelistet ist
                     * Je nach Typ wird die Auswahl im nachhinein so manipuliert, dass sie für den gewählten Typ gilt
                     */
                    case "Haus":
                        if (temp == 5)
                        {
                            temp = 7;
                        }
                        else if (temp == 6)
                        {
                            temp = 8;
                        }
                        else if (temp == 7)
                        {
                            temp = 9;
                        }
                        break;
                    case "Grundstueck":
                        if (temp == 5)
                        {
                            temp = 10;
                        }
                        else if (temp == 6)
                        {
                            temp = 11;
                        }
                        break;
                }
            }

            /* TEMP OPTIONEN
             * 
            Damit das Menue schoener bleibt, wird temp im nachhinein veraendert.
            temp = 1 -> Maklername aendern
            temp = 2 -> Kaufen/Mieten aendern
            temp = 3 -> Preis aendern
            temp = 4 -> Flaeche aendern
            temp = 5 -> (Wohnung) Anzahl Zimmer aendern
            temp = 6 -> (Wohnung) Badewanne/Dusche aendern
            temp = 7 -> (Haus) Mehfamilienhaus (Ja/Nein) aendern
            temp = 8 -> (Haus) Anzahl Etagen aendern
            temp = 9 -> (Haus) Keller (Ja/Nein) aendern
            temp = 10 -> (Grundstueck) Widmung aendern
            temp = 11 -> (Grundstueck) Einheitswert aendern
            *
            */

            return temp;
        }

        /*
         * Menue fuer die Ausgabe des billigsten, teuersten Objekts oder 
         * des Durchschnitts aller Objekte von einem bestimmten Typ oder 
         * ALLEN Objekten, die angelegt wurden
         */
        public void showBTDMenu(Verwaltung v)
        {
            Console.WriteLine("\tBILLIGSTES/TEUERSTES/DURCHSCHNITT\t");

            /*Typ (Haus, Wohnung, Grundstueck) wird bei Zeile 155 gewaehlt*/
            Console.WriteLine("1 ... Billigstes ... ausgeben"); 
            Console.WriteLine("2 ... Teuerstes ... ausgeben");
            Console.WriteLine("3 ... Durchschnitt ausgeben");

            switch (int.Parse(Console.ReadLine()))
            {
                case 1: /*Billigstes...*/
                    Console.WriteLine("1 ... Billigstes Haus ausgeben");
                    Console.WriteLine("2 ... Billigste Wohnung ausgeben");
                    Console.WriteLine("3 ... Billigstes Grundstueck ausgeben");
                    Console.WriteLine("4 ... Billigstes Alles ausgeben");

                    switch (int.Parse(Console.ReadLine()))
                    {
                        case 1:
                            v.printCheapest(1);
                            break;
                        case 2:
                            v.printCheapest(2);
                            break;
                        case 3:
                            v.printCheapest(3);
                            break;
                        case 4:
                            v.printCheapest(4);
                            break;
                    }
                    break;
                case 2: /*Teuerstes...*/
                    Console.WriteLine("1 ... Teuerstes Haus ausgeben");
                    Console.WriteLine("2 ... Teuerste Wohnung ausgeben");
                    Console.WriteLine("3 ... Teuerstes Grundstueck ausgeben");
                    Console.WriteLine("4 ... Teuerstes Alles ausgeben");

                    switch (int.Parse(Console.ReadLine()))
                    {
                        case 1:
                            v.printMostExpensive(1);
                            break;
                        case 2:
                            v.printMostExpensive(2);
                            break;
                        case 3:
                            v.printMostExpensive(3);
                            break;
                        case 4:
                            v.printMostExpensive(4);
                            break;
                    }
                    break;
                case 3: /*Durchschnitt*/
                    Console.WriteLine("1 ... Durchschnittspreis Haus");
                    Console.WriteLine("2 ... Durchschnittspreis Wohnung");
                    Console.WriteLine("3 ... Durchschnittspreis Alle");

                    switch (int.Parse(Console.ReadLine()))
                    {
                        case 1:
                            v.printAverage(1);
                            break;
                        case 2:
                            v.printAverage(2);
                            break;
                        case 3:
                            v.printAverage(3);
                            break;
                        case 4:
                            v.printAverage(4);
                            break;
                    }
                    break;
            }
        }
    }
}

