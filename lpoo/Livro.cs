using System.Security.Cryptography.X509Certificates;

public class Livro{
    public string Titulo;
    public Autor Autor;
    public double Preco;
    public Livro(string titulo, Autor autor){
        Titulo = titulo;
        Autor = autor;
    }
    public Livro(string titulo, Autor autor, double preco){
        Titulo = titulo;
        Autor = autor;
        Preco = preco;
    }
    public void MostarInfo(){
        Console.WriteLine($"Titulo: {Titulo}, Autor: {Autor.Nome}, Preco: {Preco}");
    }
    public void AplicarDesconto(double PorcertagemDesconto){
        Preco -= Preco * (PorcertagemDesconto/100);
    }
    public void AplicarDesconto(int FixoDesconto){
        Preco -= FixoDesconto;    
    }
}