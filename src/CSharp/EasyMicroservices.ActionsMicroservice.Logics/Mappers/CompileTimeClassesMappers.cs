using System.Threading.Tasks;
using EasyMicroservices.Mapper.CompileTimeMapper.Interfaces;
using EasyMicroservices.Mapper.Interfaces;
using System.Linq;

namespace CompileTimeMapper
{
    public class ActionEntity_ActionContract_Mapper : IMapper
    {
        readonly IMapperProvider _mapper;
        public ActionEntity_ActionContract_Mapper(IMapperProvider mapper)
        {
            _mapper = mapper;
        }
        public global::EasyMicroservices.ActionsMicroservice.Database.Entities.ActionEntity Map(global::EasyMicroservices.ActionsMicroservice.Contracts.Common.ActionContract fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.ActionsMicroservice.Database.Entities.ActionEntity()
            {
                Id = fromObject.Id,
                Name = fromObject.Name,
                Text = fromObject.Text,
                Email = fromObject.Email,
                Website = fromObject.Website,
                CreationDateTime = fromObject.CreationDateTime,
                ModificationDateTime = fromObject.ModificationDateTime,
                IsDeleted = fromObject.IsDeleted,
                DeletedDateTime = fromObject.DeletedDateTime,
                UniqueIdentity = fromObject.UniqueIdentity
            };
            return mapped;
        }
        public global::EasyMicroservices.ActionsMicroservice.Contracts.Common.ActionContract Map(global::EasyMicroservices.ActionsMicroservice.Database.Entities.ActionEntity fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.ActionsMicroservice.Contracts.Common.ActionContract()
            {
                Id = fromObject.Id,
                Name = fromObject.Name,
                Text = fromObject.Text,
                Email = fromObject.Email,
                Website = fromObject.Website,
                CreationDateTime = fromObject.CreationDateTime,
                ModificationDateTime = fromObject.ModificationDateTime,
                IsDeleted = fromObject.IsDeleted,
                DeletedDateTime = fromObject.DeletedDateTime,
                UniqueIdentity = fromObject.UniqueIdentity
            };
            return mapped;
        }
        public async Task<global::EasyMicroservices.ActionsMicroservice.Database.Entities.ActionEntity> MapAsync(global::EasyMicroservices.ActionsMicroservice.Contracts.Common.ActionContract fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.ActionsMicroservice.Database.Entities.ActionEntity()
            {
                Id = fromObject.Id,
                Name = fromObject.Name,
                Text = fromObject.Text,
                Email = fromObject.Email,
                Website = fromObject.Website,
                CreationDateTime = fromObject.CreationDateTime,
                ModificationDateTime = fromObject.ModificationDateTime,
                IsDeleted = fromObject.IsDeleted,
                DeletedDateTime = fromObject.DeletedDateTime,
                UniqueIdentity = fromObject.UniqueIdentity
            };
            return mapped;
        }
        public async Task<global::EasyMicroservices.ActionsMicroservice.Contracts.Common.ActionContract> MapAsync(global::EasyMicroservices.ActionsMicroservice.Database.Entities.ActionEntity fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.ActionsMicroservice.Contracts.Common.ActionContract()
            {
                Id = fromObject.Id,
                Name = fromObject.Name,
                Text = fromObject.Text,
                Email = fromObject.Email,
                Website = fromObject.Website,
                CreationDateTime = fromObject.CreationDateTime,
                ModificationDateTime = fromObject.ModificationDateTime,
                IsDeleted = fromObject.IsDeleted,
                DeletedDateTime = fromObject.DeletedDateTime,
                UniqueIdentity = fromObject.UniqueIdentity

            };
            return mapped;
        }
        public object MapObject(object fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            if (fromObject.GetType() == typeof(EasyMicroservices.ActionsMicroservice.Database.Entities.ActionEntity))
                return Map((EasyMicroservices.ActionsMicroservice.Database.Entities.ActionEntity)fromObject, uniqueRecordId, language, parameters);
            return Map((EasyMicroservices.ActionsMicroservice.Contracts.Common.ActionContract)fromObject, uniqueRecordId, language, parameters);
        }
        public async Task<object> MapObjectAsync(object fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            if (fromObject.GetType() == typeof(EasyMicroservices.ActionsMicroservice.Database.Entities.ActionEntity))
                return await MapAsync((EasyMicroservices.ActionsMicroservice.Database.Entities.ActionEntity)fromObject, uniqueRecordId, language, parameters);
            return await MapAsync((EasyMicroservices.ActionsMicroservice.Contracts.Common.ActionContract)fromObject, uniqueRecordId, language, parameters);
        }
    }
}