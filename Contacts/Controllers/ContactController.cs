using Contacts.Models;
using Contacts.Services;
using Microsoft.AspNetCore.Mvc;


namespace Contacts.Controllers
{
    public class ContactController : Controller
    {
        private ContactRepository _contactRepository;

        public ContactController()
        {
            this._contactRepository = new ContactRepository();
        }
        public Contact[] Index()
        {
            return ContactRepository.GetAllContacts();
        }
    }
}
