using ClassLibrary;
using FunctionApp;
using NUnit.Framework;

namespace NUnitTestProject
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            // F12 navigates to the source of ClassLibraryClass
            var classLibraryClass = new ClassLibraryClass();

            // F12 navigates to the metadata of FunctionAppClass
            var functionAppClass = new FunctionAppClass();

            Assert.Pass();
        }
    }
}