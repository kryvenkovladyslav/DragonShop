using BusinessLogic.Models;
using System.Collections.Generic;

namespace BusinessLogic.Interfaces
{
    public interface IManufacturerService
    {
        public IEnumerable<ManufacturerBL> GetAll(bool includeTobaccos);
        public ManufacturerBL GetManufacturer(long id, bool includeTobbacos);
    }
}
