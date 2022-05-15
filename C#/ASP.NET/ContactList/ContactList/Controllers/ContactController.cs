using ContactList.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContactList.Controllers
{
    public class ContactController : Controller
    {
        private static int uniqueId = 0;

        // static so we don't get a new contact list whenever ContactController gets initialized
        readonly static List<Contact> contacts = new List<Contact>()
        {
            new Contact()
            {
                Id = uniqueId++,
                Name = "Katie",
                PhoneNumber = "0123456789",
                Email = "Hello@ProfessionalKate.dev",
                Website = "ProfessionalKate.dev"
            },
            new Contact()
            {
                Id = uniqueId++,
                Name = "Google",
                PhoneNumber = "0123456789",
                Email = "Google@Google.com",
                Website = "Google.com"
            }
        };

        // this dictates the http method for the endpoint
        [HttpGet]
        public IActionResult Index()
        {
            // first overload is the ViewName to look for, second is an object containing data
            return View("Index", contacts);
            // can do this OR just View(model: contacts);
        }

        // methods can have the same name if they are of different HTTP methods
        [HttpGet]
        public IActionResult Add()
        {
            return View(); // GET the view
        }

        // adds a new contact based on a custom type Contact
        [HttpPost]
        public IActionResult Add(Contact newContact)
        {
            newContact.Id = uniqueId++; // increment the ID because we've added a new contact
            contacts.Add(newContact); // POST the data back into our database
            return RedirectToAction("Index"); // use this instead of just calling Index();
        }

        // display a single contact based on a string
        [HttpGet]
        public IActionResult Details(int id)
        {
            // returns a single item or a default value (null) based on searching through the contacts list looking for where the contacts id == passed ID
            var contact = contacts.SingleOrDefault(contact => contact.Id == id); // var because type is either null or type Contact
            return View(model: contact);
        }

        // remove a contact based on a string
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var contact = contacts.SingleOrDefault(contact => contact.Id == id);
            // should check for a null return but for now it's fine, well, not "fine" but yeah... Fine.
            contacts.Remove(contact);
            return RedirectToAction("Index");
        } 
    }
}
