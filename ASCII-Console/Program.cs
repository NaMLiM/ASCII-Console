using System;
using System.Collections;
using System.IO;
using System.Threading;
using Un4seen.Bass;

namespace ASCII
{
    static class Program
    {
        static void Main(string[] args)
        {
            Un4seen.Bass.BassNet.Registration("anamnafiul99@gmail.com", "2X3141322152222");
            Console.Title = "ASCII-Console";
            Bass.BASS_Init(-1, 44100, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero);
            string Dir = Directory.GetCurrentDirectory();
            int Error = 1, Input = 0, Framecount = 0, Play = 0;
            var Contents = new ArrayList();
            while (Error != 0)
            {
                Console.WriteLine("Created By NaMLiM");
                Console.WriteLine("Please select the ASCII Sequence:");
                Console.WriteLine("1. U Got That");
                Console.WriteLine("2. Bad Apple");
                try
                {
                    Input = Convert.ToInt32(Console.ReadLine());
                    Error = 0;
                }
                catch (System.FormatException e)
                {
                    Error = 1;
                    Console.WriteLine(e);
                    Thread.Sleep(3000);
                    Console.Clear();
                }
                if (Input == 1) //U-Got-That
                {
                    Framecount = Directory.GetFiles(Dir + "/files/frames").Length;
                    Play = Bass.BASS_StreamCreateFile(Dir + "/files/audio/ugot.mp3", 0, 0, BASSFlag.BASS_DEFAULT);
                    Console.WriteLine("Please Wait...");
                    for (int Frame = 1; Frame <= Framecount; Frame++)
                    {
                        Contents.Add(File.ReadAllText(Dir + "/files/frames/ASCII-ugot-" + (Frame) + ".txt"));
                    }
                    Console.SetWindowSize(166, 54);
                }
                else if (Input == 2) //Bad-Apple
                {
                    Framecount = Directory.GetFiles(Dir + "/files/frames_1").Length;
                    Play = Bass.BASS_StreamCreateFile(Dir + "/files/audio/bad-apple.mp3", 0, 0, BASSFlag.BASS_DEFAULT);
                    Console.WriteLine("Please Wait...");
                    for (int Frame = 1; Frame <= Framecount; Frame++)
                    {
                        Contents.Add(File.ReadAllText(Dir + "/files/frames_1/ASCII-bad-apple-" + (Frame) + ".txt"));
                    }
                    Console.SetWindowSize(125, 54);
                }
                else
                {
                    Error = 1;
                    Console.WriteLine("Input Salah!");
                    Thread.Sleep(3000);
                    Console.Clear();
                }
            }
            Console.WriteLine("Press Any Key To Start..");
            Console.ReadKey();
            Console.Clear();
            Bass.BASS_ChannelPlay(Play, false);
            for (int Frame = 0; Frame <= Framecount; Frame++)
            {
                Console.Write(Contents[Frame]);
                Console.SetCursorPosition(0, 54);
                Thread.Sleep(28);
            }
            Console.Clear();
            Console.WriteLine("Created By NaMLiM");
            Thread.Sleep(2000);
            Console.WriteLine("Press Any Key To Exit");
            Console.ReadKey();
            return;
        }
    }
}
