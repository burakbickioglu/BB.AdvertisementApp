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
    public class GenderService : Service<GenderCreateDto, GenderUpdateDto, GenderListDto, Gender>,IGenderService
    {
        public GenderService(IUow uow, IMapper mapper, IValidator<GenderUpdateDto> updateDtoValidator, IValidator<GenderCreateDto> createDtoValidator) : base(uow, mapper, updateDtoValidator, createDtoValidator)
        {
        }
    }
}
