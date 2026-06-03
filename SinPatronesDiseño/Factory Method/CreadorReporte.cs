using ConPatronesDiseño;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConPatronesDiseño
{
    public abstract class CreadorReporte
    {
        public abstract IComponenteReporte Crear();
    }
}
