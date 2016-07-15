using System;
using System.Collections.Generic;

namespace ContactSheet.Objects
{
  public class Address
  {
    private string _contactStreet;
    private string _contactApartment;
    private string _contactCity;
    private string _contactState;
    private string _contactZip;

    public Address(string contactStreet, string contactApartment, string contactCity, string contactState, string contactZip)
    {
      _contactStreet = contactStreet;
      _contactApartment = contactApartment;
      _contactState = contactState;
      _contactZip = contactZip;
    }

    public void SetStreet(string newStreet)
    {
      _contactStreet = newStreet;
    }
    public string GetStreet()
    {
      return _contactStreet;
    }

    public void SetApartment(string newApartment)
    {
      _contactApartment = newApartment;
    }
    public string GetApartment()
    {
      return _contactApartment;
    }

    public void SetCity(string newCity)
    {
      _contactCity = newCity;
    }
    public string GetCity()
    {
      return _contactCity;
    }

    public void SetState(string newState)
    {
      _contactState = newState;
    }
    public string GetState()
    {
      return _contactState;
    }

    public void SetZip(string newZip)
    {
      _contactZip = newZip;
    }
    public string GetZip()
    {
      return _contactZip;
    }
  }
  public class Contact
  {
//set strings, etc.
    private string _contactName;
    private string _contactPhone;
    private static List<Contact> _instances = new List<Contact> {};
//constructor
    public Contact (string contactName, string contactPhone, object contactAddress)
    {
      _contactName = contactName;
      _contactPhone = contactPhone;
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
