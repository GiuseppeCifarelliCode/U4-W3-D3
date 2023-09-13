using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Models;

namespace WebApplication1.Clienti
{
    public partial class menu : System.Web.UI.Page
    {
        public static List<Pizza> Pizze = new List<Pizza>();
        protected void Page_Load(object sender, EventArgs e)
        {
            message.Visible = false;
            listContainer.Visible = false; 

    }

        protected void addPizza_Click(object sender, EventArgs e)
        {
            string option = listaPizze.SelectedValue;
            switch (option)
            {
                case "margherita":
                    Pizza pizza = new Pizza("Margherita", 4);
                    for (int i = 0; i < listaAggiunte.Items.Count; i++)
                    {
                        if (listaAggiunte.Items[i].Selected)
                        {
                            Aggiunta aggiunta = new Aggiunta(listaAggiunte.Items[i].Text, Double.Parse(listaAggiunte.Items[i].Value));
                            pizza.Aggiunte.Add(aggiunta);
                        }
                    }
                    Pizze.Add(pizza);
                    break;

                case "diavola":
                    Pizza pizza1 = new Pizza("Diavola", 5);
                    for (int i = 0; i < listaAggiunte.Items.Count; i++)
                    {
                        if (listaAggiunte.Items[i].Selected)
                        {
                            Aggiunta aggiunta = new Aggiunta(listaAggiunte.Items[i].Text, Double.Parse(listaAggiunte.Items[i].Value));
                            pizza1.Aggiunte.Add(aggiunta);
                        }
                    }
                    Pizze.Add(pizza1);
                    break;

                case "formaggi":
                    Pizza pizza2 = new Pizza("4 Formaggi", 6);
                    for (int i = 0; i < listaAggiunte.Items.Count; i++)
                    {
                        if (listaAggiunte.Items[i].Selected)
                        {
                            Aggiunta aggiunta = new Aggiunta(listaAggiunte.Items[i].Text, Double.Parse(listaAggiunte.Items[i].Value));
                            pizza2.Aggiunte.Add(aggiunta);
                        }
                    }
                    Pizze.Add(pizza2);
                    break;

                case "americana":
                    Pizza pizza3 = new Pizza("Americana", 6);
                    for (int i = 0; i < listaAggiunte.Items.Count; i++)
                    {
                        if (listaAggiunte.Items[i].Selected)
                        {
                            Aggiunta aggiunta = new Aggiunta(listaAggiunte.Items[i].Text, Double.Parse(listaAggiunte.Items[i].Value));
                            pizza3.Aggiunte.Add(aggiunta);
                        }
                    }
                    Pizze.Add(pizza3);
                    break;
            }
            message.Visible = true;
        }

        protected void showTotal_Click(object sender, EventArgs e)
        {
            message.Visible = false;
            listContainer.Visible = true;
            foreach (Pizza pizza in Pizze)
            {
                Literal literal = new Literal();
                literal.Text = "";
                double totAggiunte = 0;
                literal.Text = $"<p>{pizza.Nome} (${pizza.Price})";
         
                foreach (Aggiunta aggiunta in pizza.Aggiunte)
                {
                    totAggiunte += aggiunta.Price;
                    literal.Text += $" + {aggiunta.Tipe}";
                }
                literal.Text += $": ${pizza.Price + totAggiunte} </p>";
                listContainer.Controls.Add(literal);
            }

        }
    }
}