using Microsoft.EntityFrameworkCore;
using System;

namespace InventoryManagementSystem
{
    class Program
    {
        static username="";
        static int choice;
        //static int logout=0;
        static void Main(string[] args)
        {
            //addRole();
            while (choice==0)
            {


                Console.WriteLine("Please login. Choices are as follows\n1. Admin \n2. User\n0. Exit\n----------------------------------------");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            AdminOperations.AdminMenu();
                            break;
                        }

                    case 2:
                        {
                            UserOperations.UserMenu();
                                                       
                            //logout = 0;
                            continue;
                        }
                    case 3:
                        {
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Wrong choice entered. Please try again. ");
                            break;
                        }
                }
            }
        }
        //public static void addRole()
        //{
        //    var ctx = new MyDebContext();
        //    ROLE adminObj = new ROLE() {Role_Name="admin" };
        //    ROLE userObj = new ROLE() {Role_Name="user" };
        //    ctx.ROLES.Add(adminObj);
        //    ctx.ROLES.Add(userObj);
        //}
    }
    class MyDebContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server =.; Database = AngularReact; Trusted_Connection = True; ");
            //optionsBuilder.UseSqlServer(@"Server =SUPRIYAKOL-VD\SQL2017; Database=InventoryMgtSystem; User ID=sa; Password=cybage@123456;");
            optionsBuilder.UseSqlServer(@"Server =SUPRIYAKOL-VD\SQL2017; Database=IMS; User ID=sa; Password=cybage@123456;");
        }
        public virtual DbSet<USERS> USERS { get; set; }
        //public virtual DbSet<INVOICE> INVOICE_DATA { get; set; }
        public virtual DbSet<PRODUCT_CATEGORIES> PRODUCT_CATEGORIES { get; set; }
        //public virtual DbSet<STORAGE> STORAGES { get; set; }
        public virtual DbSet<PRODUCTS> PRODUCTS { get; set; }
        public virtual DbSet<ROLE> ROLES { get; }
        //public virtual DbSet<SHIPPING> SHIPPING { get; set; }

    }


}
