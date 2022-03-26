using System;

namespace Jurnal_MOD5_1302204021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayaTubeVideo objek1 = new SayaTubeVideo();
            SayaTubeUser objek2 = new SayaTubeUser();
            Console.WriteLine("Review Film " + objek1.id + " oleh " + objek2.username);
        }
    }
}
