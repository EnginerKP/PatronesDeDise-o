using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConPatronesDiseño
{
    public abstract class ReporteBase : IComponenteReporte
    {
        public void Generar()
        {
            ImprimirEncabezado();
            ImprimirDatos();
            ImprimirPie();
            Console.WriteLine();
        }

        protected abstract void ImprimirEncabezado();
        protected abstract void ImprimirDatos();

        // Una subclase puede sobreescribirlo si necesita un pie distinto.
        protected virtual void ImprimirPie()
        {
            Console.WriteLine("Sistema Académico — Universidad Central");
            Console.WriteLine(new string('-', 46));
        }
    }
}
