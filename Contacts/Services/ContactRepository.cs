using Contacts.Models;

namespace Contacts.Services;

public class ContactRepository
{
    public static Contact[] GetAllContacts()
    {
        return new Contact[]
        {
            new Contact
            {
                Id = 1,
                Name = "Glenn Block"
            },
            new Contact
            {
                Id = 2,
                Name = "Dan Roth"
            }
        };
    }
}