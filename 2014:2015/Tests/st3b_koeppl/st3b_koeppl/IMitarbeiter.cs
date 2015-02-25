using System;
using System.Collections.Generic;

namespace st3b_koeppl
{
	public interface IMitarbeiter
	{
		void pruefe_tageskernzeit(List<Zeiten> zeit);
		void pruefe_wochenkernzeit(List<Zeiten> zeit);
	}
}