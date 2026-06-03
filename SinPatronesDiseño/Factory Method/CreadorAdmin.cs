using ConPatronesDiseño;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConPatronesDiseño
{
    public class CreadorAdmin : CreadorReporte
    {
        private readonly string _nombre;
        private readonly string _codigo;
        private readonly string _departamento;
        private readonly string _estado;

        public CreadorAdmin(
            string nombre,
            string codigo,
            string departamento,
            string estado)
        {
            _nombre = nombre;
            _codigo = codigo;
            _departamento = departamento;
            _estado = estado;
        }

        // Una sola razón de cambio: la construcción de ReporteAdmin
        public override IComponenteReporte Crear()
            => new ReporteAdmin(_nombre, _codigo, _departamento, _estado);
    }
}
