using NUnit.Framework;
using Moq;
using OnionContactManagementSolution.Core.Interfaces;
using OnionContactManagementSolution.Core.Models;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    [TestFixture]
    public class TestsClass
    {
        private IContactOperations GetMockContactService()
        {
            Mock<IContactOperations> mockObject = new Mock<IContactOperations>();
            Mock<Contact> mockContact = new Mock<Contact>();
            Mock<List<Contact>> mockContacts = new Mock<List<Contact>>();
            mockObject.Setup(m => m.CreateContact(mockContact.Object)).Returns(true);
            mockObject.Setup(m => m.UpdateContact(0, mockContact.Object)).Returns(true);
            mockObject.Setup(m => m.GetContacts()).Returns(mockContacts.Object);
            mockObject.Setup(m => m.GetContactById(0)).Returns(mockContact.Object);
            return mockObject.Object;
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            IContactOperations operations = this.GetMockContactService();

            var actualResult = operations.GetContacts();           
            int expectedResult = 0;
            Assert.AreEqual(expectedResult, actualResult.Count());
        }
    }
}