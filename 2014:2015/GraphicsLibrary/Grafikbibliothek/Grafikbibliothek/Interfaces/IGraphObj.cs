using System;

namespace Grafikbibliothek
{
	public interface IGraphObj
	{
		void setPos(CPunkt p, double x, double y);
		void move(double dx, double dy);
		void draw();
	}
}

