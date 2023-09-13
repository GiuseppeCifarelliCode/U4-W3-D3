using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Pizza
    {
        public string Nome { get; set; }

        public List<Aggiunta> Aggiunte = new List<Aggiunta>();
        public double Price { get; set; }

        public Pizza() { }

        public Pizza(string nome, double price)
        {
            Nome = nome;
            Price = price;
        }
    }
}