using System;


namespace ExpendedoraBase
{
    class Program
    {
        static void Main(string[] args)
        {
            Expendedora miExpendedora = new Expendedora();
            Console.WriteLine("¿Quieres entrar a modo soporte? (S/N)");
            char respuesta = Convert.ToChar(Console.ReadLine());
            if (respuesta=='S'||respuesta=='s')
            {
                miExpendedora = new Expendedora(true);
            }
            Console.ReadLine();
        }
    }
}
