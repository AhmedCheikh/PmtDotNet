using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wemtek.Domain.Entities;
using Wemtek.Domain.Infrastructure;

namespace Wemtek.Service.Services
{
    public class ProjectService : Service<project>, IProjectService
    {
        private static IDatabaseFactory dbf = new DatabaseFactory();
        private static IUnitOfWork ut = new UnitOfWork(dbf);

        public ProjectService():base(ut)
        {
            
        }
        public void addProject(project p)
        {
            Add(p);
            Commit();
        }
       
    }
}
