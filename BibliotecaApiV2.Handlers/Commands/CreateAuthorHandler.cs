using BibliotecaApiV2.Core;
using BibliotecaApiV2.Core.Commands;
using BibliotecaApiV2.Core.Data;
using MediatR;

namespace BibliotecaApiV2.Handlers.Commands
{
    internal class CreateAuthorHandler : IRequestHandler<CreateAuthor>
    {
        private readonly IAuthorRepo _authorRepo;

        public CreateAuthorHandler(IAuthorRepo authorRepo)
        {
            _authorRepo = authorRepo;
        }

        public async Task<Unit> Handle(CreateAuthor request, CancellationToken cancellationToken)
        {
            Author author = new Author(request.AuthorData.Name, request.AuthorData.Description);

            await _authorRepo.AddAsync(author);
            await _authorRepo.SaveChangesAsync();

            return new Unit();
        }
    }
}
