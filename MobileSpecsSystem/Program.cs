using System;
using MobileLibrary;
using Model;
namespace MobileSpecsSystem

{
    public class Program
    {
        static void Main(string[] args)
        {
            Mobile myMobileLibrary = new Mobile();
            myMobileLibrary.name = "My Mobile Collection";

            MobilePhone top1MobilePhone = new MobilePhone();
            top1MobilePhone.Brand = "Realme";
            top1MobilePhone.Model = "Realme C25s";
            top1MobilePhone.Price = "7,490.00";

            MobilePhone top2MobilePhone = new MobilePhone();
            top2MobilePhone.Brand = "OPPO";
            top2MobilePhone.Model = "OPPO A16s";
            top2MobilePhone.Price = "6,999.00";

            MobilePhone top3MobilePhone = new MobilePhone();
            top3MobilePhone.Brand = "Xiaomi";
            top3MobilePhone.Model = "Xiaomi Redmi Note 11";
            top3MobilePhone.Price = "9,990.00";

            MobilePhone top4MobilePhone = new MobilePhone();
            top4MobilePhone.Brand = "POCO";
            top4MobilePhone.Model = "POCO M4 Pro 5G";
            top4MobilePhone.Price = "11,990.00";

            MobilePhone top5MobilePhone = new MobilePhone
            {
                Brand = "Samsung",
                Model = "Galaxy S21(128GB)",
                Price = "44,990.00"
            };

            myMobileLibrary.AddMobilePhone(top1MobilePhone);
            myMobileLibrary.AddMobilePhone(top2MobilePhone);
            myMobileLibrary.AddMobilePhone(top3MobilePhone);
            myMobileLibrary.AddMobilePhone(top4MobilePhone);
            myMobileLibrary.AddMobilePhone(top5MobilePhone);

            foreach (var phone in myMobileLibrary.mobilePhones)
            {
                myMobileLibrary.DisplayMobilePhoneInfo(phone);
            }
        }

    }
    }

