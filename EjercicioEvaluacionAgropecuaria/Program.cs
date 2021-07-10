using System;
using EjercicioEvaluacionAgropecuariaML.Model;

namespace EjercicioEvaluacionAgropecuaria
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Configuraciones para darle formato al titulo
            string tituloFormateado = $"\t Ejercicio Aprendizaje Automático ";
            Console.WriteLine("\t".PadRight(tituloFormateado.Length, '='));
            Console.WriteLine(tituloFormateado);
            Console.WriteLine("\t".PadRight(tituloFormateado.Length, '='));

            //Indicación
            Console.WriteLine("\nCálculo de estatura aproximada con los parámetros edad y peso(kg).\n");

          
            var input = new ModelInput();
            string edad;
            float peso;

            // Datos de entrada
            try
            {
                do
                {
                    Console.Write("Ingrese edad: ");
                    edad = Console.ReadLine();

                } while (Convert.ToInt32(edad) <= 0);

                do
                {
                    Console.Write("Ingrese peso(kg): ");
                    peso = Convert.ToSingle(Console.ReadLine());
                } while (peso <= 0);

                input.EDAD = edad;
                input.PS82A = peso;



                // Carga del modelo y predicción de salida en base de datos de la muestra
                ModelOutput result = ConsumeModel.Predict(input);
                Console.WriteLine("\n\t**ESTATURA APROXIMADA: " + (result.Score / 100).ToString("##.##") + " metros");
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            
        }
    }
}
