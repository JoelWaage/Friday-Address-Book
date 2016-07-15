using System;
using System.Collections.Generic;

namespace ContactSheet.Objects
{
  public class Contact
  {
//set strings, etc.
    private string _contactName;
    private string _contactPhone;
    private string _contactAddress;
    private static List<Contact> _instances = new List<Contact> {};
//constructor
    public Contact (string contactName, string contactPhone, string contactAddress)
    {
      _contactName = contactName;
      _contactPhone = contactPhone;
      _contactAddress = contactAddress;
    }
//getters and setters
    public void SetName(string newName)
      {
        _contactName = newName;
      }
    public string GetName()
    {
      return _contactName;
    }

    public void SetPhone(string newPhone)
    {
      _contactPhone = newPhone;
    }
    public string GetPhone()
    {
      return _contactPhone;
    }

    public void SetAddress(string newAddress)
    {
      _contactAddress = newAddress;
    }
    public string GetAddress()
    {
      return _contactAddress;
    }

    public static List<Contact> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(this);
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

  }
}
