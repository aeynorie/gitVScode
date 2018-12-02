using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GetData_FromFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadFiles rf = new ReadFiles("/Users/ayanoriohashi/Data/Repos/File");
        }
    }
    
    public class ReadFiles
    {
        private string filePath;
        public ReadFiles(string dir){
            this.filePath = dir;
            string[] files = Directory.GetFiles(dir, "*.txt");
            
            for(var i = 0; i<files.Length; i++){
               StreamReader sr = new StreamReader(files[i]);
                string text = sr.ReadToEnd();
                sr.Close();
                Console.WriteLine(text);
            }   
        }
    }
}
