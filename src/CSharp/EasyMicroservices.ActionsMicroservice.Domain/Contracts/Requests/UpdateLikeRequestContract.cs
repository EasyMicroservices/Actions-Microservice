using EasyMicroservices.Cores.Database.Interfaces;
using EasyMicroservices.Cores.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMicroservices.ActionsMicroservice.Contracts.Requests
{
    public class UpdateLikeRequestContract : IUniqueIdentitySchema
    {
        public long Id { get; set; }
        public bool IsLiked { get; set; }
        public string UniqueIdentity { get; set; }
    }
}
