using System.Threading.Tasks;
using TestSite1.Application.Features.Documents.Commands.AddEdit;
using TestSite1.Application.Features.Documents.Queries.GetAll;
using TestSite1.Application.Features.Documents.Queries.GetById;
using TestSite1.Application.Requests.Documents;
using TestSite1.Shared.Wrapper;

namespace TestSite1.Client.Infrastructure.Managers.Misc.Document
{
    public interface IDocumentManager : IManager
    {
        Task<PaginatedResult<GetAllDocumentsResponse>> GetAllAsync(GetAllPagedDocumentsRequest request);

        Task<IResult<GetDocumentByIdResponse>> GetByIdAsync(GetDocumentByIdQuery request);

        Task<IResult<int>> SaveAsync(AddEditDocumentCommand request);

        Task<IResult<int>> DeleteAsync(int id);
    }
}