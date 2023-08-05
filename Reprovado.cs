using System;

namespace CursoDesignPatterns
{
    public class Reprovado : EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamentos reprovados não recebem desconto extra.");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento em estado reprovado.");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já reprovado, não seria possível reprová-lo novamente.");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }
    }
}