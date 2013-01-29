using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Mockup.Contracts;

namespace WebApp.Mockup.BusinessModule
{
    public class BusinessModuleManager
    {
        private readonly IUnitOfWork _context;

        public BusinessModuleManager(IUnitOfWork context)
        {
            this._context = context;
        }

        public List<ParentDto> GetAllParents()
        {
            var parentListDtos = new List<ParentDto>();
            using (var context = _context)
            {
                var parents = context.Parents.GetAll().ToList();

                parents.ForEach(p =>
                    {
                        parentListDtos.Add(new ParentDto { Name = p.Name, Live = p.Live });
                    });
            }

            return parentListDtos;
        }
    }
}
