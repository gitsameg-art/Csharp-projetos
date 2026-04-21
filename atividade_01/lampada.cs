using System;
using System.Reflection.Metadata;

// OBJETO LAMPADA

// using System.Reflection.Metadata;

namespace LampadaInteligente
{
    class LampadaBase
    {
        // Variaveis
        public string marca, tecnologia;
        private bool estado = false;
        private int brilho = 100;

        // Metodos

        // alterar o estado da lampada
        public void Alterar_estado(bool est)
        {
            estado = est;
        }

        // ajustar o brilho
        public void AjustarBrilho(int ajustar)
        {
            if(estado == true)brilho = ajustar;
        }

        // mostrar informações da lampada
        public void Mostrar_inf()
        {
            Console.Write($"marca: {marca}\n");
            Console.Write($"tecnologia: {tecnologia}\n");
            Console.Write($"estado: {estado}\n");
            Console.Write($"brilho: {brilho}\n");
        }

        // construtor
        public LampadaBase(string MarcaLampada, string TecnologiaLampada)
        {
            marca = MarcaLampada;
            tecnologia = TecnologiaLampada;  
        }
    }

    class Program{
        static void Main()
        {
            string esc_marca = "", esc_tecnologia = "";

                LampadaBase lampada = new LampadaBase(esc_marca, esc_tecnologia);
                
                Console.Write("Marca: ");
                lampada.marca = Console.ReadLine();
                Console.Write("tecnologia: ");
                lampada.tecnologia = Console.ReadLine();
                Console.Write("estado: ");
                // esc_estado = bool.Parse(Console.ReadLine());
                lampada.Alterar_estado(bool.Parse(Console.ReadLine()));
                Console.Write("brilho: ");
                lampada.AjustarBrilho(int.Parse(Console.ReadLine()));

                for(int i=0;i<40;i++)Console.Write("=");Console.WriteLine("\n");
                lampada.Mostrar_inf();
                for(int i=0;i<40;i++)Console.Write("=");Console.WriteLine("\n");
        }
    }
}