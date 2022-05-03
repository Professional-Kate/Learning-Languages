using Microsoft.AspNetCore.Mvc;

namespace ContactList.Controllers
{
    public class ContactController : Controller
    {
        // static so we don't get a new contact list whenever ContactController gets initialized
        readonly static List<string> contacts = new List<string>()
        {
            "Katie", 
            "Sock",
            "Saida",
            "Teamaren",
            "Tobi",
            "Lewis"
        };

        // this dictates the method the page would use
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

        [HttpPost]
        public IActionResult Add(string newContact)
        {
            contacts.Add(newContact); // POST the data back into our database
            return RedirectToAction("Index"); // use this instead of just calling Index();
        }
    }
}
