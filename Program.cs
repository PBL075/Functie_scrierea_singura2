using System;

namespace ss_functie
{
    class Program
    {
        static void Main()
        {
         Materia("Mate",6 ,7);
         Materia("Fizica",6 ,6);
         Materia("Romana",7 ,8);

        }
        static void Materia (string lectie , double nota1 , double nota2)
        {
            double Medie =(nota1 + nota2)/2;

            Console.WriteLine("Lectia: " + lectie);
            Console.WriteLine("Media: " + Medie);
        }
    }
}