﻿using System.Collections.Generic;
using  MicroNet.Domain;
using  MicroNet.Repository;

namespace  MicroNet.Services
{
    public class ContactService : IContactService
    {
        static long _id = long.MaxValue;
        readonly Database _database;

        public ContactService(Database database)
        {
            _database = database;
        }

        #region I MicroNetService Members

        public void AddContact(Contact contact)
        {
            //Initializing contactTosave
            contact.Id = --_id;
            _database.AddContact(contact);
        }

        public void UpdateContact(Contact contact)
        {
            _database.UpdateContact(contact);
        }

        public void DeleteContact(long id)
        {
            _database.DeleteContact(id);
        }

        public List<Contact> GetContacts()
        {
            return _database.GetContacts();
        }

        #endregion
    }
}
