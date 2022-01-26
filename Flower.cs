using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MySqlConnectivity.Models
{
    public class Flower
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

        public Flower(int id, string name, string color)
        {
            Id = id;
            Name = name;
            Color = color;
        }

        public override string ToString()
        {
            return "Id : "+Id+" Name : "+Name+" Color : "+Color;
        }

        public void show()
        {
            Console.WriteLine("Flowers details");
        }
    }
}