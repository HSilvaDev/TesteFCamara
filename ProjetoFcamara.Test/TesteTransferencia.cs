using ProjetoFcamara.Domain.Entities;
using System;
using Xunit;

namespace ProjetoFcamara.Test
{
    public class TesteTransferencia
    {
        [Theory]
        [InlineData(500,500)]
        [InlineData(500, 1500)]
        [InlineData(0, 10)]
        [InlineData(500, 0)]
        public void TesteDeTransferenciaEntreContas(double saldo, double valor)
        {
            ContaCorrente CcOrigem = new ContaCorrente(1,"Cliente A", saldo);
            ContaCorrente CcDestino = new ContaCorrente(1, "Cliente B", saldo);

            Assert.True(CcOrigem.Sacar(valor) && CcDestino.Depositar(valor));
        }
    }
}
