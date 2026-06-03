using ConPatronesDiseño;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConPatronesDiseño
{
    public class CreadorProfesor : CreadorReporte
    {
        private readonly string _nombre;
        private readonly string _codigo;
        private readonly int _horasSemanales;
        private readonly string _estado;

        public CreadorProfesor(
            string nombre,
            string codigo,
            int horasSemanales,
            string estado)
        {
            _nombre = nombre;
            _codigo = codigo;
            _horasSemanales = horasSemanales;
            _estado = estado;
        }

        // Una sola razón de cambio: la construcción de ReporteProfesor
        public override IComponenteReporte Crear()
            => new ReporteProfesor(_nombre, _codigo, _horasSemanales, _estado);
    }
}
