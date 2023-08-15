using EasyMicroservices.Cores.Interfaces;
using System;

namespace EasyMicroservices.ActionsMicroservice.Database.Schemas
{
    public class LikeSchema : IUniqueIdentitySchema, IDateTimeSchema, ISoftDeleteSchema
    {
        public bool IsLiked { get; set; }
        public string UniqueIdentity { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime? DeletedDateTime { get; set; }
        public DateTime CreationDateTime { get; set; }
        public DateTime? ModificationDateTime { get; set; }
    }
}