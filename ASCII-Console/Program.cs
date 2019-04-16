using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using Un4seen.Bass;


namespace Bad_Apple
{
    class Program
    {
        static void Main(string[] args)
        {
            Un4seen.Bass.BassNet.Registration("anamnafiul99@gmail.com", "2X3141322152222");
            Console.Title= "Bad Apple";
            Bass.BASS_Init(-1, 44100, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero);
            
            string dir = Directory.GetCurrentDirectory();
            int framecount = Directory.GetFiles(dir+"/files/frames").Length;
            int play = Bass.BASS_StreamCreateFile(dir+"/files/audio/ugot.mp3", 0, 0, BASSFlag.BASS_DEFAULT);

            Console.SetWindowSize(151, 49);
            Console.WriteLine("Created By NaMLiM");
            Thread.Sleep(1000);
            Console.Clear();

            for(int frame = 1; frame <= framecount; frame++)
            {
                if(frame == 1)
                {
                    Bass.BASS_ChannelPlay(play, false);
                }
                string contents = File.ReadAllText(dir+ "/files/frames/ASCII-ugot-"+(frame)+".txt");
                Console.Write(contents);
                Console.SetCursorPosition(30, 360);
                if (frame == framecount)
                {
                    Console.WriteLine("Created By NaMLiM");
                    Thread.Sleep(1000);
                    Console.WriteLine("Press Any Key To Exit");
                    Console.ReadKey();
                    return;
                }
                
                Thread.Sleep(23);
                
            }
        }
    }
}
