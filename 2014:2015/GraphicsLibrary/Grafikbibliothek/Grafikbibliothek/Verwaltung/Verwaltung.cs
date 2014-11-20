using System;
using System.Collections.Generic;
using System.Linq;

namespace Grafikbibliothek
{
	public class Verwaltung
	{

		bool repeat = false;
		int objnr; //nummer fuer die liste
		CGraphObj tempobj; //temporaeres objekt
		double x, y, xd, yd, radius, seitenlaenge; //zusatzinfos
		List<CGraphObj> graphList = new List<CGraphObj>();

		#region newobject
		public void newObjekt(int type, Nullable<int> preid = null /*pre-ID --> zum ueberschreiben eines Objekts*/){

			if (preid == null) {
				if (!graphList.Any () /*falls die Liste nichts enthaelt*/) {
					objnr = 1;
				} else {
					objnr = graphList.Last ().getId () + 1; /*erhoeht die Nummer fuer das neue Objekt um 1, sodass jedes neue Objekt die naechsthoehere Nummer bekommt*/
				}
			} else {
				objnr = Convert.ToInt32(preid);
			}

			try{
				Console.Write ("Geben Sie die x-Koordinate des Mittelpunkts ein: ");
				x = double.Parse (Console.ReadLine ());
				Console.Write ("Geben Sie die y-Koordinate des Mittelpunkts ein: ");
				y = double.Parse (Console.ReadLine ());
			}catch(Exception){
				Console.Clear ();
				newObjekt (type, preid);
			}
				
			do {
				try {
					switch (type) {
					case 1:
						Console.Write ("Geben Sie an, wie weit die Endpunkte horizontal vom Mittelpunkt entfernt sind: ");
						xd = double.Parse (Console.ReadLine ());
						Console.Write ("Geben Sie an, wie weit die Endpunkte vertikal vom Mittelpunkt entfernt sind: ");
						yd = double.Parse (Console.ReadLine ());
						graphList.Add (new CLinie (objnr, x, y, xd, yd));
						printObject (objnr);
						break;
					case 2:
						Console.WriteLine ("Geben Sie die Höhe an: ");
						xd = double.Parse (Console.ReadLine ());
						Console.WriteLine ("Geben Sie die Breite an: ");
						yd = double.Parse (Console.ReadLine ());
						graphList.Add (new CRechteck (objnr, x, y, xd, yd));
						printObject (objnr);
						break;
					case 3:
						Console.Write ("Geben Sie den Radius des Kreises an: ");
						radius = double.Parse (Console.ReadLine ());
						graphList.Add (new CKreis (objnr, x, y, radius));
						printObject (objnr);
						break;
					case 4:
						Console.Write ("Geben Sie die Länge einer Seite an: ");
						seitenlaenge = double.Parse (Console.ReadLine ());
						graphList.Add (new CQuadrat (objnr, x, y, seitenlaenge));
						printObject (objnr);
						break;
					}

					repeat = false;

				} catch (Exception) {
					//throw;
					Console.Clear();
					repeat = true;
				}
			} while(repeat == true);
		}
		#endregion

		#region edit/delete
		public void editObject(int what, int id, MenuClass mc = null){
			switch (what) {
			case 1:
				switch (mc.showMorphMenu ()) {
				case 1:
					deleteObject (id);
					newObjekt (1, id);
					break;
				case 2:
					deleteObject (id);
					newObjekt (2, id);
					break;
				case 3:
					deleteObject (id);
					newObjekt (3, id);
					break;
				case 4:
					deleteObject (id);
					newObjekt (4, id);
					break;
				}
				break;
			case 2:
				do{
					try{
						Console.WriteLine ("Um welchen Wert wollen Sie das Objekt an der X-Achse verschieben? ");
						x = int.Parse (Console.ReadLine ());
						Console.WriteLine ("Um welchen Wert wollen Sie das Objekt an der Y-Achse verschieben? ");
						y = int.Parse (Console.ReadLine ());

						getObjectById (id).move (x, y);
						repeat = false;
					}catch(TestException t){
						Console.WriteLine(t.ToString()); //test
						repeat = true;
					}
				}while(repeat == true);
				break;
			}
		}

		public void deleteObject(int id){
			try{
				graphList.Remove (getObjectById (id));
			}catch(Exception e){
				throw e;
			}
		}
		#endregion

		public CGraphObj getObjectById(int id){
			foreach(CGraphObj obj in graphList){
				if (obj.getId () == id) {
					return obj;
				}
			}
			return null;
		}

		#region output

		public void printAll(){
			foreach (CGraphObj o in graphList) {
				printObject (o.getId ());
			}
		}

		public void printObject(int onr){
			if ((tempobj = getObjectById (onr)) != null) {
				Console.WriteLine ("____________________________");
				Console.WriteLine ("Objektnummer: " + tempobj.getId ().ToString ());
				switch (tempobj.GetType ().Name) {
				case "CKreis":
					CKreis k = (CKreis)tempobj;
					k.draw ();
					break;
				case "CLinie":
					CLinie l = (CLinie)tempobj;
					l.draw ();
					break;
				case "CRechteck":
					CRechteck r = (CRechteck)tempobj;
					r.draw ();
					break;
				case "CQuadrat":
					CQuadrat q = (CQuadrat)tempobj;
					q.draw ();
					break;
				}
				Console.WriteLine ("____________________________");
				Console.WriteLine ();
			} else {
				printError ();
			}
		}

		public void printError(){
			Console.WriteLine ("Ein Fehler ist aufgetreten.");
		}
		#endregion
	}
}