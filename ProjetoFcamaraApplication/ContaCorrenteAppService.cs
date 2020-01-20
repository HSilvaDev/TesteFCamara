using AutoMapper;
using ProjetoFcamara.Application.Interfaces;
using ProjetoFcamara.Application.ViewModels;
using ProjetoFcamara.Domain.Entities;
using ProjetoFcamara.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoFcamara.Application
{
    public class ContaCorrenteAppService : IContaCorrenteAppService
    {
        private readonly IMapper _mapper;
        private readonly IContaCorrenteRepository _contaCorrenteRepository;

        public ContaCorrenteAppService(IMapper mapper, IContaCorrenteRepository contaCorrenteRepository)
        {
            _mapper = mapper;
            _contaCorrenteRepository = contaCorrenteRepository;
        }

        public string Transferencia(ContaCorrenteViewModel ccOrigemVM, ContaCorrenteViewModel ccDestinoVM, double valor)
        {
            var ccOrigem = _mapper.Map<ContaCorrente>(ccOrigemVM);
            var ccDestino = _mapper.Map<ContaCorrente>(ccDestinoVM);

            return _contaCorrenteRepository.Transferir(ccOrigem, ccDestino, valor);
        }
    }
}
