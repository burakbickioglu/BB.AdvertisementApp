using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BB.AdvertisementApp.Dtos.Interfaces;

namespace BB.AdvertisementApp.Dtos
{
    public class AppRoleCreateDto : IDto
    {
        public int Id { get; set; }
        public string Definition { get; set; }
    }
}
