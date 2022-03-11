using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem_Day9
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            // NewContact.contacts obj = new contacts();
            // obj.addperson();
            // UC2_AddNewContact.AddContact();
            editpersonname edit = new editpersonname();
            edit.editperson();
            Console.ReadLine();
        }

        //private class contacts : NewContact.contacts
       
    }
}