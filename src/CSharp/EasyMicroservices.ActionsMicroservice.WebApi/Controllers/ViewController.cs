using EasyMicroservices.Cores.AspCoreApi;
using EasyMicroservices.Cores.Database.Interfaces;
using EasyMicroservices.ActionsMicroservice.Contracts.Common;
using EasyMicroservices.ActionsMicroservice.Database.Entities;
using EasyMicroservices.ServiceContracts;
using EasyMicroservices.Cores.Contracts.Requests;
using EasyMicroservices.ActionsMicroservice.Contracts.Requests;

namespace EasyMicroservices.ActionsMicroservice.WebApi.Controllers
{
    public class ActionController : SimpleQueryServiceController<ViewEntity, AddViewRequestContract, ViewContract, ViewContract, long>
    {
        public ActionController(IContractLogic<ViewEntity, AddViewRequestContract, ViewContract, ViewContract, long> contractReadable) : base(contractReadable)
        {

        }
    }
}
