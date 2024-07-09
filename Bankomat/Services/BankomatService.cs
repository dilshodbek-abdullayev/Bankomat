using Bankomat.Models;
using System;

namespace Bankomat.Services
{
    public class BankomatService
    {
        PlastCard plastCard = new PlastCard();

        public void UserInterfaceEnter()
        {

            do
            {
                try
                {

                    Console.WriteLine("Hello! You can perform ATM operations in this application");
                    Console.WriteLine("\t1 => Check Balanse\n\t2 => Solved Balanse\n\t3 => Add to Balanse");
                    Console.Write("Your choise => ");
                    string inputUser = Console.ReadLine();
                    int userInput = Convert.ToInt32(inputUser);

                    switch (userInput)
                    {
                        case 1: CheckBalanse(); break;
                        case 2: SolvedBalanse(); break;
                        case 3: AddToBalanse(); break;

                        default: Console.WriteLine("Please enter number between 1 and 3"); break;
                    }

                }
                catch (FormatException formatException)
                {
                    Console.WriteLine("You should input number.Try again");
                    IsTrue();
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    Console.WriteLine("Please call admin {https://t.me/Abdullayev_d_98}");
                }

            } while (IsTrue());
        }

        public bool IsTrue()
        {
            bool isTrue = true;
            Console.WriteLine("Do you want continue.Please enter (yes / no) ");
            string userInput = Console.ReadLine().ToLower();
            isTrue = userInput is "yes" or "y";
            return isTrue;
        }
        private void AddToBalanse()
        {
            Console.WriteLine("Enter password");
            string inputPassword = Console.ReadLine();
            if (inputPassword != null && inputPassword == plastCard.PlastCardCode)
            {
                Console.Write("Enter price => ");
                string inputPrise = Console.ReadLine();
                decimal priseInput = Convert.ToDecimal(inputPrise);
                plastCard.PlastCardBalance = plastCard.PlastCardBalance + priseInput;

                Console.WriteLine("Successfully");
            }
            else
            {
                Console.WriteLine("Wrong Password.Please do again");
            }
        }

        private void SolvedBalanse()
        {
            try
            {


                Console.WriteLine("Enter password");
                string inputPassword = Console.ReadLine();
                if (inputPassword != null && inputPassword == plastCard.PlastCardCode)
                {
                    Console.WriteLine("1 => 10$\n2 => 20$\n3 => 50$\n4 => Your choise");
                    string checkInput = Console.ReadLine();
                    int checkNumber = Convert.ToInt32(checkInput);
                    decimal solvedbalanse = 0;
                    switch (checkNumber)
                    {
                        case 1: solvedbalanse = 10; break;
                        case 2: solvedbalanse = 20; break;
                        case 3: solvedbalanse = 50; break;
                        case 4: solvedbalanse = Convert.ToDecimal(Console.ReadLine()); break;

                        /* case 1:
                             if (10 <= plastCard.PlastCardBalance)
                             {
                                 plastCard.PlastCardBalance = plastCard.PlastCardBalance - 10;
                             }; break;
                         case 2:
                             if (20 <= plastCard.PlastCardBalance)
                             {
                                 plastCard.PlastCardBalance = plastCard.PlastCardBalance - 20;
                             }; break;
                         case 3:
                             if (50 <= plastCard.PlastCardBalance)
                             {
                                 plastCard.PlastCardBalance = plastCard.PlastCardBalance - 50;
                             }; break;
                         case 4:
                             Console.Write("Enter price => ");
                             string inputPrise = Console.ReadLine();
                             decimal priseInput = Convert.ToDecimal(inputPrise);
                             if (priseInput <= plastCard.PlastCardBalance)
                             {
                                 plastCard.PlastCardBalance = plastCard.PlastCardBalance - priseInput;
                             }
                             else 
                             {

                             }; 
                             break;*/
                        default:
                            Console.WriteLine("Please enter number between 1 and 4"); break;
                    }
                    if (solvedbalanse <= plastCard.PlastCardBalance)
                    {
                        plastCard.PlastCardBalance -= solvedbalanse;
                    }
                    else
                    {
                        Console.WriteLine("You have not enought money");
                    }
                }
                else
                {
                    Console.WriteLine("Wrong Password.Please do again");
                }
            }
            catch (FormatException formatException)
            {
                Console.WriteLine("You should input number.Try again");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Please call admin {https://t.me/Abdullayev_d_98}");
            }
        }
        private void CheckBalanse()
        {
            Console.WriteLine("Enter password");
            string inputPassword = Console.ReadLine();
            if (inputPassword != null && inputPassword == plastCard.PlastCardCode)
            {
                Console.WriteLine($"Your balanse is => {plastCard.PlastCardBalance} $");
            }
        }
    }
}
