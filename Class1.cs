using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Laba_1_Zhukov
{
    internal class People_data
    {
        public string ID;
        public string Name;
        public string Surname;
        public string Date_Of_Birth;
        public string Nationality;
        public bool sex;                        // True for man,   False for woman
        public string Date_Of_Issue;
        public string Date_Of_expire;
        public string Individual_tax_number;

        public string Passport_Expired_in()
        {
            // Преобразуем строки с датами в DateTime
            DateTime expireDate = DateTime.Parse(Date_Of_expire);
            DateTime currentDate = DateTime.Now;

            // Вычисляем разницу между датами
            TimeSpan difference = expireDate.Subtract(currentDate);

            // Возвращаем разницу в днях, часах и минутах
            return $"Passport expires in {difference.Days / 365} years";
        }

    }
}
