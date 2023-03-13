using BusinessLogic.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IProductService
    {
        public IEnumerable<ProductBL> GetAll(bool includeTobaccos);
        public Task<ProductBL> GetProduct(long id, bool includeTobbacos);
    }
}
