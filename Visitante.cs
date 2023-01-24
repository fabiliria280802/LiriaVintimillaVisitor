using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiriaVintimillaVisitor
{
    class Visitante : IVisitante
    {
        private int conteo;
        private int clasificaciones;
        private double total;
        public int Conteo { get => conteo; set=> conteo = value; }
        public int Clasificaciones { get => clasificaciones; set => clasificaciones = value; }
        public double Total { get=> total; set => total = value; }
        public void ContarElementos(Elemento pElemento)
        {
            //Se manda como visitante al elemento
            pElemento.Aceptar(this);
            //Si tiene hijo
            if(pElemento.hijo != null)
            {
                ContarElementos(pElemento.hijo);
            }
            //Si tiene siguiente
            if (pElemento.siguiente != null)
            {
                ContarElementos(pElemento.siguiente);
            }
        }
        public void Visitar(Elemento pElemento)
        {
            conteo++;
            Total += pElemento.Costo;
        }
        public void Visitar(ElementoL pElemento)
        {
            clasificaciones++;
            Console.ForegroundColor= ConsoleColor.White;
            Console.WriteLine("No conteo");
        }
    }
}
