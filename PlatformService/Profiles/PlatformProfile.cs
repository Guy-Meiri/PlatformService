using AutoMapper;
using PlatformService.Dtos;
using PlatformService.Models;

namespace PlatformService.Profiles
{
    public class PlatformProfile
    {
        public class PlatformsProfile: Profile
        {
            public PlatformsProfile()
            {
                // Source -> Target

                CreateMap<Platform, PlatformReadDto>();
                CreateMap<PlatformCreateDto, Platform>();
            }
        }
    }
}
