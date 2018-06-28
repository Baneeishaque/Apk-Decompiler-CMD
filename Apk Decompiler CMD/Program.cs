using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Apk_Decompiler_CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 1)
            {
                ProcessStartInfo a;
                Process b;
                Console.WriteLine("Decompilation Started...");
                try
                {

                    a = new ProcessStartInfo("cmd", "/c apktool if " + args[0])
                    {
                        RedirectStandardOutput = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    };
                    b = new Process
                    {
                        StartInfo = a
                    };
                    b.Start();
                    Console.WriteLine(b.StandardOutput.ReadToEnd());
                    //Console.ReadKey();
                }
                catch (Exception e)
                {

                }
                try
                {

                    a = new ProcessStartInfo("cmd", "/c apktool d " + args[0] + " apk\\ ")
                    {
                        RedirectStandardOutput = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    };
                    b = new Process
                    {
                        StartInfo = a
                    };
                    b.Start();
                    Console.WriteLine(b.StandardOutput.ReadToEnd());
                    //Console.ReadKey();
                }
                catch (Exception e)
                {

                }
                try
                {

                    a = new ProcessStartInfo("cmd", "/c WinRAR x -y " + args[0] + " winrar-apk\\")
                    {
                        RedirectStandardOutput = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    };
                    b = new Process
                    {
                        StartInfo = a
                    };
                    b.Start();
                    Console.WriteLine(b.StandardOutput.ReadToEnd());
                    //Console.ReadKey();
                }
                catch (Exception e)
                {

                }
                try
                {

                    a = new ProcessStartInfo("cmd", "/c d2j-dex2jar --force winrar-apk\\classes.dex")
                    {
                        RedirectStandardOutput = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    };
                    b = new Process
                    {
                        StartInfo = a
                    };
                    b.Start();
                    Console.WriteLine(b.StandardOutput.ReadToEnd());
                    //Console.ReadKey();
                }
                catch (Exception e)
                {

                }
                try
                {

                    a = new ProcessStartInfo("cmd", "/c WinRAR x -y classes-dex2jar.jar apk\\class")
                    {
                        RedirectStandardOutput = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    };
                    b = new Process
                    {
                        StartInfo = a
                    };
                    b.Start();
                    Console.WriteLine(b.StandardOutput.ReadToEnd());
                    //Console.ReadKey();
                }
                catch (Exception e)
                {

                }
                 try
                {

                    a = new ProcessStartInfo("cmd", "/c xcopy /y apk\\apktool.yml apk\\other\\")
                    {
                        RedirectStandardOutput = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    };
                    b = new Process
                    {
                        StartInfo = a
                    };
                    b.Start();
                    Console.WriteLine(b.StandardOutput.ReadToEnd());
                    //Console.ReadKey();
                }
                catch (Exception e)
                {

                }
                  try
                {

                    a = new ProcessStartInfo("cmd", "/c xcopy /y classes-dex2jar.jar apk\\other\\")
                    {
                        RedirectStandardOutput = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    };
                    b = new Process
                    {
                        StartInfo = a
                    };
                    b.Start();
                    Console.WriteLine(b.StandardOutput.ReadToEnd());
                    //Console.ReadKey();
                }
                catch (Exception e)
                {

                }
                   try
                {

                    a = new ProcessStartInfo("cmd", "/c del apk\apktool.yml")
                    {
                        RedirectStandardOutput = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    };
                    b = new Process
                    {
                        StartInfo = a
                    };
                    b.Start();
                    Console.WriteLine(b.StandardOutput.ReadToEnd());
                    //Console.ReadKey();
                }
                catch (Exception e)
                {

                }
                 try
                {

                    a = new ProcessStartInfo("cmd", "/c del classes-dex2jar.jar")
                    {
                        RedirectStandardOutput = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    };
                    b = new Process
                    {
                        StartInfo = a
                    };
                    b.Start();
                    Console.WriteLine(b.StandardOutput.ReadToEnd());
                    //Console.ReadKey();
                }
                catch (Exception e)
                {

                }
                try
                {

                    a = new ProcessStartInfo("cmd", "/c rmdir /s /q winrar-apk")
                    {
                        RedirectStandardOutput = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    };
                    b = new Process
                    {
                        StartInfo = a
                    };
                    b.Start();
                    Console.WriteLine(b.StandardOutput.ReadToEnd());
                    //Console.ReadKey();
                    Console.WriteLine("Decompilation Completed...");
                }
                catch (Exception e)
                {

                }


            }
            else
            {
                Console.WriteLine("Invalid Arguments");
            }
            Console.ReadKey();

        }
    }
}
