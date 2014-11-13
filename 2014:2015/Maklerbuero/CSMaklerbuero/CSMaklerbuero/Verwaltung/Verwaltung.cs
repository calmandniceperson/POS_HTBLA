/*
	MICHAEL KÖPPL 3AHIF
	2014/2015
	CSMaklerbuero

	Verwaltung (zur einfacheren Verwaltung der Häuser, Wohnungen, usw.)
*/

using System;
using System.Linq;
using System.Collections.Generic;

namespace CSMaklerbuero
{
    public class Verwaltung
    {
        List<Objekt> objListe = new List<Objekt>(); /*Liste der eingetragenen Objekte*/

        /*TEMPORARIES*/
        Wohnung w;
        Haus h;
        Grundstueck g;
        double tempd;
        Objekt tempObj;
        string temp; /*variable für temporaere Zwischenspeicherungen*/
        /*TEMPORARIES*/

        /*OBJEKT*/
        int objnr; /*Objektnummer*/
        string name; /*Name des Maklers*/
        bool tkm; /*Kaufen (true) oder Mieten (false)*/
        double k; /*Preis/Kosten*/
        double f; /*Flaeche*/
        /*OBJEKT*/

        /*WOHNUNG*/
        int anz_z;
        bool bd;
        /*WOHNUNG*/

        /*HAUS*/
        bool mehrfahau; /*mehrfamilienhaus true/false*/
        int anz_eta; /*Anzahl Etagen*/
        bool keller; /*Keller*/
        /*HAUS*/

        /*GRUNDSTUECK*/
        string widmung;
        double ew;
        /*GRUNDSTUECK*/

        #region create/delete/edit objects
        public void newObjekt()
        {
			try{
	            if (!objListe.Any() /*falls die Liste nichts enthaelt*/)
	            {
	                objnr = 1;
	            }
	            else
	            {
	                objnr = objListe.Last().getObjNr() + 1; /*erhoeht die Nummer fuer das neue Objekt um 1, sodass jedes neue Objekt die naechsthoehere Nummer bekommt*/
	            }

	            Console.Write("Wer ist der zuständige Makler? (Vorname) ");
	            string vname = Console.ReadLine();
	            Console.WriteLine("Nachname des zuständigen Maklers: ");
	            string nname = Console.ReadLine();

	            /*Vorname und Nachname zusammenfuegen*/
	            name = vname + " " + nname;

	            /*typus_kaufus_mietus*/
	            Console.WriteLine("Ist das Objekt zu Kaufen (1) oder zu Mieten (2)? ");
	            temp = Console.ReadLine();
	            if (procTKM(temp))
	            {
	                if (temp == "1")
	                {
	                    tkm = true;
	                }
	                else if (temp == "2")
	                {
	                    tkm = false;
	                }
	            }
	            else
	            {
	                procTKM(temp);
	            }

	            /*kosten*/
	            Console.WriteLine("Welchen Preis hat ihr Objekt? ");
	            k = double.Parse(Console.ReadLine());

	            /*flaeche*/
	            Console.Write("Welche Fläche hat Ihr Objekt? (in m^2)");
	            temp = Console.ReadLine();

	            /*suche nach buchstaben (falls user m^2 dazugeschrieben hat)*/
	            if (!temp.Any(x => char.IsLetter(x)))
	            {/*true = keine Buchstaben*/
	                f = double.Parse(temp);
	            }
	            else
	            { /*buchstaben im string*/
	                foreach (char bs in temp)
	                { /*überprüfe alle Zeichen, ob sie Buchstaben sind*/
	                    if (Char.IsLetter(bs))
	                    {
	                        f = double.Parse(temp.Remove(temp.IndexOf(bs)));
	                        break;
	                    }
	                    else
	                    {
	                        continue;
	                    }
	                }
	            }

	            Console.Write("Ist Ihr Objekt eine Wohnung (1), ein Haus (2) oder ein Grundstück (3)? ");
	            int objTyp = int.Parse(Console.ReadLine());

	            switch (objTyp)
	            {
	                case 1 /*Wohnung*/:
	                    Console.Write("Wieviele Zimmer hat Ihre Wohnung? ");
	                    anz_z = int.Parse(Console.ReadLine());

	                    Console.Write("Hat Ihre Wohnung eine Badewanne (1) oder eine Dusche? (2) ");
	                    temp = Console.ReadLine();
	                    if (temp == "1")
	                    {
	                        bd = true;
	                    }
	                    else if (temp == "2")
	                    {
	                        bd = false;
	                    }

	                    /*fuege neue, fertige Wohnung zur Liste der Objekte hinzu*/
	                    objListe.Add(new Wohnung(objnr, name, tkm, k, f, anz_z, bd));

	                    if (getObjektByObjNr(objnr) != null)
	                    {
	                        Console.Clear();
	                        printResult(getObjektByObjNr(objnr));
	                    }
	                    else
	                    {
	                        Console.WriteLine("null");
	                    }

	                    break;
	                case 2 /*Haus*/:
	                    Console.WriteLine("Ist das Haus ein Mehrfamilienhaus? (J/N)");
	                    if ((temp = Console.ReadLine().ToLower()) == "j")
	                    {
	                        mehrfahau = true;
	                    }
	                    else if (temp == "n")
	                    {
	                        mehrfahau = false;
	                    }

	                    Console.WriteLine("Wieviele Etagen hat das Haus? ");
	                    anz_eta = int.Parse(Console.ReadLine());

	                    Console.WriteLine("Hat das Haus einen Keller? (J/N) ");
	                    if ((temp = Console.ReadLine().ToLower()) == "j")
	                    {
	                        keller = true;
	                    }
	                    else if (temp == "n")
	                    {
	                        keller = false;
	                    }

	                    /*fuege neue, fertige Wohnung zur Liste der Objekte hinzu*/
	                    objListe.Add(new Haus(objnr, name, tkm, k, f, mehrfahau, anz_eta, keller));

	                    if (getObjektByObjNr(objnr) != null)
	                    {
	                        Console.Clear();
	                        printResult(getObjektByObjNr(objnr));
	                    }
	                    else
	                    {
	                        Console.WriteLine("null");
	                    }
	                    break;
	                case 3 /*Grundstueck*/:
	                    Console.WriteLine("Wofür soll das Grundstück verwendet werden? (Baugrund(1)/Geschäftsfläche(2)) ");
	                    widmung = Console.ReadLine();

	                    Console.WriteLine("Was ist der Einheitswert für das Grundstück? ");
	                    ew = double.Parse(Console.ReadLine());

	                    /*fuege neue, fertige Wohnung zur Liste der Objekte hinzu*/
	                    objListe.Add(new Grundstueck(objnr, name, tkm, k, f, widmung, ew));

	                    if (getObjektByObjNr(objnr) != null)
	                    {
	                        Console.Clear();
	                        printResult(getObjektByObjNr(objnr));
	                    }
	                    else
	                    {
	                        Console.WriteLine("null");
	                    }
	                    break;
	                default:
	                    Console.WriteLine("ERROR");
	                    break;
	            }
			}catch(Exception ex){
				throw;
			}
        }

        public void deleteObjekt(int objnr)
        {
			foreach (Objekt o in objListe)
			{
				if (o.getObjNr() == objnr)
				{
					try{
						objListe.Remove(o);
						break;
					}catch(Exception exe){
						Console.WriteLine(exe.ToString());
					}
				}
				else
				{
					continue;
				}
			}
        }

        public void editObjekt(int objnr, MenuClass mc)
        {
			try{
	            foreach (Objekt o in objListe)
	            {
	                if (o.getObjNr() == objnr)
	                {
	                    switch (mc.showEditMenu(o.GetType().Name))
	                    {
	                        case 1: /*Maklername editieren*/
	                            Console.WriteLine("Der derzeitige Name des Maklers ist: " + o.getMakler() + ".");
	                            Console.WriteLine("Geben Sie den Namen des neuen Maklers ein (leer lassen um abzubrechen):");
	                            temp = Console.ReadLine();
	                            if (temp != string.Empty)
	                            {
	                                if (temp.Contains(" "))
	                                {
	                                    o.setMakler(temp);
	                                    Console.Clear();
	                                    Console.WriteLine("Der neue Name des Maklers ist " + o.getMakler() + ".");
	                                }
	                            }
	                            else
	                            {
	                                break;
	                            }
	                            break;
	                        case 2: /*Mieten/Kaufen*/
	                            if (o.getTKM() == true)
	                            {
	                                Console.WriteLine("Das Objekt ist derzeit zum Kauf angeboten.");
	                                Console.Write("Wollen Sie das Objekt mietbar machen? (J/N) ");
	                                temp = Console.ReadLine();
	                                if (temp.ToLower().StartsWith("j"))
	                                {
	                                    o.setTKM(false);
	                                    Console.Clear();
	                                    Console.WriteLine("Das Objekt ist jetzt zu Mieten.");
	                                }
	                                else
	                                {
	                                    break;
	                                }
	                            }
	                            else
	                            {
	                                Console.WriteLine("Das Objekt ist derzeit zu Mieten.");
	                                Console.Write("Wollen Sie das Objekt käuflich machen? (J/N) ");
	                                temp = Console.ReadLine();
	                                if (temp.ToLower().StartsWith("j"))
	                                {
	                                    o.setTKM(true);
	                                    Console.Clear();
	                                    Console.WriteLine("Das Objekt ist jetzt zu Kaufen.");
	                                }
	                                else
	                                {
	                                    break;
	                                }
	                            }
	                            break;
	                        case 3: /*Preis*/
	                            Console.WriteLine("Der derzeitige Preis beträgt: " + o.getKosten().ToString() + "€.");
	                            Console.Write("Geben Sie den neuen Preis ein (leer lassen um abzubrechen): ");
	                            temp = Console.ReadLine();
	                            if (temp != string.Empty)
	                            {
	                                o.setKosten(double.Parse(temp));
	                                Console.Clear();
	                                Console.WriteLine("Das Objekt kostet nun " + o.getKosten().ToString() + "€.");
	                            }
	                            else
	                            {
	                                break;
	                            }
	                            break;
	                        case 4: /*Flaeche*/
	                            Console.WriteLine("Die derzeitige Fläche beträgt: " + o.getFlaeche().ToString() + "m^2");
	                            Console.Write("Geben Sie die neue Fläche an (leer lassen um abzubrechen): ");
	                            temp = Console.ReadLine();
	                            if (temp != string.Empty)
	                            {
	                                o.setFlaeche(double.Parse(temp));
	                                Console.Clear();
	                                Console.WriteLine("Das Objekt hat jetzt eine Fläche von " + o.getFlaeche().ToString() + "m^2.");
	                            }
	                            else
	                            {
	                                break;
	                            }
	                            break;
	                        case 5: /*(Wohnung) Anzahl Zimmer aendern*/
	                            w = (Wohnung)o;
	                            Console.WriteLine("Die Wohnung hat derzeit: " + w.getAnzZimmer().ToString() + ".");
	                            Console.Write("Geben Sie die neue Anzahl an Zimmern ein (leer lassen um abzubrechen): ");
	                            temp = Console.ReadLine();
	                            if (temp != string.Empty)
	                            {
	                                w.setAnzZimmer(int.Parse(temp));
	                                Console.Clear();
	                                Console.WriteLine("Die Wohnung hat jetzt " + w.getAnzZimmer().ToString() + " Zimmer.");
	                            }
	                            else
	                            {
	                                break;
	                            }
	                            break;
	                        case 6: /*(Wohnung) Badewanne/Dusche*/
	                            w = (Wohnung)o;
	                            if (w.getBD() == true)
	                            {
	                                Console.WriteLine("Die Wohnung hat eine Badewanne. Wollen Sie eine Dusche eintragen? (J/N) ");
	                                temp = Console.ReadLine();
	                                if (temp.ToLower().StartsWith("j"))
	                                {
	                                    w.setBD(false);
	                                    Console.Clear();
	                                    Console.WriteLine("Die Wohnung hat jetzt eine Dusche.");
	                                }
	                                else
	                                {
	                                    break;
	                                }
	                            }
	                            else
	                            {
	                                Console.WriteLine("Die Wohnung hat eine Dusche. Wollen Sie eine Badewanne eintragen? (J/N) ");
	                                temp = Console.ReadLine();
	                                if (temp.ToLower().StartsWith("j"))
	                                {
	                                    w.setBD(true);
	                                    Console.Clear();
	                                    Console.WriteLine("Die Wohnung hat jetzt eine Badewanne.");
	                                }
	                                else
	                                {
	                                    break;
	                                }
	                            }
	                            break;
	                        case 7: /*(Haus) Mehrfamilienhaus*/
	                            h = (Haus)o;
	                            if (h.getMehrFHaus() == true)
	                            {
	                                Console.WriteLine("Das Haus ist ein Mehrfamilienhaus.");
	                                Console.Write("Wollen Sie das ändern? (J/N) ");
	                                temp = Console.ReadLine();
	                                if (temp.ToLower().StartsWith("j"))
	                                {
	                                    h.setMehrFHaus(false);
	                                    Console.Clear();
	                                    Console.WriteLine("Das Haus ist jetzt kein Mehrfamilienhaus mehr.");
	                                }
	                                else
	                                {
	                                    break;
	                                }
	                            }
	                            else
	                            {
	                                Console.WriteLine("Das Haus ist kein Mehrfamilienhaus.");
	                                Console.Write("Wollen Sie das ändern? (J/N) ");
	                                temp = Console.ReadLine();
	                                if (temp.ToLower().StartsWith("j"))
	                                {
	                                    h.setMehrFHaus(true);
	                                    Console.Clear();
	                                    Console.WriteLine("Das Haus ist jetzt ein Mehrfamilienhaus.");
	                                }
	                                else
	                                {
	                                    break;
	                                }
	                            }
	                            break;
	                        case 8: /*(Haus) Anzahl Etagen*/
	                            h = (Haus)o;
	                            Console.WriteLine("Das Haus hat: " + h.getAnzEtagen().ToString() + " Etagen.");
	                            Console.Write("Geben Sie die neue Anzahl der Etagen an (leer lassen um abzubrechen): ");
	                            temp = Console.ReadLine();
	                            if (temp != string.Empty)
	                            {
	                                h.setAnzEtagen(int.Parse(temp));
	                                Console.Clear();
	                                Console.WriteLine("Das Haus hat jetzt " + h.getAnzEtagen().ToString() + " Etagen.");
	                            }
	                            else
	                            {
	                                break;
	                            }
	                            break;
	                        case 9: /*(Haus) Keller*/
	                            h = (Haus)o;
	                            if (h.getKeller() == true)
	                            {
	                                Console.WriteLine("Das Haus hat einen Keller.");
	                                Console.Write("Wollen Sie das ändern? (J/N) ");
	                                temp = Console.ReadLine();
	                                if (temp.ToLower().StartsWith("j"))
	                                {
	                                    h.setKeller(false);
	                                    Console.Clear();
	                                    Console.WriteLine("Das Haus hat jetzt keinen Keller mehr. ");
	                                }
	                                else
	                                {
	                                    break;
	                                }
	                            }
	                            else
	                            {
	                                Console.WriteLine("Das Haus hat keinen Keller.");
	                                Console.Write("Wollen Sie das ändern? (J/N) ");
	                                temp = Console.ReadLine();
	                                if (temp.ToLower().StartsWith("j"))
	                                {
	                                    h.setKeller(true);
	                                    Console.Clear();
	                                    Console.WriteLine("Das Haus hat jetzt einen Keller.");
	                                }
	                                else
	                                {
	                                    break;
	                                }
	                            }
	                            break;
	                        case 10: /*(Grundstueck) Widmung*/
	                            g = (Grundstueck)o;
	                            Console.WriteLine("Die derzeitige Widmung des Grundstücks ist: " + g.getWidmung() + ".");
	                            Console.Write("Wollen Sie einen Baugrund (1) \n\r oder eine Geschaeftsflaeche (2) daraus machen? (leer lassen um abzubrechen) ");
	                            temp = Console.ReadLine();
	                            if (temp != string.Empty)
	                            {
	                                switch (temp)
	                                {
	                                    case "1":
	                                        g.setWidmung(1);
	                                        Console.Clear();
	                                        Console.WriteLine("Das Grundstück ist jetzt ein Baugrund.");
	                                        break;
	                                    case "2":
	                                        Console.Clear();
	                                        Console.WriteLine("Das Grundstück ist jetzt eine Geschäftsfläche.");
	                                        g.setWidmung(2);
	                                        break;
	                                }
	                            }
	                            else
	                            {
	                                break;
	                            }
	                            break;
	                        case 11: /*(Grundstueck) Einheitswert*/
	                            g = (Grundstueck)o;
	                            Console.WriteLine("Der Einheitswert beträgt derzeit: " + g.getEW() + ".");
	                            Console.Write("Geben Sie den neuen Einheitswert an (leer lassen um abzubrechen): ");
	                            temp = Console.ReadLine();
	                            if (temp != string.Empty)
	                            {
	                                g.setEW(double.Parse(temp));
	                                Console.Clear();
	                                Console.WriteLine("Der neue Einheitswert beträgt " + g.getEW().ToString() + ".");
	                            }
	                            else
	                            {
	                                break;
	                            }
	                            break;
	                    }
	                }
	            }
			}catch(Exception ex){
				throw;
			}
        }
        #endregion
        #region output
		public void printProvision(int objnr){
			Console.WriteLine(getObjektByObjNr (objnr).getProvision ().ToString());
		}

        public void printResult(Objekt o)
        {
            Console.WriteLine("Objektnummer: " + o.getObjNr().ToString());
            Console.WriteLine("Name d. Maklers: " + o.getMakler());
            if (o.getTKM() == true)
            {
                Console.WriteLine("Das Objekt ist zu Kaufen.");
            }
            else if (o.getTKM() == false)
            {
                Console.WriteLine("Das Objekt ist zu Mieten");
            }
            Console.WriteLine("Preis: " + o.getKosten().ToString() + "€");
            Console.WriteLine("Fläche: " + o.getFlaeche().ToString() + "m^2");

            switch (o.GetType().Name)
            {
                case "Wohnung":
                    w = (Wohnung)o;
                    Console.WriteLine("Die Wohnung hat: " + w.getAnzZimmer().ToString() + " Zimmer.");
                    if (w.getBD() == true)
                    {
                        Console.WriteLine("Die Wohnung hat eine Badewanne.");
                    }
                    else if (w.getBD() == false)
                    {
                        Console.WriteLine("Die Wohnung hat eine Dusche.");
                    }
                    break;
                case "Haus":
                    h = (Haus)o;
                    if (h.getMehrFHaus() == true)
                    {
                        Console.WriteLine("Das Haus ist ein Mehrfamilienhaus.");
                    }
                    else if (h.getMehrFHaus() == false)
                    {
                        Console.WriteLine("Das Haus ist kein Mehrfamilienhaus.");
                    }

                    Console.WriteLine("Das Haus hat " + h.getAnzEtagen() + " Etagen.");

                    if (h.getKeller() == true)
                    {
                        Console.WriteLine("Das Haus hat einen Keller.");
                    }
                    else if (h.getKeller() == false)
                    {
                        Console.WriteLine("Das Haus hat keinen Keller.");
                    }
                    break;
                case "Grundstueck":
                    Grundstueck g = (Grundstueck)o;
                    Console.WriteLine("Das Grundstück ist ein(e) " + g.getWidmung() + ".");
                    Console.WriteLine("Der Einheitswert ist: " + g.getEW() + ".");
                    break;
                default:
                    Console.WriteLine("Kein Type");
                    break;
            }
        }

        public void printAll()
        {
            Console.Clear();
            foreach (Objekt o in objListe)
            {
                printResult(o);
            }
        }

        public void printSelection(int what, Nullable<int> optnr = null)
        {
            switch (what)
            {
                case 1: /*bestimmte nummer*/
                    if (optnr != null)
                    {
                        foreach (Objekt o in objListe)
                        {
                            if (o.getObjNr() == optnr)
                            {
                                printResult(o);
                                break;
                            }
                        }
                    }
                    break;
                case 2: /*alle, die zu kaufen sind*/
                    foreach (Objekt o in objListe)
                    {
                        if (o.getTKM() == true)
                        {
                            printResult(o);
                        }
                    }
                    break;
                case 3: /*alle, die zu mieten sind*/
                    foreach (Objekt o in objListe)
                    {
                        if (o.getTKM() == false)
                        {
                            printResult(o);
                        }
                    }
                    break;
                case 4: /*alle, die Häuser sind*/
                    foreach (Objekt o in objListe)
                    {
                        if (o.GetType().Name == "Haus")
                        {
                            printResult(o);
                        }
                    }
                    break;
                case 5: /*alle, die Wohnungen sind*/
                    foreach (Objekt o in objListe)
                    {
                        if (o.GetType().Name == "Wohnung")
                        {
                            printResult(o);
                        }
                    }
                    break;
                case 6: /*alle, die Grundstuecke sind*/
                    foreach (Objekt o in objListe)
                    {
                        if (o.GetType().Name == "Grundstueck")
                        {
                            printResult(o);
                        }
                    }
                    break;
            }
        }

        public void printCheapest(int type)
        {
            /*
            Haus = 1
            Wohnung = 2
            Grundstueck = 3
            All = 4*/
            

            switch (type)
            {
                case 1:
                    tempd = 0;
                    foreach (Objekt o in objListe)
                    {
                        if (o.GetType().Name == "Haus")
                        {
                            if (tempd == 0 || o.getKosten() < tempd)
                            {
                                tempObj = o;
                            }
                        }
                    }
                    printResult(tempObj);
                    break;
                case 2:
                    tempd = 0;
                    foreach (Objekt o in objListe)
                    {
                        if (o.GetType().Name == "Wohnung")
                        {
                            if (tempd == 0 || o.getKosten() < tempd)
                            {
                                tempObj = o;
                            }
                        }
                    }
                    printResult(tempObj);
                    break;
                case 3:
                    tempd = 0;
                    foreach (Objekt o in objListe)
                    {
                        if (o.GetType().Name == "Grundstueck")
                        {
                            if (tempd == 0 || o.getKosten() < tempd)
                            {
                                tempObj = o;
                            }
                        }
                    }
                    printResult(tempObj);
                    break;
                case 4:
                    tempd = 0;
                    foreach (Objekt o in objListe)
                    {
                        if (tempd == 0 || o.getKosten() < tempd)
                        {
                            tempObj = o;
                        }
                    }
                    printResult(tempObj);
                    break;
            }
        }

        public void printMostExpensive(int type)
        {
            /*
            Haus = 1
            Wohnung = 2
            Grundstueck = 3
            All = 4*/
            

            switch (type)
            {
                case 1:
                    tempd = 0;
                    foreach (Objekt o in objListe)
                    {
                        if (o.GetType().Name == "Haus")
                        {
                            if (tempd == 0 || o.getKosten() > tempd)
                            {
                                tempObj = o;
                            }
                        }
                    }
                    printResult(tempObj);
                    break;
                case 2:
                    tempd = 0;
                    foreach (Objekt o in objListe)
                    {
                        if (o.GetType().Name == "Wohnung")
                        {
                            if (tempd == 0 || o.getKosten() > tempd)
                            {
                                tempObj = o;
                            }
                        }
                    }
                    printResult(tempObj);
                    break;
                case 3:
                    tempd = 0;
                    foreach (Objekt o in objListe)
                    {
                        if (o.GetType().Name == "Grundstueck")
                        {
                            if (tempd == 0 || o.getKosten() > tempd)
                            {
                                tempObj = o;
                            }
                        }
                    }
                    printResult(tempObj);
                    break;
                case 4:
                    tempd = 0;
                    foreach (Objekt o in objListe)
                    {
                        if (tempd == 0 || o.getKosten() > tempd)
                        {
                            tempObj = o;
                        }
                    }
                    printResult(tempObj);
                    break;
            }
        }

        public void printAverage(int type)
        {
            int i = 0;
            switch (type)
            {
                case 1:
                    tempd = 0;
                    foreach (Objekt o in objListe)
                    {
                        if (o.GetType().Name == "Haus")
                        {
                            tempd = tempd + Convert.ToDouble(o.getKosten());
                            i++;
                        }
                    }
                    Console.WriteLine("Der durchschnittliche Preis bei Häusern liegt bei: " + (tempd / Convert.ToDouble(i)).ToString() + ".");
                    break;
                case 2:
                    tempd = 0;
                    foreach (Objekt o in objListe)
                    {
                        if (o.GetType().Name == "Wohnung")
                        {
                            tempd = tempd + Convert.ToDouble(o.getKosten());
                            i++;
                        }
                    }
                    Console.WriteLine("Der durchschnittliche Preis bei Wohnungen liegt bei: " + (tempd / Convert.ToDouble(i)).ToString() + ".");
                    break;
                case 3:
                    tempd = 0;
                    foreach (Objekt o in objListe)
                    {
                        if (o.GetType().Name == "Grundstueck")
                        {
                            tempd = tempd + Convert.ToDouble(o.getKosten());
                            i++;
                        }
                    }
                    Console.WriteLine("Der durchschnittliche Preis bei Grundstuecken liegt bei: " + (tempd / Convert.ToDouble(i)).ToString() + ".");
                    break;
                case 4:
                    tempd = 0;
                    foreach (Objekt o in objListe)
                    {
                        tempd = tempd + Convert.ToDouble(o.getKosten());
                        i++;
                    }
                    Console.WriteLine("Der durchschnittliche Preis liegt bei: " + (tempd / Convert.ToDouble(i)).ToString() + ".");
                    break;
            }
        }
        #endregion
        #region get
        public Objekt getObjektByObjNr(int v)
        {
            foreach (Objekt obj in objListe)
            {
                if (obj.getObjNr() == v)
                {
                    return obj;
                }
            }
            /*if (found != null) {
                return found;
            } else {
                return null;
            }*/
            return null;
        }
        #endregion
        #region processing
        public bool procTKM(string t)
        {
            if (t == "1")
            {
                return true;
            }
            else if (t == "2")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
