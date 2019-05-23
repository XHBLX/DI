using NUnit.Framework;
using System;
using Zenject;
namespace DI.Properties

{
    [TestFixture()]
    public class NUnitTestClass : UnitTestBase
    {
        protected override void SetInstallers()
        {
            installers.Add(new DIinstaller());
        }

        [Inject]
        Engineer e;

        [Test()]
        public void TestCase()
        {

            //e.WriteName();
            e = new Engineer();
            Assert.AreEqual("hi", e.getName());
        }
    }
}
