using ConPatronesDiseño;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConPatronesDiseño
{
    public class CreadorSeccion : CreadorReporte
    {
        private readonly string _titulo;

        public CreadorSeccion(string titulo)
        {
            _titulo = titulo;
        }

        public override IComponenteReporte Crear()
            => new SeccionReporte(_titulo);
    }
}
