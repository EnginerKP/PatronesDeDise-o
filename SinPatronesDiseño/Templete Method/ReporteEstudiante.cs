using ConPatronesDiseño;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConPatronesDiseño
{
    public class ReporteEstudiante : ReporteBase
    {
        private readonly string _nombre;
        private readonly string _codigo;
        private readonly double _promedio;
        private readonly string _estado;

        public ReporteEstudiante(string nombre, string codigo,
                                  double promedio, string estado)
        {
            _nombre = nombre;
            _codigo = codigo;
            _promedio = promedio;
            _estado = estado;
        }

        protected override void ImprimirEncabezado()
        {
            Console.WriteLine(new string('=', 46));
            Console.WriteLine("       REPORTE DE ESTUDIANTE");
            Console.WriteLine($"       Fecha: {DateTime.Now:dd/MM/yyyy}");
            Console.WriteLine(new string('=', 46));
        }

        protected override void ImprimirDatos()
        {
            Console.WriteLine($"  Nombre   : {_nombre}");
            Console.WriteLine($"  Código   : {_codigo}");
            Console.WriteLine($"  Estado   : {_estado}");
            Console.WriteLine($"  Promedio : {_promedio:F1}");
            Console.WriteLine($"  Situación: {ObtenerClasificacion()}");
        }

        // Nombre claro: el método explica qué calcula, no cómo
        private string ObtenerClasificacion()
        {
            if (_promedio >= 3.5) return "HONOR";
            if (_promedio >= 3.0) return "APROBADO";
            return "EN RIESGO";
        }
    }
}
