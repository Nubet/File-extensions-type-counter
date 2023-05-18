using System;
using System.IO;

namespace Extension_type_counter
{
    class Program
    {
        public static int folder_ile_zdj_lacznie, folder_ile_filmow_lacznie;

        //foldery w podanej lokalizacji
        public static void sprawdz_lokalizacje(string folder)
        {
            string[] jpg = Directory.GetFiles(folder, "*.jpg");
            string[] png = Directory.GetFiles(folder, "*.png");
            string[] jpeg = Directory.GetFiles(folder, " *.jpeg");
            string[] tiff = Directory.GetFiles(folder, "*.tiff");
            string[] bmp = Directory.GetFiles(folder, " *.bmp");
            string[] heif = Directory.GetFiles(folder, " *.heif");
            //filmy 
            string[] mp4 = Directory.GetFiles(folder, "*.mp4");
            string[] avi = Directory.GetFiles(folder, "*.avi");
            string[] mkv = Directory.GetFiles(folder, "*.mkv");
            string[] mov = Directory.GetFiles(folder, "*.mov");
            string[] wmv = Directory.GetFiles(folder, "*.wmv");
            string[] flv = Directory.GetFiles(folder, "*.flv");

            /*
            Console.WriteLine("FOLDER");
            Console.WriteLine("Jpg: " + jpg.Length);
            Console.WriteLine("Png: " + png.Length);
            Console.WriteLine("Jpeg: " + jpeg.Length);
            Console.WriteLine("Tiff: " + tiff.Length);
            Console.WriteLine("Bmp: " + bmp.Length);
            Console.WriteLine("Heif: " + heif.Length);*/

       
            folder_ile_zdj_lacznie += jpg.Length + png.Length + tiff.Length + bmp.Length + heif.Length;
            folder_ile_filmow_lacznie += mp4.Length + avi.Length + mov.Length + mkv.Length + wmv.Length + flv.Length;


        }
        static void Main(string[] args)
        {
            string path = @"C:\Users\Nubet\source\repos\Extension type counter\Pliki\";

            if (Directory.Exists(path))
            {
                string[] foldery = Directory.GetDirectories(path);

                if (foldery.Length > 0)
                {
                    Console.WriteLine("Wykryte Foldery");
                    Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                    foreach (string folder in foldery)
                    {
                        Console.WriteLine(folder + "\n");
                        sprawdz_lokalizacje(folder);
                    }
                    
                }

                if (folder_ile_zdj_lacznie > 0)
                    Console.WriteLine( "Zdj w folderach: " + folder_ile_zdj_lacznie );

                if (folder_ile_filmow_lacznie > 0)
                    Console.WriteLine("Filmow w folderach: " + folder_ile_filmow_lacznie);

                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            }



            //zdj
            string[] jpg = Directory.GetFiles(path, "*.jpg");
            string[] png = Directory.GetFiles(path, "*.png");
            string[] jpeg = Directory.GetFiles(path, " *.jpeg");
            string[] tiff = Directory.GetFiles(path, "*.tiff");
            string[] bmp = Directory.GetFiles(path, " *.bmp");
            string[] heif = Directory.GetFiles(path, " *.heif");
            //filmy 
            string[] mp4 = Directory.GetFiles(path, "*.mp4");
            string[] avi = Directory.GetFiles(path, "*.avi");
            string[] mkv = Directory.GetFiles(path, "*.mkv");
            string[] mov = Directory.GetFiles(path, "*.mov");
            string[] wmv = Directory.GetFiles(path, "*.wmv");
            string[] flv = Directory.GetFiles(path, "*.flv");


            Console.WriteLine("Jpg: " + jpg.Length);
            Console.WriteLine("Png: " + png.Length);
            Console.WriteLine("Jpeg: " + jpeg.Length);
            Console.WriteLine("Tiff: " + tiff.Length);
            Console.WriteLine("Bmp: " + bmp.Length);
            Console.WriteLine("Heif: " + heif.Length);

            int zdj_lacznie = jpg.Length + png.Length + jpeg.Length + tiff.Length + bmp.Length + heif.Length;

            //Console.WriteLine("ZDJ LACZNIE: " + zdj_lacznie);
            Console.WriteLine("ZDJ LACZNIE: " + (zdj_lacznie + folder_ile_zdj_lacznie).ToString());





            Console.WriteLine("=============================================");


            Console.WriteLine("mp4: " + mp4.Length);
            Console.WriteLine("avi: " + avi.Length);
            Console.WriteLine("mkv: " + mkv.Length);
            Console.WriteLine("wmv: " + wmv.Length);
            Console.WriteLine("flv: " + flv.Length);

            int filmow_lacznie = mp4.Length + avi.Length + mkv.Length + + mov.Length + wmv.Length + flv.Length;

           // Console.WriteLine("Filmów LACZNIE: " + filmow_lacznie + folder_ile_filmow_lacznie);
            Console.WriteLine("Filmów LACZNIE: " + (filmow_lacznie + folder_ile_filmow_lacznie).ToString());






        }
    }
}
