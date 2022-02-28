using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BB.AdvertisementApp.Business.Interfaces;
using BB.AdvertisementApp.Common;
using BB.AdvertisementApp.Common.Enums;
using BB.AdvertisementApp.Core;
using BB.AdvertisementApp.DataAccess.UnitOfWork;
using BB.AdvertisementApp.Dtos;
using BB.AdvertisementApp.Entities;
using FluentValidation;

namespace BB.AdvertisementApp.Business.Services
{
    public class AdvertisementService : Service<AdvertisementCreateDto, AdvertisementUpdateDto, AdvertisementListDto, Advertisement> , IAdvertisementService
    {
        private readonly IUow _uow;
        private readonly IMapper _mapper;
        public AdvertisementService(IUow uow, IMapper mapper, IValidator<AdvertisementUpdateDto> updateDtoValidator, IValidator<AdvertisementCreateDto> createDtoValidator) : base(uow, mapper, updateDtoValidator, createDtoValidator)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<IResponse<List<AdvertisementListDto>>> GetActivesAsync()
        {
            var data = await _uow.GetRepository<Advertisement>().GetAllAsync(x => x.Status, x => x.CreatedDate, OrderByType.DESC);
            var dto = _mapper.Map<List<AdvertisementListDto>>(data);
            return new Response<List<AdvertisementListDto>>(ResponseType.Success, dto);

        }
    }
}
