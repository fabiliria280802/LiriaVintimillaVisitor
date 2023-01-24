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
        public double Costo { get => costo; set => costo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public Elemento()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Elemento creado");
        }
        public Elemento()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Elemento creado");
        }
        public virtual void Aceptar(IVisitante pVisitante)
        {
            throw new NotImplementedException();
        }
    }
}
