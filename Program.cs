﻿using System;
using System.IO;
namespace mpprog_lab_01
{
    class Program
    {
        static void Main(string[] args)
        {
              StreamReader sr = null;
            try
            {
          
            sr = new StreamReader ("/home/linuxmint/Desktop/doc"); 

            Console.WriteLine(sr.ReadToEnd());
            }
                    catch (FileNotFoundException ex)
                    {
                    Console.WriteLine($"File Not Found{ex.FileName}"); 
                    }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                sr?.Close(); 
            }
        }
    }
}
