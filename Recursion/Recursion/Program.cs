
namespace Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintDirectoryFileSystemEntries(@"D:\Almahdy\C# Advanced", 1);
            var size = CalculateDirectorySize(@"D:\Almahdy\C# Advanced");
            Console.WriteLine(size / 1024);
        }

        public static void PrintDirectoryFileSystemEntries(string dirPath, int level)
        {
            foreach(var fileName in Directory.GetFiles(dirPath))
                Console.WriteLine($"{new string('-', level)} {new FileInfo(fileName).Name}");

            foreach (var dirName in Directory.GetDirectories(dirPath))
            {
                Console.WriteLine($"{new string('-', level)} {new DirectoryInfo(dirName).Name}");
                PrintDirectoryFileSystemEntries(dirName, level + 1);
            }    
        }

        public static long CalculateDirectorySize(string dirPath)
        {
            long size = 0;
            foreach (var fileName in Directory.GetFiles(dirPath))
                size += new FileInfo(fileName).Length;

            foreach (var dirName in Directory.GetDirectories(dirPath))
            {
                size += CalculateDirectorySize(dirName);
            }
            return size;
        }
    }
}
