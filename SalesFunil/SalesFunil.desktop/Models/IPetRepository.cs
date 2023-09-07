using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesFunil.desktop.Models {
    
    public interface IPetRepository {

        void Add(PetModel petModel);
        void Edit(PetModel petModel);   
        void Delete(PetModel petModel);
        IEnumerable<PetModel> GetAll();
        IEnumerable<PetModel> GetByValue(string value);
    }
}
