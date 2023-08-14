using EasyMicroservices.Cores.AspCoreApi;
using EasyMicroservices.Cores.Database.Interfaces;
using EasyMicroservices.ActionsMicroservice.Contracts.Common;
using EasyMicroservices.ActionsMicroservice.Database.Entities;

namespace EasyMicroservices.ActionsMicroservice.WebApi.Controllers
{
    public class ActionController : SimpleQueryServiceController<ActionEntity, ActionContract, ActionContract, ActionContract, long>
    {
        public ActionController(IContractLogic<ActionEntity, ActionContract, ActionContract, ActionContract, long> contractReadable) : base(contractReadable)
        {

        }
    }
}
