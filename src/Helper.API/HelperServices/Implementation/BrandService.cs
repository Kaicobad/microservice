using Helper.API.HelperServices.Interfaces;
using Helper.API.Models;
using Helper.API.Reporsitory;

namespace Helper.API.HelperServices.Implementation
{
    public class BrandService : IBrandService
    {
        private readonly IRepositoryService<BrandModel> _brandRepo;

        public BrandService(IRepositoryService<BrandModel> brandRepo)
        {
            _brandRepo = brandRepo;
        }
        public string AddBrand(BrandModel brand)
        {
            throw new NotImplementedException();
        }

        public string DeleteBrand(int id)
        {
            throw new NotImplementedException();
        }

        public BrandModel GetBrand(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BrandModel> GetBrands()
        {
            throw new NotImplementedException();
        }

        public string UpdateBrand(BrandModel brand)
        {
            throw new NotImplementedException();
        }
    }
}
