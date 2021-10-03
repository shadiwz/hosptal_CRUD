using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hosptal_CRUD.services
{
    public interface IHosptalService
    {
        List<Hosptal> Get();
        Hosptal Get(string id);
        Hosptal Create(Hosptal doctor);
        long Update(string id, Hosptal doctor);
        long Remove(string id);
    }
}
