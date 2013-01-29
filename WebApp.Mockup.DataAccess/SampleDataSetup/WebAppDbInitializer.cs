using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Mockup.Model;

namespace WebApp.Mockup.DataAccess.SampleDataSetup
{
    public class WebAppDbInitializer : DropCreateDatabaseIfModelChanges<WebAppDBContext>
    {
        protected override void Seed(WebAppDBContext context)
        {
            AddParents(context);
            AddChildren(context);
        }

        private void AddChildren(WebAppDBContext context)
        {
            var parents = context.Parents.Select(p => p).ToList();

            parents.ForEach(parent =>
                {
                    context.Children.Add(new Child{ Parent = parent, Name = "Child of Parent: " + parent.Id.ToString(), Description = "Some Description..." });
                });
        }

        private void AddParents(WebAppDBContext context)
        {
            var parents = new List<Parent>();
            parents.Add(new Parent { Name = "Parent 1", Live = true });
            parents.Add(new Parent { Name = "Parent 2", Live = true });
            parents.Add(new Parent { Name = "Parent 3", Live = true });
            parents.Add(new Parent { Name = "Parent 4", Live = true });
            parents.Add(new Parent { Name = "Parent 5", Live = true });

            parents.ForEach(parent =>
                {
                    context.Parents.Add(parent);
                });
            context.SaveChanges();
        }
    }
}
