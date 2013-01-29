using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Mockup.Model;

namespace WebApp.Mockup.Contracts
{
    public interface IChildRepository : IRepository<Child>
    {
        IQueryable<Child> GetByChildId(int id);
    }
}
