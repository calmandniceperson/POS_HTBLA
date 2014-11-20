using System;

namespace CSGeburtstagskalender
{
	public class Handler
	{
		public delegate void GeburtstagsHandler (Erinnerung e);

		public event GeburtstagsHandler KeinGeburtstag;
		public event GeburtstagsHandler HatGeburtstag;

		public virtual void onGeburtstag(EventArgs e, Erinnerung er){
			if (HatGeburtstag != null) {
				HatGeburtstag (er);
			}
		}

		public virtual void onKeinGeburtstag(EventArgs e, Erinnerung er){
			if (KeinGeburtstag != null) {
				KeinGeburtstag (er);
			}
		}
	}
}

