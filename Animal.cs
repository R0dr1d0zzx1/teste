public abstract class Animal
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Animal(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public abstract String EmitirSom();



}
 public class Leão : Mamifero
    {
        public int TamanhoDoGrupo;

        public override String EmitirSom(){
            return "rrraawwwwwwrrrrr";
        }

    }

    public class Cobra : Reptil
    {
        public double Comprimento;

        public override void EmitirSom(){
            return "ssshhhhhhhsssss";
        }

        



    }