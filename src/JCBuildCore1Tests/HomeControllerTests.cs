using JCBuildCore1.Controllers;
using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace JCBuildCore1Tests
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public class HomeControllerTests
    {
        [Fact()]
        public void HomeIndexReturnsView() {

            // assemble
            var controller = new HomeController();

            //act
            var result = controller.Index() as ViewResult;

            //assert
            Assert.NotNull(result);

        }
    }
}
