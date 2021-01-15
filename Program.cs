using System;

namespace Atributos_e_Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem avatarUm = new Personagem();

            avatarUm.nome = "Matheus";
            avatarUm.idade = 12;
            avatarUm.armadura = "Escudo";
            avatarUm.arma = "espada";

            Personagem avatarDois = new Personagem();

            avatarDois.nome = "Guilherme";
            avatarDois.idade = 14;
            avatarDois.armadura = "Barreira mágica";
            avatarDois.arma = "Arco e flecha";

            System.Console.WriteLine($"{avatarUm.nome} ataca com {avatarUm.arma} e diz '{avatarUm.Ataque()}'\n");
            
            System.Console.WriteLine($"tenho algo para você {avatarUm.nome} tome isso {avatarDois.nome} esse golpe\n");
            
            System.Console.WriteLine($"{avatarDois.nome} utiliza sua {avatarDois.armadura} para absorver o ataque sofrido...\n");
            
            System.Console.WriteLine($"e diz {avatarDois.Defender()}\n");
        
            System.Console.WriteLine($"e num contra-golpe ágil, {avatarDois.nome} utiliza seu {avatarDois.arma} para atacar {avatarUm.nome} que não consegue ativar seu {avatarUm.armadura}\n");

            System.Console.WriteLine($"Com a derrota devastadora {avatarUm.nome} só consegue esboçar as palavras {avatarUm.Derrota()}\n");

            System.Console.WriteLine($"Rindo, {avatarDois.nome} responde: {avatarDois.Vitoria()}");

            
        }
    }
}
