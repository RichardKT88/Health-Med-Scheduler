﻿using AloDoutor.Application.Features.Medicos.Commands.AdicionarMedico;
using AloDoutor.Application.Features.Medicos.Commands.AtualizarMedico;
using AloDoutor.Application.Features.Medicos.Queries.ObterMedicoPorId;
using AloDoutor.Application.Features.Medicos.Queries.ObterTodosMedicos;
using AloDoutor.Application.ViewModel;
using AloDoutor.Domain.Entity;
using AutoMapper;

namespace AloDoutor.Application.MappingProfiles
{
    public class MedicoProfile : Profile
    {
        public MedicoProfile()
        {
            //Escrita
            CreateMap<MedicoDTO, Medico>().ReverseMap();
            CreateMap<AdicionarMedicoCommand, Medico>().ReverseMap();
            CreateMap<AtualizarMedicoCommand, Medico>().ReverseMap();
            CreateMap<MedicoPorIdDTO, Medico>().ReverseMap();

           // CreateMap<Medico, MedicoViewModel>();

            //CreateMap<Medico, MedicoViewModel>()
            //   .ForMember(dest => dest.agendasMedico, opt => opt.MapFrom(src => src.EspecialidadesMedicos.SelectMany(e => e.Agendamentos ?? Enumerable.Empty<Agendamento>())));

            //Leitura
           /* CreateMap<Medico, EspecialidadeMedicosViewModel>();

            //Obter todas as especialidades de um médico
            CreateMap<Medico, MedicoViewModel>()
                .ForMember(dest => dest.Especialidades, opt => opt.MapFrom(src => src.EspecialidadesMedicos!.Select(e => e.Especialidade)))
                .ForMember(dest => dest.agendasMedico, opt => opt.MapFrom(src => src.EspecialidadesMedicos!.SelectMany(a => a.Agendamentos ?? Enumerable.Empty<Agendamento>())));
           */
        }
    }
}
