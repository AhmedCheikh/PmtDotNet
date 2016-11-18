using Wemtek.Domain.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wemtek.Domain.Entities;
using Wemtek.Domain.Models;

namespace Wemtek.Domain.Infrastructure
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private wemtekdbContext dataContext;
        public wemtekdbContext DataContext { get { return dataContext; } }
         
        public DatabaseFactory()
        {
            dataContext = new wemtekdbContext();
        }
        protected override void DisposeCore()
        {
            if (DataContext != null)
                DataContext.Dispose();
        }
    }

}
