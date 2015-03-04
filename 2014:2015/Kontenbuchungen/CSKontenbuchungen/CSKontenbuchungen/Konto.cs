// /*
//  *	MICHAEL KOEPPL 3AHIF
//  * 	2014/2015
//  */
using System;
using System.Text;

namespace CSKontenbuchungen
{
	public delegate void VerdaechtigerBetrag(object sender, EventArgs e);
	public delegate void Ueberzogen(object sender, EventArgs e);

	public class Konto
	{
		public double Ueberziehungsgrenze;
		public string Kontonummer{ get; set; }
		protected double _KontoStand;

		// event stuff
		public virtual event Ueberzogen ue;
		public virtual event VerdaechtigerBetrag vb;
		public virtual void OnUeberzogen (){}
		public virtual void OnVerdaechtig (){}

		public double Kontostand { 
			get {
				return _KontoStand;
			} 
			set {
				if (value > 10000) {
					OnVerdaechtig ();
				}
				_KontoStand += value;
			} 
		}

		public Konto (string k, double ks, double grenze)
		{
			Kontonummer = k;
			Kontostand = ks;
			Ueberziehungsgrenze = grenze;
		}

		public override string ToString ()
		{
			StringBuilder sb = new StringBuilder ();
			sb.Append ("Konto: Kontonummer=" + Kontonummer + "Kontostand=" + Kontostand);
			return sb.ToString ();
		}
	}
}

