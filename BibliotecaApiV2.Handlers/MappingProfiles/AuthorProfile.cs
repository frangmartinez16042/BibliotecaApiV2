using AutoMapper;
using BibliotecaApiV2.Core;
using BibliotecaApiV2.Core.Dtos.Outputs;

namespace BibliotecaApiV2.Handlers.MappingProfiles
{
    public class AuthorProfile : Profile
    {
        public AuthorProfile()
        {
            CreateMap<Author, AuthorOutput>();
        }
    }
}
