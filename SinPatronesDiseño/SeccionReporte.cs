using ConPatronesDiseño;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConPatronesDiseño
{
    public class SeccionReporte : IComponenteReporte
    {
        private readonly string _titulo;
        private readonly List<IComponenteReporte> _componentes;

        public SeccionReporte(string titulo)
        {
            _titulo = titulo;
            _componentes = new List<IComponenteReporte>();
        }

        public void Agregar(IComponenteReporte componente)
        {
            _componentes.Add(componente);
        }

        public void Generar()
        {
            Console.WriteLine();
            Console.WriteLine($"{'*',2} SECCIÓN: {_titulo.ToUpper()} {'*',2}");
            Console.WriteLine(new string('*', 46));

            foreach (var componente in _componentes)
            {
                componente.Generar();   
            }
        }
    }
}
