﻿using MediatR;

namespace AloDoutor.Application.Features.Medicos.Commands.AtualizarMedico
{
    public class AtualizarMedicoCommand : IRequest<Guid>
    {
        public Guid Id { get; set; }
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public string? Cep { get; set; }
        public string? Endereco { get; set; }
        public string? Estado { get; set; }
        public string? Crm { get; set; }
        public string? Telefone { get; set; }

    }
}
