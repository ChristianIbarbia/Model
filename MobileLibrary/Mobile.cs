using Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MobileLibrary
{
    public class Mobile
    {
        public string name;
        public List<MobilePhone> mobilePhones = new List<MobilePhone>();

        public void AddMobilePhone(MobilePhone mobilePhone)
        {
            mobilePhones.Add(mobilePhone);
        }

        public void DisplayMobilePhoneInfo(MobilePhone mobilePhone)
        {
            Console.WriteLine("MOBILE PHONE INFORMATION in " + name + "...");
            Console.WriteLine("BRAND: " + mobilePhone.Brand);
            Console.WriteLine("MODEL: " + mobilePhone.Model);
            Console.WriteLine("PRICE: $" + mobilePhone.Price);
            Console.WriteLine("-------------------");
        }

        public void DeleteMobilePhone(MobilePhone mobilePhone)
        {
            mobilePhones.Remove(mobilePhone);
        }
    }
}
