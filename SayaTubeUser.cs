using System;
using System.Collections.Generic;
using System.Text;

namespace Jurnal_MOD5_1302204021
{
    class SayaTubeUser
    {
        private int id { get; set; }
        private [] uploadedVideo;
        public string username { get; set; }

        public SayaTubeUser(string username, [] uploadedVideo)
        {
            this.username = username;
            this.uploadedVideo = uploadedVideo;
        }

        public SayaTubeUser()
        {
        }

        public int GetTotalVideoPlayCount()
        {
            return
        }
        public void AddVideo(List<SayaTubeVideo> uploadedVideo)
        {
            uploadedVideo.Add();
        }
        public void PrintAllVideoPlayCount()
        {
            Console.WriteLine("User: " + username);
            Console.WriteLine("Video 1 judul: " + uploadedVideo.Count);
            Console.WriteLine("Video 2 judul: " + uploadedVideo.Count);
        }
        public static int DesignbyContrast(int username, List<SayaTubeVideo> uploadedVideo)
        {
            Debug.Assert(username <= int.MaxValue && username >= int.MinValue);

            int hasil;
            try
            {
                hasil = checked(username);
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
