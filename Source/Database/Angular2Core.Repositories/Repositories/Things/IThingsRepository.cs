using Angular2Core.Models;
using System.Collections.Generic;

namespace Angular2Core.Repositories.Things
{
    public interface IThingsRepository
    {
        Thing GetSingle(int id);
        Thing Add(Thing item);
        void Delete(int id);
        Thing Update(int id, Thing item);
        ICollection<Thing> GetAll();
        int Count();
    }
}
