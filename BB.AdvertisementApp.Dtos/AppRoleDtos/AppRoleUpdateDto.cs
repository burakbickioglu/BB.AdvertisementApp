using BB.AdvertisementApp.Dtos.Interfaces;

namespace BB.AdvertisementApp.Dtos
{
    public class AppRoleUpdateDto : IUpdateDto
    {
        public int Id { get; set; }
        public string Definition { get; set; }
    }
}
