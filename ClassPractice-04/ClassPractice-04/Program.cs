using ClassPractice_04.DbContexts;
using ClassPractice_04.Models;
using System;
using System.Collections.Generic;

namespace ClassPractice_04
{
    class Program
    {
        static void Main(string[] args)
        {
           

            var item = new List<Items>()
            {
                new Items()
                {
                    Name="Shirt",
                    Price=2000,
                    ManufactureDate=DateTime.Now


                },
                new Items()
                {
                    Name="Jeans",
                    Price=1500,
                    ManufactureDate=DateTime.Now

                },

                new Items()
                {
                    Name="Punjabi",
                    Price=2550,
                    ManufactureDate=DateTime.Now
                }

            };
            var brand = new Brands()
            {
                BrandName = "Gentle Park",
                Items = item
                
            };
            var db = new CategoryDb();

            db.Brand.Add(brand);

            var count = db.SaveChanges();
            if (count>0)
            {
                Console.WriteLine("SuccessFull Save");
            }
            else
            {
                Console.WriteLine("Not Save");
            }

            
            
        }
    }
}
