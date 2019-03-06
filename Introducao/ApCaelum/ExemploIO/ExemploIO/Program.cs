using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExemploIO
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] drivers = DriveInfo.GetDrives();
            Console.WriteLine("Número de drivers: " + drivers.Length);
            Console.WriteLine("Lista de drivers deste computador: ");

            foreach (DriveInfo driver in drivers)
            {
                Console.WriteLine("Nome: " + driver.Name);
                if (!driver.IsReady)
                {
                    Console.WriteLine("*************************************************");
                    continue;
                }
                Console.WriteLine("Volume Label: " + driver.VolumeLabel);
                Console.WriteLine("Total Size: " + driver.TotalSize);
                Console.WriteLine("Espaço Livre: " + driver.TotalFreeSpace);
                Console.WriteLine("Espaço Alocado: " + driver.AvailableFreeSpace);
                Console.WriteLine("Is Ready: " + driver.IsReady);
                Console.WriteLine("Tipo Drive: " + driver.DriveType);
                Console.WriteLine("Formato: " + driver.DriveFormat);
                Console.WriteLine("Raiz Drive " + driver.RootDirectory);
                Console.WriteLine("*************************************************");
            }

            Console.ReadKey();

        }
    }
}
