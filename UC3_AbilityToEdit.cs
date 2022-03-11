using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem_Day9
{
     class UC3_AbilityToEdit
    {
        string FirstName { get; set; }
        string LastName { get; set; }

        public List<editpersonname> People = new List<editpersonname>();
        public void editperson()
        {
            editpersonname edit = new editpersonname();
            Console.WriteLine("Here you can edit  a entry to your address book");

            Console.WriteLine("Enter First Name: ");
            edit.FirstName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            edit.LastName = Console.ReadLine();





        }
    }
}
