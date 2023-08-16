using TestSite1.Application.Interfaces.Repositories;
using TestSite1.Domain.Entities.Catalog;

namespace TestSite1.Infrastructure.Repositories
{
    public class BrandRepository : IBrandRepository
    {
        private readonly IRepositoryAsync<Brand, int> _repository;

        public BrandRepository(IRepositoryAsync<Brand, int> repository)
        {
            _repository = repository;
        }
    }
}