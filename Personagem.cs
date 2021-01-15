namespace Atributos_e_Metodos
{
    public class Personagem
    {
        public string nome;
        public int idade;
        public string armadura;
        public string arma;

        public string Ataque(){

            return "Sinta minha fúria"; 
        }

        public string Defender(){
            return "'Você é fraco'";
        }

        public string Derrota(){
            return "'eu falhei'";
        }

        public string Vitoria(){
            return "'já era de se esperar alguém fraco como você jamais me venceria'";
        }
    }
}