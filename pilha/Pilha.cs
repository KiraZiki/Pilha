public class Pilha
{
    public No topo;

    public Pilha()
    {
        this.topo = null;
    }

    public Boolean estaVazia()
    {
        return this.topo == null;
    }

    // a) PUSH
    public void push(Documento doc)
    {
        No novoNo = new No(doc);
        if (this.estaVazia())
        {
            this.topo = novoNo;
        }
        else
        {
            novoNo.prox = this.topo;
            this.topo = novoNo;
        }
    }

    // b) POP
    public Documento pop()
    {
        if (this.estaVazia())
        {
            return null;
        }
        else
        {
            Documento doc = this.topo.documento;
            this.topo = this.topo.prox;
            return doc;
        }
    }

    // c) Consulta
    public Boolean consulta(string nomeDoArquivo)
    {
        No atual = this.topo;
        while (atual != null)
        {
            if (atual.documento.nomeDoArquivo == nomeDoArquivo)
            {
                return true;
            }
            atual = atual.prox;
        }
        return false;
    }

    // d) Impressão
    public void imprimir()
    {
        No atual = this.topo;
        Console.WriteLine("Documentos na Pilha:");
        while (atual != null)
        {
            atual.documento.imprimir();
            atual = atual.prox;
        }
    }

    public int contarElementos()
    {
        No atual = this.topo;
        int contador = 0;
        while (atual != null){
            contador++;
            atual = atual.prox;
        }
        return contador;
    }

    public int contarImpares()
    {
        No atual = this.topo;
        int contador = 0;
        while (atual != null)
        {
            if (atual.documento.tamanhoDoArquivo % 2 != 0)
            {
                contador++;
            }
            atual = atual.prox;
        }
        return contador;
    }

    public void dividirPosNeg(Pilha pilha2, Pilha pilha3)
    {
        No atual = this.topo;
        while (atual != null)
        {
            if (atual.documento.tamanhoDoArquivo >= 0)
            {
                pilha2.push(atual.documento);
            }
            else
            {
                pilha3.push(atual.documento);
            }
            atual = atual.prox;
        }
    }

    public void inverterPilha(Pilha pilhaInvertida)
    {
        No atual = this.topo;
        while (atual != null)
        {
            pilhaInvertida.push(atual.documento);
            atual = atual.prox;
        }
    }

    public bool ehPalindromo()
    {
        Pilha pilhaAux = new Pilha();
        No atual = this.topo;

        // Copiar os elementos para uma pilha auxiliar
        while (atual != null)
        {
            pilhaAux.push(atual.documento);
            atual = atual.prox;
        }

        // Comparar a pilha original com a auxiliar
        atual = this.topo;
        No atualAux = pilhaAux.topo;

        while (atual != null)
        {
            if (atual.documento.nomeDoArquivo != atualAux.documento.nomeDoArquivo)
            {
                return false;
            }
            atual = atual.prox;
            atualAux = atualAux.prox;
        }
        return true;
    }
    
    public void transferirElementos(Pilha pilha2)
    {
        Pilha pilhaAux = new Pilha();

        // Transferir para pilha auxiliar para manter a ordem
        while (!this.estaVazia())
        {
            pilhaAux.push(this.pop());
        }

        // Transferir da pilha auxiliar para a pilha destino
        while (!pilhaAux.estaVazia())
        {
            pilha2.push(pilhaAux.pop());
        }
    }

    
}