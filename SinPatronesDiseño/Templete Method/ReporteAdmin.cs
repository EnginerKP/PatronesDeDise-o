using ConPatronesDiseño;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConPatronesDiseño
{
    public class ReporteAdmin : ReporteBase
    {
        private readonly string _nombre;
        private readonly string _codigo;
        private readonly string _departamento;
        private readonly string _estado;

        public ReporteAdmin(string nombre, string codigo,
                             string departamento, string estado)
        {
            _nombre = nombre;
            _codigo = codigo;
            _departamento = departamento;
            _estado = estado;
        }

        protected override void ImprimirEncabezado()
        {
            Console.WriteLine(new string('=', 46));
            Console.WriteLine("     REPORTE ADMINISTRATIVO");
            Console.WriteLine($"     Fecha: {DateTime.Now:dd/MM/yyyy}");
            Console.WriteLine(new string('=', 46));
        }

        protected override void ImprimirDatos()
        {
            Console.WriteLine($"  Nombre        : {_nombre}");
            Console.WriteLine($"  Código        : {_codigo}");
            Console.WriteLine($"  Departamento  : {_departamento}");
            Console.WriteLine($"  Estado        : {_estado}");
        }

        // Sobreescribimos el hook del pie para diferenciar el sistema
        protected override void ImprimirPie()
        {
            Console.WriteLine("Sistema Administrativo — Universidad Central");
            Console.WriteLine(new string('-', 46));
        }
    }
}
