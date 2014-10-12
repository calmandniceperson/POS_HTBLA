using System;

namespace Grafikbibliothek
{
	public interface IGraphObj
	{
		void setPos(CPunkt p);
		void move(double dx, double dy);
		void draw();
	}
}

