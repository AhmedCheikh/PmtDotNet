using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wemtek.Domain.Entities;
using Wemtek.Domain.Infrastructure;

namespace Wemtek.Service.Services
{
    public class DocumentService : Service<document>, IDocumentService
    {
        private static IDatabaseFactory dbf = new DatabaseFactory();
        private static IUnitOfWork ut = new UnitOfWork(dbf);

        public DocumentService()
            : base(ut)
        {
        }

    }
}
