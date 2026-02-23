using BibliotecaApiV2.Api.Exceptions;
using BibliotecaApiV2.Core;
using BibliotecaApiV2.Core.Data;
using BibliotecaApiV2.Core.Queries;
using MediatR;

namespace BibliotecaApiV2.Handlers.Queries
{
    internal class GetAuthorByIdHandler : IRequestHandler<GetAuthorById, Author>
    {
        private readonly IAuthorRepo _authorRepo;

        public GetAuthorByIdHandler(IAuthorRepo authorRepo)
        {
            _authorRepo = authorRepo;
        }

        public async Task<Author> Handle(GetAuthorById request, CancellationToken cancellationToken)
        {
            var author = await _authorRepo.GetByIdAsync(request.Id);

            if(author == null)
                throw new NotFoundException(nameof(Author), request.Id);

            return author;
        }
    }
}
