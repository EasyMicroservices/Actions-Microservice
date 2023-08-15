using EasyMicroservices.Cores.AspCoreApi;
using EasyMicroservices.Cores.Database.Interfaces;
using EasyMicroservices.ActionsMicroservice.Contracts.Common;
using EasyMicroservices.ActionsMicroservice.Database.Entities;
using EasyMicroservices.ServiceContracts;
using EasyMicroservices.Cores.Contracts.Requests;
using EasyMicroservices.ActionsMicroservice.Contracts.Requests;
using Microsoft.AspNetCore.Mvc;

namespace EasyMicroservices.ActionsMicroservice.WebApi.Controllers
{
    public class LikeController : SimpleQueryServiceController<LikeEntity, AddLikeRequestContract, UpdateLikeRequestContract, LikeContract, long>
    {
        public LikeController(IContractLogic<LikeEntity, AddLikeRequestContract, UpdateLikeRequestContract, LikeContract, long> contractReadable) : base(contractReadable)
        {

        }

        [HttpPost]
        public async Task<MessageContract<LikeContract>> ToggleLike(GetUniqueIdentityRequestContract request)
        {
            var like = await base.GetByUniqueIdentity(new GetUniqueIdentityRequestContract
            {
                UniqueIdentity = request.UniqueIdentity
            });

            if(like)
            {
                var updatedLike = await base.Update(new UpdateLikeRequestContract
                {
                    Id = like.Result.Id,
                    IsLiked = !like.Result.IsLiked,
                    UniqueIdentity = like.Result.UniqueIdentity
                });

                return updatedLike;
            }


            return (FailedReasonType.NotFound, "The like UID that you provided cannot be found.");
        }
    }
}
