using CodeReviewer.Engine;
using EasyMicroservices.ActionsMicroservice.Contracts.Common;
using EasyMicroservices.ActionsMicroservice.Database.Entities;
using EasyMicroservices.ActionsMicroservice.Helpers;
using EasyMicroservices.ActionsMicroservice.WebApi.Controllers;
using EasyMicroservices.Tests;
using System;
using System.IO;
using System.Linq;

namespace EasyMicroservices.ActionsMicroservice.Tests
{
    public class CodeReviewerCheckTests : CodeReviewerTests
    {
        static CodeReviewerCheckTests()
        {
            //types to check (this will check all of types in assembly so no need to add all of types of assembly)
            AssemblyManager.AddAssemblyToReview(
                typeof(ApplicationManager),
                typeof(StartUp),
                typeof(LikeEntity),
                typeof(LikeContract),
                typeof(LikeController));
        }
    }
}