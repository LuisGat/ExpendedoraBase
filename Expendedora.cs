using System;
using System.Threading;

namespace ExpendedoraBase
{
    class Expendedora
    {
        string marca;
        byte temperatura;
        string codigo;
        float precio;

        public float Precio
        {
            get => precio;
            set
            {
                if (value >= 10 && value == 50)
                {
                    precio = value;
                }
                else
                {
                    precio = 10;
                }
            }
        }

        public Expendedora()
        { 
            Saludar();
            marca = "AMS";
            Console.WriteLine("Marca: " +marca);
            ControlarTiempoDisplay();
            temperatura = 14;
            Console.WriteLine("La temperatura es : " + temperatura + "°C");//, y + hacen lo mismo;
            ControlarTiempoDisplay();
            codigo = MostrarCodigodeProductos();
            ControlarTiempoDisplay();
            MostrarPrecio(codigo);
        }
        public Expendedora(bool soporte)
        {
            Console.WriteLine("Entrando modo soporte");
            Console.WriteLine("La temperatura actual es: ", temperatura, "°C");
        }

        void ControlarTiempoDisplay()
        {
            Thread.Sleep(2000);
            Console.Clear();
        }

        void Saludar()
        {
            Console.WriteLine("Bienvenido");
        }

        
          string MostrarCodigodeProductos()
        {
            Console.WriteLine("A1: Kinder Delice \t B2 Takis \t C3: Donitas");
            Console.WriteLine("Ingresa el codigo del producto que deseas");
            string codigo = Console.ReadLine(); // "Codigo" es una variable local
            return codigo;
        }

        void MostrarPrecio(string codigo)
        {
            Precio = 0;
            switch (codigo)
            {
                case "A1":
                    Console.WriteLine("El precio es: {0} ", Precio); 
                    break;

                case "A2":
                    Console.WriteLine("El precio es: {0} ", Precio);
                    break;
                case "A3":
                    Console.WriteLine("El precio es: {0} ", Precio);
                    break;
                default:
                    Console.WriteLine("Producto no disponible");
                    break;

            }

        }

    
    }

}
