// Michael Koeppl 5AHIF
// 26 September 2016

using System;
using System.IO;

namespace ConsoleApplication
{
    public class Program
    {
        private static double storageUsage;
        private static void DoSubDir(DirectoryInfo dirInfo)
        {
            FileInfo[] fInfo = dirInfo.GetFiles();
            if (fInfo.Length > 0) {
                foreach(FileInfo f in fInfo)
                {
                    // macOS fix
                    if (f.Name != ".DS_Store")
                    {
                        Console.WriteLine(f.Name);
                        storageUsage += f.Length;
                    }
                }
            }
            var subDirInfo = dirInfo.GetDirectories();
            if (subDirInfo.Length == 0)
                return;
            foreach (DirectoryInfo inf in subDirInfo)
            {
                DoSubDir(inf);
            }
        }

        public static void Main(string[] args)
        {
            Console.Clear();
            DirectoryInfo dInfo = new DirectoryInfo("datavz/");
            DoSubDir(dInfo);
            Console.WriteLine("\n" + storageUsage + " bytes");
        }
    }
}
