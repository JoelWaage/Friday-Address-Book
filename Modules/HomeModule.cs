using Nancy;
using ContactSheet.Objects;
using System.Collections.Generic;

namespace ContactSheet
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Get["/new-contact"] = _ => {
        return View["new_contact.cshtml"];
      };
      Get["/contact-list"] = _ => {
        List<Contact> allContacts = Contact.GetAll();
        return View["contact_list.cshtml", allContacts];
      };
      Post["/name-added"] = _ => {
        Address newAddress = new Address(Request.Form["contact-street"], Request.Form["contact-apartment"], Request.Form["contact-city"], Request.Form["contact-state"], Request.Form["contact-zip"]);

        Contact newContact = new Contact(Request.Form["contact-name"], Request.Form["contact-phone"], newAddress);
        newContact.Save();
        return View["contact_created.cshtml", newAddress];
      };
      Post["/contacts-deleted"] = _ => {
        Contact.ClearAll();
        return View["contacts_deleted.cshtml"];
      };

    }
  }
}
