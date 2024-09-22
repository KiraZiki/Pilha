public class Documento
{
    public string nomeDoArquivo { get; set; }
    public string extensaoDoArquivo { get; set; }
    public int tamanhoDoArquivo { get; set; }

    public Documento(string nomeDoArquivo, string extensaoDoArquivo, int tamanhoDoArquivo)
    {
        this.nomeDoArquivo = nomeDoArquivo;
        this.extensaoDoArquivo = extensaoDoArquivo;
        this.tamanhoDoArquivo = tamanhoDoArquivo;
    }

    // Método para imprimir os dados do documento
    public void imprimir()
    {
        Console.WriteLine($"Nome: {nomeDoArquivo}, Extensão: {extensaoDoArquivo}, Tamanho: {tamanhoDoArquivo}KB");
    }
}


public class No
{
    public Documento documento;
    public No prox;

    public No(Documento doc)
    {
        this.documento = doc;
        this.prox = null;
    }
}
