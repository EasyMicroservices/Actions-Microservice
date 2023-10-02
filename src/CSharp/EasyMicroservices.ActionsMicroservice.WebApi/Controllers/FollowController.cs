using EasyMicroservices.Cores.AspCoreApi;
using EasyMicroservices.Cores.Database.Interfaces;
using EasyMicroservices.ActionsMicroservice.Contracts.Common;
using EasyMicroservices.ActionsMicroservice.Database.Entities;
using EasyMicroservices.ServiceContracts;
using EasyMicroservices.Cores.Contracts.Requests;
using EasyMicroservices.ActionsMicroservice.Contracts.Requests;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using EasyMicroservices.Cores.DataTypes;
using EasyMicroservices.Cores.AspEntityFrameworkCoreApi.Interfaces;

namespace EasyMicroservices.ActionsMicroservice.WebApi.Controllers
{
    public class FollowController : SimpleQueryServiceController<FollowEntity, GetUniqueIdentityRequestContract, FollowContract, FollowContract, long>
    {
        private readonly IUnitOfWork _unitOfWork;

        public FollowController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<MessageContract> ToggleFollow(GetUniqueIdentityRequestContract request)
        {

            var followStatus = await base.GetByUniqueIdentity(request);
            if (!followStatus)
                return await base.Add(request);

            FollowContract currentRow = await base.GetByUniqueIdentity(request);

            return await base.SoftDeleteById(currentRow.Id);
        }

    }
}
