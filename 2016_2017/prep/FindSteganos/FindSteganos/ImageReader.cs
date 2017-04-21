using System.IO;

namespace FindSteganos
{
	public class ImageReader
	{
		static ImageReader instance;

		ImageReader() {}

		public static ImageReader GetInstance()
		{
			if (instance == null) { instance = new ImageReader(); }
			return instance;
		}

		public byte[] ReadImageBytes(string source)
		{
			return File.ReadAllBytes(source);
		}
	}
}
