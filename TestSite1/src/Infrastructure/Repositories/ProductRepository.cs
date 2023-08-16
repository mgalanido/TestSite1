using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using TestSite1.Application.Interfaces.Repositories;
using TestSite1.Domain.Entities.Catalog;

namespace TestSite1.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly IRepositoryAsync<Product, int> _repository;

        public ProductRepository(IRepositoryAsync<Product, int> repository)
        {
            _repository = repository;
        }

        public async Task<bool> IsBrandUsed(int brandId)
        {
            return await _repository.Entities.AnyAsync(b => b.BrandId == brandId);
        }
    }
}