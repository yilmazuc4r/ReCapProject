﻿using Bussiness.Concrete;
using DataAccess.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemory());

            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.CarID);
            }
        }
    }
}
