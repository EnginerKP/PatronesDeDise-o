using ConPatronesDiseño;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConPatronesDiseño
{
    public class ReporteProfesor : ReporteBase
    {
        private readonly string _nombre;
        private readonly string _codigo;
        private readonly int _horasSemanales;
        private readonly string _estado;

        public ReporteProfesor(string nombre, string codigo,
                                int horasSemanales, string estado)
        {
            _nombre = nombre;
            _codigo = codigo;
            _horasSemanales = horasSemanales;
            _estado = estado;
        }

        protected override void ImprimirEncabezado()
        {
            Console.WriteLine(new string('=', 46));
            Console.WriteLine("         REPORTE DE PROFESOR");
            Console.WriteLine($"         Fecha: {DateTime.Now:dd/MM/yyyy}");
            Console.WriteLine(new string('=', 46));
        }

        protected override void ImprimirDatos()
        {
            Console.WriteLine($"  Nombre        : {_nombre}");
            Console.WriteLine($"  Código        : {_codigo}");
            Console.WriteLine($"  Estado        : {_estado}");
            Console.WriteLine($"  Horas/semana  : {_horasSemanales}");
            Console.WriteLine($"  Carga laboral : {ObtenerCargaLaboral()}");
        }

        private string ObtenerCargaLaboral()
        {
            if (_horasSemanales > 20) return "ALTA";
            if (_horasSemanales >= 12) return "NORMAL";
            return "BAJA";
        }
    }
}
