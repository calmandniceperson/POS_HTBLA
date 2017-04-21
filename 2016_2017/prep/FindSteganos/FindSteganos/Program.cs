using System;
using System.IO;

namespace FindSteganos
{
	class MainClass
	{
		// Moegliche Vorgehensweise:
		// 	- Directories (und Subdirectories) durchlaufen
		//	- Liste der Dateien erzeugen (nur Bilder)
		//	- Vergleiche die beiden Listen, erzeuge gemeinsame Schnittmenge
		//	  Wie bildet man Schnittmengen schnell?
		//
		//	Alternative zu byte-weisem Vergleich: Hash
		//	Schneller machen: Laenge vorab vergleichen. Ist Laenge nicht
		//	gleich, koennen die Bilder nicht gleich sind.


		const string IMAGES_ORIGINAL = "../../../Original";
		const string IMAGES_MODIFIED = "../../../Modified";
		
		public static void Main(string[] args)
		{
			if (!(Directory.Exists(IMAGES_ORIGINAL) && Directory.Exists(IMAGES_MODIFIED)))
			{
				Console.WriteLine("Image directories not found");
				return;
			}

			Tuple<string[], string[]> images = GetAllImagePaths();
			for (int i = 0; i < images.Item1.Length; i++)
			{
				byte[] originalImageBytes = ImageReader.GetInstance().ReadImageBytes(images.Item1[i]);
				byte[] maybeModifiedImageBytes = ImageReader.GetInstance().ReadImageBytes(images.Item2[i]);
				Console.WriteLine($"Original and modified image {i}");
				Console.WriteLine($"File Names:\n\t{images.Item1[i]}\n\t{images.Item2[i]}");
				Console.WriteLine($"Images match: {ImageComparer.GetInstance().CheckImagesMatch(originalImageBytes, maybeModifiedImageBytes)}");
				Console.WriteLine();
			}

			Console.ReadKey();
		}

		static Tuple<string[], string[]> GetAllImagePaths()
		{
			string[] originalImages = Directory.GetFiles(IMAGES_ORIGINAL);
			string[] modifiedImages = Directory.GetFiles(IMAGES_MODIFIED);
			return Tuple.Create(originalImages, modifiedImages);
		}
	}
}
