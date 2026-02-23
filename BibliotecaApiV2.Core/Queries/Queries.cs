using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApiV2.Core.Queries
{
    public record GetAuthorById(string Id) : IRequest<Author>;
}
