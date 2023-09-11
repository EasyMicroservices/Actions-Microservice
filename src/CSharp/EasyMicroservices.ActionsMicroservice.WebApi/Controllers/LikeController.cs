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
        public async Task<MessageContract> Like(GetUniqueIdentityRequestContract request)
        {
            var like = await base.GetByUniqueIdentity(new GetUniqueIdentityRequestContract
            {
                UniqueIdentity = request.UniqueIdentity
            });

            if(!like)
            {
                var addedLike = await base.Add(new AddLikeRequestContract
                {
                    UniqueIdentity = request.UniqueIdentity,
                    IsLiked = true,
                });

                return addedLike.IsSuccess;
            }

            if (!like.Result.IsLiked)
            {
                var updatedLike = await base.Update(new UpdateLikeRequestContract
                {
                    Id = like.Result.Id,
                    IsLiked = true,
                    UniqueIdentity = like.Result.UniqueIdentity
                });

                return updatedLike.IsSuccess;
            }

            var deletedLike = await base.HardDeleteById(new DeleteRequestContract<long>
            {
                Id = like.Result.Id
            });

            return deletedLike.IsSuccess;
        }

        [HttpPost]
        public async Task<MessageContract> Dislike(GetUniqueIdentityRequestContract request)
        {
            var like = await base.GetByUniqueIdentity(new GetUniqueIdentityRequestContract
            {
                UniqueIdentity = request.UniqueIdentity
            });

            if(!like)
            {
                var addedLike = await base.Add(new AddLikeRequestContract
                {
                    UniqueIdentity = request.UniqueIdentity,
                    IsLiked = false,
                });

                return addedLike.IsSuccess;
            }

            if (like.Result.IsLiked)
            {
                var updatedLike = await base.Update(new UpdateLikeRequestContract
                {
                    Id = like.Result.Id,
                    IsLiked = false,
                    UniqueIdentity = like.Result.UniqueIdentity
                });

                return updatedLike.IsSuccess;
            }

            var deletedLike = await base.HardDeleteById(new DeleteRequestContract<long>
            {
                Id = like.Result.Id
            });

            return deletedLike.IsSuccess;

        }

        [HttpPost]
        public async Task<MessageContract<GetLikesByStatusResponse>> GetLikesByStatus(GetLikesRequestContract request)
        {
            var likes = await base.GetAllByUniqueIdentity(new GetUniqueIdentityRequestContract
            {
                UniqueIdentity = request.UniqueIdentity
            });

            if(likes.IsSuccess)
            {
                var count = likes.Result.Count(o => o.IsLiked == request.IsLiked);
                return new GetLikesByStatusResponse
                {
                    Count = count
                };
            }

            return (FailedReasonType.NotFound, "Provided UID cannot be found.");

        }
    }
}
