using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using VendingMachineConsoleApp.Views;

namespace VendingMachineConsoleApp.Test
{
    [TestFixture]
    public class VendingMachineCliTests
    {
        private Mock<IMenuService> testMenu;
        private VendingMachineCli cli;

        [SetUp]
        public void SetUp()
        {
            testMenu = new Mock<IMenuService>();

            cli = new VendingMachineCli(testMenu.Object);
        }

    }
}
