using System;
using System.Collections.Generic;

namespace ScpDatabaseProg
{
    class Program
    {
        static void Main(string[] args)
        {
            ScpDataBase data = new ScpDataBase();


            data.AddItem(new ScpItem("Addendum 01"));
            data.AddItem(new ScpItem("Interview Log 001"));
            Console.WriteLine(data.GetItems().name);
        }
    }
}
