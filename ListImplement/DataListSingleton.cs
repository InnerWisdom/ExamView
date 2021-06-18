using System;
using System.Collections.Generic;
using System.Text;
using ListImplement.Models;

namespace ListImplement
{
    public class DataListSingleton
    {
        private static DataListSingleton instance;

        public List<Pass> Passs { get; set; }

        public List<Reis> Reiss { get; set; }

        private DataListSingleton()
        {
            Passs = new List<Pass>();
            Reiss = new List<Reis>();
        }

        public static DataListSingleton GetInstance()
        {
            if (instance == null)
            {
                instance = new DataListSingleton();
            }
            return instance;
        }
    }
}
