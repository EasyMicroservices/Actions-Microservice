using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMicroservices.ActionsMicroservice.Contracts.Requests
{
    public class GetLikesRequestContract
    {
        public string UniqueIdentity { get; set; }
        public bool IsLiked { get; set; }
    }
}
