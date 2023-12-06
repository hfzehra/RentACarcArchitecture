using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tobeto.Core.Persistance.Repositories;

namespace Domain.Entity
{
    //CQRS
    public class Brand :Entity<Guid>
    {
        //persistance -> kalıcı hale getirme
        public string Name { get; set; }
    }
}
