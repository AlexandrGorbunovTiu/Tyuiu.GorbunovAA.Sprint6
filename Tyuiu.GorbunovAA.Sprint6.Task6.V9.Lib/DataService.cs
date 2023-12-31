﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;

namespace Tyuiu.GorbunovAA.Sprint6.Task6.V9.Lib
{
    public class DataService : ISprint6Task6V9
    {
        public string CollectTextFromFile(string str, string path)
        {
            string resStr = "";

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains(str))
                    {
                        resStr = resStr + " " + line;
                    }
                }
            }
            return resStr;
        }
    }
}
