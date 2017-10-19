using System;
using System.Collections.Generic;
using System.Text;
using Capgemini;

namespace Capgemini
{
    public class Worker
    {
        Customer customer = new Customer("", "", 0, "");
        bool exit = false;

        public Worker()
        {
        }

        public void Menu()
        {
            customer.CreatingXml();
            do
            {
                int? result = null;
                Console.WriteLine("Welcome in Menu, what do you want to do? \n Add new Customer press 1 \n Update Customer press 2 \n Delete Customer press 3 \n Exit press 4");

                try
                {
                    result = Convert.ToInt16(Console.ReadLine());

                    switch (result)
                    {
                        case 1:
                            {
                                customer.AddingCustomer();
                                Console.WriteLine(" Add menu works");
                            }
                            break;
                        case 2:
                            {
                                Console.WriteLine(" Delete menu works");

                            }
                            break;
                        case 3:
                            Console.WriteLine(" Update menu works");
                            break;
                        case 4:
                            {
                                exit = true;
                                Console.WriteLine(" Exit menu works");
                            }
                            break;
                        default:
                            Console.WriteLine(" Wrong Parameter Works");
                            break;
                    }
                }
                catch (FormatException fEx)
                {
                    Console.WriteLine(fEx.Message);
                }
                catch (Exception Ex)
                {
                    Console.WriteLine("Something went wrong");
                }

            } while (exit != true);
        }
    }
}
