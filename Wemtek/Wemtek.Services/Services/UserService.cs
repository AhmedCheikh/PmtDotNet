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
    public class UserService : Service<user>, IUserService
    {
        private static IDatabaseFactory dbf = new DatabaseFactory();
        private static IUnitOfWork ut = new UnitOfWork(dbf);
        
        public UserService()
            : base(ut)
        { 
        }


    }
}
