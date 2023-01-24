using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiriaVintimillaVisitor
{
    class Elemento : IElemento
    {
        public Elemento siguiente;
        public Elemento hijo;
        private double costo;
        private string nombre;
        public double Costo { get => costo; set => costo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public Elemento()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Elemento creado");
        }
        public Elemento(double pCosto, string pNombre, Elemento pSiguiente)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Elemento creado con siguiente {0}-> ${1}", pNombre, pCosto);
            siguiente = pSiguiente;
            costo = pCosto;
            nombre = pNombre;
        }
        //Aceptamos al visitante
        public virtual void Aceptar(IVisitante pVisitante)
        {
            //Nos mandamos como patarametro para que
            //el visitante procecse los datos
            pVisitante.Visitar(this);
        }

        /*internal void Aceptar(Visitante visitante)
        {
            throw new NotImplementedException();
        }*/
    }
}
