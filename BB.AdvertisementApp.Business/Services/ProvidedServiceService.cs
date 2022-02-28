using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BB.AdvertisementApp.Business.Interfaces;
using BB.AdvertisementApp.DataAccess.UnitOfWork;
using BB.AdvertisementApp.Dtos;
using BB.AdvertisementApp.Entities;
using FluentValidation;

namespace BB.AdvertisementApp.Business.Services
{
    public class ProvidedServiceService : Service<ProvidedServiceCreateDto, ProvidedServiceUpdateDto, ProvidedServiceListDto, ProvidedService>,IProvidedServiceService
    {
        public ProvidedServiceService(IUow uow, IMapper mapper, IValidator<ProvidedServiceUpdateDto> updateDtoValidator, IValidator<ProvidedServiceCreateDto> createDtoValidator) : base(uow, mapper, updateDtoValidator, createDtoValidator)
        {
        }
    }
}
