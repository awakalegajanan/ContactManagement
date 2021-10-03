using Microsoft.EntityFrameworkCore;
using OnionContactManagementSolution.Core.Interfaces;
using OnionContactManagementSolution.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnionContactManagementSolution.Application
{
    public class ContactOperations : IContactOperations
    {
        private IApplicationDbContext _dbcontext;
        public ContactOperations(IApplicationDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public bool CreateContact(Contact objContact)
        {        
            try
            {
                _dbcontext.Contacts.Add(objContact);                              
                _dbcontext.SaveChanges();
                return true;
            }
            catch
            {

                return false;
            }            
        }

        public bool DeactivateContact(int id)
        {
            try
            {
              var contct = _dbcontext.Contacts.SingleOrDefault(a => a.CustId == id);
                if (contct != null)
                {
                    contct.Status = contct.Status == "A" ? "N" : "A";
                    _dbcontext.Contacts.Update(contct);
                    _dbcontext.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch
            {

                return false;
            }
        }

        public Contact GetContactById(int id)
        {
            return _dbcontext.Contacts.SingleOrDefault(a => a.CustId == id);
        }

        public IEnumerable<Contact> GetContacts()
        {
            return _dbcontext.Contacts.Where(a => a.Status == "A");
        }

        public bool UpdateContact(int id, Contact objContact)
        {
            var contact = _dbcontext.Contacts.SingleOrDefault(a => a.CustId == id);
            if (contact !=null)
            {
                contact.FirstName = objContact.FirstName;
                contact.LastName = objContact.LastName;
                contact.Email = objContact.Email;
                contact.PhoneNumber = objContact.PhoneNumber;
                contact.Status = objContact.Status;

                _dbcontext.Contacts.Update(contact);
                _dbcontext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
