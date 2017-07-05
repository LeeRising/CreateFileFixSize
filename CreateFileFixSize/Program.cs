using System;
using System.IO;

namespace CreateFileFixSize
{
    class Program
    {
        static void Main()
        {
            Console.Write("File size(Mib) ");
            var fileSize = Convert.ToInt32(Console.ReadLine());
            var fileBytes = new byte[fileSize * 1048576];
            new Random().NextBytes(fileBytes);
            using (var writer = new BinaryWriter(File.Create($"testfile{fileSize}Mb")))
                writer.Write(fileBytes);
        }
    }
}
