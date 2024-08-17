using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_1_Zhukov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть ID: ");
            string sID = Console.ReadLine();
            Console.Write("Введіть ім'я: ");
            string sName = Console.ReadLine();
            Console.Write("Введіть прізвище: ");
            string sSurname = Console.ReadLine();
            Console.Write("Введіть дату народження (yyyy-MM-dd): ");
            string sDateOfBirth = Console.ReadLine();
            Console.Write("Введіть національність: ");
            string sNationality = Console.ReadLine();
            Console.Write("Вкажіть стать (чоловік/жінка) [ч/ж]: ");
            ConsoleKeyInfo keyHasSex = Console.ReadKey();
            Console.WriteLine();
            Console.Write("Введіть дату видачі паспорта (yyyy-MM-dd): ");
            string sDateOfIssue = Console.ReadLine();
            Console.Write("Введіть дату закінчення терміну дії паспорта (yyyy-MM-dd): ");
            string sDateOfExpire = Console.ReadLine();
            Console.Write("Введіть індивідуальний податковий номер: ");
            string sIndividualTaxNumber = Console.ReadLine();
            Console.WriteLine();

            // Створюємо новий екземпляр people_data
            People_data person = new People_data();
            person.ID = sID;
            person.Name = sName;
            person.Surname = sSurname;
            person.Date_Of_Birth = sDateOfBirth;
            person.Nationality = sNationality;
            person.sex = keyHasSex.Key == ConsoleKey.Y ? true : false;
            person.Date_Of_Issue = sDateOfIssue;
            person.Date_Of_expire = sDateOfExpire;
            person.Individual_tax_number = sIndividualTaxNumber;

            // Виводимо інформацію про особу та термін дії паспорта
            Console.WriteLine("Дані про особу:");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"ID: {person.ID}");
            Console.WriteLine($"Ім'я: {person.Name}");
            Console.WriteLine($"Прізвище: {person.Surname}");
            Console.WriteLine($"Дата народження: {person.Date_Of_Birth}");
            Console.WriteLine($"Національність: {person.Nationality}");
            Console.WriteLine($"Стать: {(person.sex ? "Чоловік" : "Жінка")}");
            Console.WriteLine($"Дата видачі паспорта: {person.Date_Of_Issue}");
            Console.WriteLine($"Дата закінчення терміну дії паспорта: {person.Date_Of_expire}");
            Console.WriteLine($"Індивідуальний податковий номер: {person.Individual_tax_number}");
            Console.WriteLine($"Термін дії паспорта закінчується через: {person.Passport_Expired_in()}");

            Console.ReadKey();


        }
    }
}
