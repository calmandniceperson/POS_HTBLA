// /*
//  *	MICHAEL KOEPPL 3AHIF
//  * 	2014/2015
//  */
using System;

namespace sn3_koeppl
{
	public interface IMessung
	{
		void MessungGueltig (int val);
		void setMessung (int val);
		void setGrenzwerte (int g1, int g2);
	}
}

