using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wemtek.Domain.Models;
using Wemtek.Domain.Entities;


namespace Wemtek.Domain.Infrastructure
{
    public interface IDatabaseFactory : IDisposable
    { 
        wemtekdbContext DataContext { get; }
    }

}
