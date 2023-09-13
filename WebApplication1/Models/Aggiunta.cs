using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Aggiunta
    {
        public string Tipe { get; set; }
        public double Price { get; set; }

        public Aggiunta() { }

        public Aggiunta(string tipe, double price)
        {
            Tipe = tipe;
            Price = price;
        }
    }
}