using EasyMicroservices.ActionsMicroservice.Database.Schemas;
using EasyMicroservices.Cores.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMicroservices.ActionsMicroservice.Database.Entities
{
    public class FavoriteEntity : FavoriteSchema, IIdSchema<long>
    {
        public long Id { get; set; }
    }
}
