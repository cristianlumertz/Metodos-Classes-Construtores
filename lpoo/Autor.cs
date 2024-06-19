using System.Reflection.Metadata.Ecma335;

public class Autor{
    public string Nome;
    public string Nacionalidade;
    public Autor (string nome, string nacionalidade){
        Nome = nome;
        Nacionalidade = nacionalidade;
    }
    public void MostarInfo() {
        Console.WriteLine($"Nome: {Nome}, Nacionalidade: {Nacionalidade}");
    }
    
    
}
