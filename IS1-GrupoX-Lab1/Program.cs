using System;

namespace IS1_GrupoX_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            MostrarBanner();
            MostrarAporteEstudiante2();

            Console.WriteLine();
            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }

        static void MostrarBanner()
        {
            Console.WriteLine("==========================================");
            Console.WriteLine(" IS1 - GrupoX - Laboratorio 1");
            Console.WriteLine(" Origen del Software y Control de Versiones");
            Console.WriteLine("==========================================");
            Console.WriteLine();
        }

        // ---- Estudiante 2: Manifiesto Ágil (tu parte, Emerson) ----
        static void MostrarAporteEstudiante2()
        {
            Console.WriteLine("Tema: Manifiesto Ágil");
            Console.WriteLine("Estudiante: [Tu Nombre]");
            Console.WriteLine();

            Console.WriteLine("Contexto:");
            Console.WriteLine("El Manifiesto Ágil, publicado en 2001, sentó las bases para");
            Console.WriteLine("transformar la gestión de proyectos, priorizando la adaptabilidad,");
            Console.WriteLine("las personas y la entrega de valor real.");
            Console.WriteLine();

            Console.WriteLine("--- Los 4 Valores Fundamentales ---");
            Console.WriteLine("1. Individuos e interacciones sobre procesos y herramientas.");
            Console.WriteLine("2. Software funcionando sobre documentación exhaustiva.");
            Console.WriteLine("3. Colaboración con el cliente sobre negociación contractual.");
            Console.WriteLine("4. Respuesta ante el cambio sobre seguir un plan.");
            Console.WriteLine();

            Console.WriteLine("--- Los 12 Principios Ágiles ---");
            Console.WriteLine(" 1. Satisfacción del cliente mediante entrega temprana y continua.");
            Console.WriteLine(" 2. Bienvenida al cambio, incluso en etapas tardías.");
            Console.WriteLine(" 3. Entregas frecuentes de software funcional.");
            Console.WriteLine(" 4. Trabajo en equipo diario entre negocio y desarrolladores.");
            Console.WriteLine(" 5. Individuos motivados, con entorno y apoyo adecuados.");
            Console.WriteLine(" 6. Comunicación cara a cara como método más eficiente.");
            Console.WriteLine(" 7. El software funcionando es la medida de progreso.");
            Console.WriteLine(" 8. Desarrollo sostenible, a ritmo constante.");
            Console.WriteLine(" 9. Atención continua a la excelencia técnica y buen diseño.");
            Console.WriteLine("10. Simplicidad: maximizar el trabajo NO realizado.");
            Console.WriteLine("11. Las mejores soluciones surgen de equipos autoorganizados.");
            Console.WriteLine("12. Reflexión y mejora continua a intervalos regulares.");
        }
    }
}
