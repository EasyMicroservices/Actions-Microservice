using EasyMicroservices.Cores.AspCoreApi;
using EasyMicroservices.Cores.Database.Interfaces;
using EasyMicroservices.ActionsMicroservice.Contracts.Common;
using EasyMicroservices.ActionsMicroservice.Database.Entities;
using EasyMicroservices.ServiceContracts;
using EasyMicroservices.Cores.Contracts.Requests;
using EasyMicroservices.ActionsMicroservice.Contracts.Requests;
using EasyMicroservices.Cores.AspEntityFrameworkCoreApi.Interfaces;

namespace EasyMicroservices.ActionsMicroservice.WebApi.Controllers
{
    public class ViewController : SimpleQueryServiceController<ViewEntity, AddViewRequestContract, ViewContract, ViewContract, long>
    {
        private readonly IUnitOfWork _unitOfWork;

        public ViewController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
