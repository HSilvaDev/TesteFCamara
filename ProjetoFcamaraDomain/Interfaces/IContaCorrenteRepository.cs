using ProjetoFcamara.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoFcamara.Domain.Interfaces
{
    public interface IContaCorrenteRepository
    {
        string Transferir(ContaCorrente origem, ContaCorrente destino, double valor);
    }
}
