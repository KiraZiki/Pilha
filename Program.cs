static void Main(string[] args)
{
    Pilha pilha = new Pilha();

    // Criar documentos
    Documento doc1 = new Documento("arquivo1", "txt", 12);
    Documento doc2 = new Documento("arquivo2", "doc", 7);
    Documento doc3 = new Documento("arquivo3", "pdf", 10);

    // Operações de push
    pilha.push(doc1);
    pilha.push(doc2);
    pilha.push(doc3);

    // Imprimir documentos na pilha
    pilha.imprimir();

    // Consulta por nome de arquivo
    bool encontrado = pilha.consulta("arquivo2");
    Console.WriteLine($"Arquivo encontrado: {encontrado}");

    // Pop e imprimir novamente
    Documento removido = pilha.pop();
    Console.WriteLine($"Removido: {removido.nomeDoArquivo}");
    pilha.imprimir();
}
