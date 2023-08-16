﻿using System.Collections.Generic;
using System.Threading.Tasks;
using TestSite1.Application.Features.DocumentTypes.Commands.AddEdit;
using TestSite1.Application.Features.DocumentTypes.Queries.GetAll;
using TestSite1.Shared.Wrapper;

namespace TestSite1.Client.Infrastructure.Managers.Misc.DocumentType
{
    public interface IDocumentTypeManager : IManager
    {
        Task<IResult<List<GetAllDocumentTypesResponse>>> GetAllAsync();

        Task<IResult<int>> SaveAsync(AddEditDocumentTypeCommand request);

        Task<IResult<int>> DeleteAsync(int id);

        Task<IResult<string>> ExportToExcelAsync(string searchString = "");
    }
}