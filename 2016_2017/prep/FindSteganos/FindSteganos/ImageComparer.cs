namespace FindSteganos
{
	public class ImageComparer
	{
		static ImageComparer instance;

		ImageComparer() { }

		public static ImageComparer GetInstance()
		{
			if (instance == null) { instance = new ImageComparer(); }
			return instance;
		}

		public bool CheckImagesMatch(byte[] img1, byte[] img2)
		{
			for (int i = 0; i < img1.Length; i++)
			{
				if (img1[i] != img2[i]) { return false; }
			}
			return true;
		}
	}
}
