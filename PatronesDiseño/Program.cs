using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinPatronesDiseño
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear reporte de estudiante manualmente
            Reporte r1 = new Reporte();
            r1.tipo = "estudiante";
            r1.nombre = "Laura Gómez";
            r1.codigo = "EST-1001";
            r1.promedio = 3.8;
            r1.estado = "activo";
            r1.esSeccion = false;

            // Crear reporte de profesor manualmente
            Reporte r2 = new Reporte();
            r2.tipo = "profesor";
            r2.nombre = "Carlos Pérez";
            r2.codigo = "DOC-2001";
            r2.horasClase = 18;
            r2.estado = "activo";
            r2.esSeccion = false;

            // Crear reporte admin manualmente
            Reporte r3 = new Reporte();
            r3.tipo = "admin";
            r3.nombre = "Ana Torres";
            r3.codigo = "ADM-3001";
            r3.departamento = "Registro";
            r3.estado = "activo";
            r3.esSeccion = false;

            Reporte seccionAcademica = new Reporte();
            seccionAcademica.esSeccion = true;
            seccionAcademica.seccion = "Facultad de Ingeniería";

            seccionAcademica.AgregarHijo(r1);
            seccionAcademica.AgregarHijo(r2);

            Reporte seccionAdmin = new Reporte();
            seccionAdmin.esSeccion = true;
            seccionAdmin.seccion = "Área Administrativa";

            seccionAdmin.AgregarHijo(r3);

            // Sección raíz (árbol de 2 niveles)
            Reporte universidad = new Reporte();
            universidad.esSeccion = true;
            universidad.seccion = "Universidad Central — Reporte General";

            universidad.AgregarHijo(seccionAcademica);
            universidad.AgregarHijo(seccionAdmin);

           
            Console.WriteLine("====== GENERANDO REPORTES ======\n");
            universidad.Generar();

            Console.WriteLine("\nPresiona Enter para salir...");
            Console.ReadLine();
        }
    }
}
