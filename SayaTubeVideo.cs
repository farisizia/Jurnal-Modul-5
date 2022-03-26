using System;
using System.Collections.Generic;
using System.Text;

namespace Jurnal_MOD5_1302204021
{
    class SayaTubeVideo
    {
        public string id { get; set; }
        public string title { get; set; }
        public string playCount { get; set; }

        public SayaTubeVideo(string id, string playCount)
        {
            Debug.Assert(id.Length == 5, "Panjang id adalah 5 karakter");
            this.id = id;

            Debug.Assert(playCount.Length == 0, "Panjang playCount adalah 0 karakter");
            this.playCount = playCount;
        }

        public SayaTubeVideo()
        {
        }

        public void increasePlayCount()
        {
            int hasil = playCount.Length;
        }
        public void printVideoDetails()
        {
            Console.WriteLine(id);
            Console.WriteLine(title);
            Console.WriteLine(playCount);
        }
        public static int DesignbyContrast(int id, int playCount)
        {
            Debug.Assert(id <= int.MaxValue && id >= int.MinValue);
            Debug.Assert(playCount <= int.MaxValue && playCount >= int.MinValue);

            int hasil;
            try
            {
                hasil = checked(id);
                Console.WriteLine("Pengecekan berjalan tanpa masalah " + e.Message);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Karena erjadi overflow output diganti dengan 0");
                hasil = 0;
            }
            return hasil;
        }
    }
}
