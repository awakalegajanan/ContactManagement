using System;
using System.Collections.Generic;
using System.Text;

namespace OnionContactManagementSolution.Core.Interfaces
{
    public interface IContactOperations
    {
        IEnumerable<Models.Contact> GetContacts();
        Models.Contact GetContactById(int id);
        bool CreateContact(Models.Contact objContact);
        bool UpdateContact(int id, Models.Contact objContact);
        bool DeactivateContact(int id);

    }
}
