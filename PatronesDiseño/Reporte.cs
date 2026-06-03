using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinPatronesDiseño
{
    public class Reporte
    {
        public string tipo;
        public string nombre;
        public string codigo;
        public double promedio;     // solo aplica a estudiantes
        public int horasClase;      // solo aplica a profesores
        public string departamento; // solo aplica a admins
        public string estado;       // activo / inactivo
        public string seccion;      // parte del reporte compuesto
        public bool esSeccion;

        // Lista de sub-reportes (mezcla la responsabilidad de árbol aquí mismo)
        List<Reporte> hijos = new List<Reporte>();

        public void AgregarHijo(Reporte r)
        {
            hijos.Add(r);
        }

        // Genera el reporte. Método gigante que hace todo.
        public void Generar()
        {
            if (esSeccion)
            {
                // Es un nodo contenedor: imprimir encabezado y delegar
                Console.WriteLine("===== SECCIÓN: " + seccion + " =====");
                foreach (var h in hijos)
                {
                    h.Generar();
                }
                return;
            }

            if (tipo == "estudiante")
            {
                Console.WriteLine("------------ REPORTE DE ESTUDIANTE ------------");
                Console.WriteLine("Fecha: " + DateTime.Now.ToShortDateString());
            }
            else if (tipo == "profesor")
            {
                Console.WriteLine("------------ REPORTE DE PROFESOR ------------");
                Console.WriteLine("Fecha: " + DateTime.Now.ToShortDateString());
            }
            else if (tipo == "admin")
            {
                Console.WriteLine("------- REPORTE ADMINISTRATIVO -------");
                Console.WriteLine("Fecha: " + DateTime.Now.ToShortDateString());
            }
            else
            {
                Console.WriteLine("TIPO DESCONOCIDO");
                return;
            }

            if (tipo == "estudiante")
            {
                Console.WriteLine("Nombre  : " + nombre);
                Console.WriteLine("Código  : " + codigo);
                Console.WriteLine("Estado  : " + estado);
                Console.WriteLine("Promedio: " + promedio);

                // Lógica de negocio mezclada con presentación
                if (promedio >= 3.5)
                    Console.WriteLine("Clasificación: HONOR");
                else if (promedio >= 3.0)
                    Console.WriteLine("Clasificación: APROBADO");
                else
                    Console.WriteLine("Clasificación: EN RIESGO");
            }
            else if (tipo == "profesor")
            {
                Console.WriteLine("Nombre      : " + nombre);
                Console.WriteLine("Código      : " + codigo);
                Console.WriteLine("Estado      : " + estado);
                Console.WriteLine("Horas/semana: " + horasClase);

                if (horasClase > 20)
                    Console.WriteLine("Carga: ALTA");
                else if (horasClase >= 12)
                    Console.WriteLine("Carga: NORMAL");
                else
                    Console.WriteLine("Carga: BAJA");
            }
            else if (tipo == "admin")
            {
                Console.WriteLine("Nombre       : " + nombre);
                Console.WriteLine("Código       : " + codigo);
                Console.WriteLine("Departamento : " + departamento);
                Console.WriteLine("Estado       : " + estado);
            }

            // ---- PASO 3: Pie de página ----
            if (tipo == "estudiante")
            {
                Console.WriteLine("Sistema Académico v1.0");
                Console.WriteLine("--- FIN DEL REPORTE ---");
            }
            else if (tipo == "profesor")
            {
                Console.WriteLine("Sistema Académico v1.0");
                Console.WriteLine("--- FIN DEL REPORTE ---");
            }
            else if (tipo == "admin")
            {
                Console.WriteLine("Sistema Administrativo v1.0");
                Console.WriteLine("--- FIN DEL REPORTE ---");
            }

            Console.WriteLine();
        }
    }
}
