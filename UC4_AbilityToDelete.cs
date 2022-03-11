using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem_Day9
{
    public class UC4_AbilityToDelete
    {
        public List<UC4_AbilityToDelete> People = new List<UC4_AbilityToDelete>();
        public void del()
        {
            UC4_AbilityToDelete person = new UC4_AbilityToDelete();
            Console.WriteLine("Enter the first name of the person you would like to remove.");
            string FirstName = Console.ReadLine();

            if (person == null)
            {
                Console.WriteLine("That person could not be found. Press any key to continue");
                Console.ReadKey();
                return;
            }
            else
            {




                People.Remove(person);
                Console.WriteLine("Person removed. Press any key to continue.");
                Console.ReadKey();

            }
        }
    }
}
