using System;
using System.Collections.Generic;

namespace PruebaRawson
{
    public class Program
    {
        public string identificacion;
        public string nombres;
        public string apellidos;
        public DateTime FechaNacimiento;
        public static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>();
            personas.Add(new Persona() { Identificacion ="79658321",Nombres= "Pedro Estiven",Apellidos= "Gil Barón", Fecha_Nmto = new DateTime(1979,10, 26) });
            personas.Add(new Persona() { Identificacion ="4158232", Nombres = "Ana María", Apellidos = "López Torres", Fecha_Nmto = new DateTime(1954, 8, 12) });
            personas.Add(new Persona() { Identificacion ="84632206", Nombres = "Eugenio", Apellidos = "Joya Rivera", Fecha_Nmto = new DateTime(1984, 5, 17) });
            personas.Add(new Persona() { Identificacion ="7456977", Nombres = "Carol Johanna", Apellidos = "Pérez Castro", Fecha_Nmto = new DateTime(1975, 2,5) });
            personas.Add(new Persona() { Identificacion = "15608542", Nombres = "Pablo Raúl", Apellidos = "Téllez Sánchez", Fecha_Nmto = new DateTime(1949, 1,19) });
            ProcesarPersona(personas);
        }
        
        private static void ProcesarPersona(List<Persona> personas)
        {
            double Resultado1 = 0;
            double Resultado2 = 0;
            double valor = 0;
            DateTime fechaActual = new DateTime(2018, 3, 23);
            foreach (Persona p in personas)
            {
                valor = CalcularEdad(p.Fecha_Nmto, fechaActual);
                if (valor > Resultado1) 
                { 
                    Resultado1 = Convert.ToDouble(valor); 
                }
                Resultado2 = Resultado2 + Convert.ToDouble(valor);
                    Console.WriteLine("Identificación: {0} Nombres: {1} Apellidos: {2} Edad:{3}",p.Identificacion,p.Nombres,p.Apellidos,CalcularEdad(p.Fecha_Nmto,fechaActual)
            );
            }
            Resultado2 = Resultado2 / Convert.ToDouble(personas.Count);
            string result = "Resultado 1:" +Resultado1 + "Resultado 2:" +Resultado2;
            
        }
        public static Double CalcularEdad(DateTime fechaNacimiento, DateTime fechaActual )
        {
            // Obtiene la fecha actual:
            //DateTime fechaActual = DateTime.Today;

            // Comprueba que la se haya introducido una fecha válida; si 
            // la fecha de nacimiento es mayor a la fecha actual se muestra mensaje 
            // de advertencia:
            if (fechaNacimiento > fechaActual)
            {
                Console.WriteLine("La fecha de nacimiento es mayor que la actual.");
                return -1;
            }
            else
            {
                double edad = fechaActual.Year - fechaNacimiento.Year;

                // Comprueba que el mes de la fecha de nacimiento es mayor 
                // que el mes de la fecha actual:
                if (fechaNacimiento.Month > fechaActual.Month)
                {
                    --edad;
                }

                return edad;
            }

        }

    public class Persona
    {
        public string Identificacion { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime Fecha_Nmto { get; set; }
        }
    }
}
