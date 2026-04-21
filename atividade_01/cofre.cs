// using System;

namespace Cofre
{

    class CofreBase
    {
        // Variaveis
        public string dono;
        private string senha;
        private bool aberto = false;
        public int numero_tentativas = 0, numero_max_tentativas = 3;

        // Metodos
        // abrir cofre
        public void Abrir(string SenhaDada)
        {
            if(senha != SenhaDada && numero_tentativas <= numero_max_tentativas) numero_tentativas++;
            if(numero_tentativas >= numero_max_tentativas){Console.Write("Cofre Bloqueado\n");}
            if(senha == SenhaDada)
            {
                aberto = true;
                numero_tentativas = 0;
            }
        }

        // alterar senha do cofre quando tiver aberto
        public void AlterarSenha(string SenhaNova, string SenhaAntiga)
        {
            if(aberto && senha == SenhaAntiga)
            {
                senha = SenhaNova;
            }
        }

        // fechar cofre
        public void Fechar()
        {
            aberto = false;
        }


        // mostrar informações do cofre
        public void Mostrar_inf()
        {
            for(int i=0;i<40;i++)Console.Write("=");Console.Write("\n");
            Console.Write($"dono: {dono}\n");
            Console.Write($"senha: {senha}\n");
            Console.Write($"aberto: {aberto}\n");
            Console.Write($"tentativas: {numero_tentativas} e o max. tentativas: {numero_max_tentativas}\n");
            for(int i=0;i<40;i++)Console.Write("=");Console.Write("\n");
        }


        public CofreBase(string donoCofre, string senhaCofre)
        {
            dono = donoCofre;
            senha = senhaCofre;
        }
    }

    public class Program
    {
        static void Main()
        {
            CofreBase cofre = new CofreBase("Junior", "1245");
            string senha, senhaAntiga, senhaNova;

            Console.Write("senha: ");
            cofre.Abrir(Console.ReadLine());//abrir cofre
            
            // redefinir senha
            Console.Write("senha antiga: "); senhaAntiga = Console.ReadLine();
            Console.Write("senha nova: "); senhaNova = Console.ReadLine();
            cofre.AlterarSenha(senhaNova, senhaAntiga);

            // testar senha
            Console.Write("senha: ");
            cofre.Abrir(Console.ReadLine());

            // mostrar informações
            cofre.Mostrar_inf();
            cofre.Fechar();
            
        }
    }
}