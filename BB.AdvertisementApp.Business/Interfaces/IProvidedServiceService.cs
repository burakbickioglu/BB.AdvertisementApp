using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BB.AdvertisementApp.Dtos;
using BB.AdvertisementApp.Entities;

namespace BB.AdvertisementApp.Business.Interfaces
{
    public interface IProvidedServiceService : IService<ProvidedServiceCreateDto,ProvidedServiceUpdateDto, ProvidedServiceListDto, ProvidedService>
    {
    }
}
