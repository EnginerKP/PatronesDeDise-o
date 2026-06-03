using ConPatronesDiseño;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConPatronesDiseño
{
    public class CreadorEstudiante : CreadorReporte
    {
        private readonly string _nombre;
        private readonly string _codigo;
        private readonly double _promedio;
        private readonly string _estado;

        public CreadorEstudiante(
            string nombre,
            string codigo,
            double promedio,
            string estado)
        {
            _nombre = nombre;
            _codigo = codigo;
            _promedio = promedio;
            _estado = estado;
        }

        // Una sola razón de cambio: la construcción de ReporteEstudiante
        public override IComponenteReporte Crear()
            => new ReporteEstudiante(_nombre, _codigo, _promedio, _estado);
    }
}
