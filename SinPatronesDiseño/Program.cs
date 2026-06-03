using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConPatronesDiseño
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreadorReporte creadorLaura = new CreadorEstudiante(
                nombre: "Laura Gómez",
                codigo: "EST-1001",
                promedio: 3.8,
                estado: "Activo");

            CreadorReporte creadorCarlos = new CreadorEstudiante(
                nombre: "Carlos Ríos",
                codigo: "EST-1002",
                promedio: 2.7,
                estado: "Activo");

            CreadorReporte creadorMonica = new CreadorProfesor(
                nombre: "Dra. Mónica Vargas",
                codigo: "DOC-2001",
                horasSemanales: 18,
                estado: "Activo");

            CreadorReporte creadorAna = new CreadorAdmin(
                nombre: "Ana Torres",
                codigo: "ADM-3001",
                departamento: "Registro y Control",
                estado: "Activo");

            // Crear los productos — cada creador sabe qué clase instanciar
            IComponenteReporte reporteLaura = creadorLaura.Crear();
            IComponenteReporte reporteCarlos = creadorCarlos.Crear();
            IComponenteReporte reporteMonica = creadorMonica.Crear();
            IComponenteReporte reporteAna = creadorAna.Crear();

            var creadorFacultad = new CreadorSeccion("Facultad de Ingeniería");
            var creadorAdminArea = new CreadorSeccion("Área Administrativa");
            var creadorUniversidad = new CreadorSeccion("Universidad Central — Reporte General");

            // Crear los nodos contenedores
            var facultad = (SeccionReporte)creadorFacultad.Crear();
            var adminArea = (SeccionReporte)creadorAdminArea.Crear();
            var universidad = (SeccionReporte)creadorUniversidad.Crear();

            // Construir el árbol
            facultad.Agregar(reporteLaura);
            facultad.Agregar(reporteCarlos);
            facultad.Agregar(reporteMonica);

            adminArea.Agregar(reporteAna);

            universidad.Agregar(facultad);
            universidad.Agregar(adminArea);

            Console.WriteLine("====== GENERANDO REPORTE INSTITUCIONAL ======\n");
            universidad.Generar();

            Console.WriteLine("\nPresiona Enter para salir...");
            Console.ReadLine();
        }
    }
}
