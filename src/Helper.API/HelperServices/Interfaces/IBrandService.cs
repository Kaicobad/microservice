using Helper.API.Models;

namespace Helper.API.HelperServices.Interfaces
{
    public interface IBrandService
    {
        IEnumerable<BrandModel> GetBrands();
        BrandModel GetBrand(int id);
        string AddBrand(BrandModel brand);
        string UpdateBrand(BrandModel brand);
        string DeleteBrand(int id);
    }
}
