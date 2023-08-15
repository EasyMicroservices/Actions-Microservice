using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMicroservices.ActionsMicroservice.Contracts.Requests
{
    public class AddLikeRequestContract
    {
        public string UniqueIdentity { get; set; }

        [DefaultValue(true)]
        public bool IsLiked { get; set; }
    }
}
