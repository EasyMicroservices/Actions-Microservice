﻿using EasyMicroservices.Cores.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMicroservices.ActionsMicroservice.Contracts.Common
{
    public class FavoriteContract : IUniqueIdentitySchema, IDateTimeSchema, ISoftDeleteSchema
    {
        public long Id { get; set; }
        public string UniqueIdentity { get; set; }
        public DateTime CreationDateTime { get; set; }
        public DateTime? ModificationDateTime { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDateTime { get; set; }
    }
}
