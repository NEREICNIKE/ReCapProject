using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var car in new CarManager(new InMemoryCarDal()).GetAll())
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}