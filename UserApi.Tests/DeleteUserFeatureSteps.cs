using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;
using TechTalk.SpecFlow;
using UserApi.Api.Controllers;
using UserApi.Data.Interfaces;

namespace UserApi.Tests
{
    [Binding]
    public class DeleteUserFeatureSteps
    {
        ScenarioContext context = ScenarioContext.Current;

        [When(@"I request to delete the user by Id")]
        public void WhenIRequestToDeleteTheUserById()
        {
            UsersController usersController = context.Get<UsersController>();
            var response = usersController.DeleteUser(1);
            context.Set(response);
        }

        [Then(@"the user should be deleted")]
        public void ThenTheUserShouldBeDeleted()
        {
            var repository = context.Get<IUsersRepository>();
            Assert.IsTrue(repository.GetById(1) == null);
        }

    }
}
