using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    class AdminOperations
    {
        static int user_choice;
        public static void AdminMenu()
        {
            var ctx = new MyDebContext();
            //Console.WriteLine("inside usermenu");
            while (user_choice == 0)
            {
                Console.WriteLine("----------------------------------------\nWhat operation do you wish to perform?\n1. Add User\n2. Add Role\n0. Logout\n----------------------------------------");
                user_choice = Convert.ToInt32(Console.ReadLine());
                switch (user_choice)
                {
                    case 1:
                        {
                            Console.WriteLine("----------------------------------------\nEnter following details:");
                            Console.WriteLine("Role_ID ,User_Name,First_Name,Last_Name,Password,City,Address,Zip_Code,Email ");
                            int roleId = Convert.ToInt32(Console.ReadLine());
                            string User_Name = Console.ReadLine();
                            string First_Name = Console.ReadLine();
                            string Last_Name = Console.ReadLine();
                            string Password = Console.ReadLine();
                            //string DOB = Convert.ToInt32(Console.ReadLine());
                            string City = Console.ReadLine();
                            string Address = Console.ReadLine();
                            int Zip_Code = Convert.ToInt32(Console.ReadLine());
                            string Email = Console.ReadLine();
                            int productIncharge = Convert.ToInt32(Console.ReadLine());

                            USERS data = new USERS() {Product_Access=productIncharge, Role_ID = roleId, User_Name = User_Name, First_Name = First_Name, Last_Name = Last_Name, Password = Password, City = City, Address = Address, Zip_Code = Zip_Code, Email = Email };
                            ctx.USERS.Add(data);
                            if (ctx.SaveChanges() > 0)
                            {
                                Console.WriteLine("Result-> User Added");
                            }
                            else
                            {
                                Console.WriteLine("Result-> User not added. Please confirm details");
                            }

                            break;
                        }
                    case 2:
                        {



                            break;

                        }
                    default:
                        {
                            Console.WriteLine("Please enter correct choice");
                            break;
                        }
                }
            }
        }

    }
}
