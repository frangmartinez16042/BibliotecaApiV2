using BibliotecaApiV2.Core.Dtos.Inputs;
using MediatR;

namespace BibliotecaApiV2.Core.Commands
{
    public record CreateAuthor(CreateAuthorData AuthorData) : IRequest;
}
