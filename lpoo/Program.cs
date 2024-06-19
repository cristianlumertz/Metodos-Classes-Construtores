class Program {
    static void Main () {
        Autor autor1 = new Autor("Cristian", "Brasileiro");
        autor1.MostarInfo();
    
        Livro livro1 = new Livro("Livro 1", autor1, 90);
        livro1.MostarInfo();

        livro1.AplicarDesconto(10);
        livro1.MostarInfo();
    }
}