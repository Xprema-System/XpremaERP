using System.Threading.Tasks;
using Xprema.ERP.Models.TokenAuth;
using Xprema.ERP.Web.Controllers;
using Shouldly;
using Xunit;

namespace Xprema.ERP.Web.Tests.Controllers
{
    public class HomeController_Tests: ERPWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}