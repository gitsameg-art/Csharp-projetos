// using System;

namespace PersonagemRPG
{
    class PersonagemBase
    {
        public string nome, classe;
        private int nivel = 1, vida, max_vida;

        public void receberDano(int pontos)
        {
            if(vida > 0)
            {
                vida -= pontos;
            }
        }

        public void curar(int pontos)
        {
            for(int i = 0; i < pontos; i++)
            {   
                if(vida >= max_vida)break;
                vida ++;
            }
        }

        public void subirNivel()
        {
            nivel++;
            max_vida += Convert.ToInt32(0.1*max_vida);
            vida = max_vida;
        }

        public void Mostrar_inf()
        {
            for(int i=0;i<40;i++)Console.Write("=");Console.Write("\n");
            Console.WriteLine($"{nome} {classe} - lvl {nivel} - HP: {vida}/{max_vida}");
            for(int i=0;i<40;i++)Console.Write("=");Console.Write("\n");
        }

        public PersonagemBase(string nomePersonagem, string classePersonagem){
            nome = nomePersonagem;
            classe = classePersonagem;

            switch (classePersonagem)
            {
                case "Guerreiro": vida = 150; max_vida = 150;break;
                case "Mago": vida = 80; max_vida = 80;break;
                default: Console.WriteLine("não tem essa classe");break;
            }
        }
    }

    public class Program
    {
        static void Main()
        {
            PersonagemBase player = new PersonagemBase("Caio", "Guerreiro");
            Console.Write("dano: ");player.receberDano(int.Parse(Console.ReadLine()));
            Console.Write("cura: ");player.curar(int.Parse(Console.ReadLine()));
            player.Mostrar_inf();
            player.subirNivel();
            player.Mostrar_inf();
        }
    }
}