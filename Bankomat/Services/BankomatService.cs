using Bankomat.Interfaces;
using Bankomat.Models;
using System;

namespace Bankomat.Services
{
    public class BankomatService
    {
        PlastCard plastCard = new PlastCard();
        
        
        private ILoggerService logger;
        public BankomatService()
        {
            this.logger = new VTwoLoggerService(); 
        }

        public void UserInterfaceEnter()
        {

            do
            {
                try
                {

                    logger.Log("Hello! You can perform ATM operations in this application");
                    logger.Log("\t1 => Check Balanse\n\t2 => Solved Balanse\n\t3 => Add to Balanse");
                    Console.Write("Your choise => ");
                    string inputUser = Console.ReadLine();
                    int userInput = Convert.ToInt32(inputUser);

                    switch (userInput)
                    {
                        case 1: CheckBalanse(); break;
                        case 2: SolvedBalanse(); break;
                        case 3: AddToBalanse(); break;

                        default: logger.Log("Please enter number between 1 and 3"); break;
                    }

                }
                catch (FormatException formatException)
                {
                    logger.Log("You should input number.Try again");
                    IsTrue();
                }
                catch (Exception exception)
                {
                    logger.Log(exception.Message);
                    logger.Log("Please call admin {https://t.me/Abdullayev_d_98}");
                }

            } while (IsTrue());
        }

        public bool IsTrue()
        {
            bool isTrue = true;
            logger.Log("Do you want continue.Please enter (yes / no) ");
            string userInput = Console.ReadLine().ToLower();
            isTrue = userInput is "yes" or "y";
            return isTrue;
        }
        private void AddToBalanse()
        {
            logger.Log("Enter password");
            string inputPassword = Console.ReadLine();
            if (inputPassword != null && inputPassword == plastCard.PlastCardCode)
            {
                Console.Write("Enter price => ");
                string inputPrise = Console.ReadLine();
                decimal priseInput = Convert.ToDecimal(inputPrise);
                plastCard.PlastCardBalance = plastCard.PlastCardBalance + priseInput;

                logger.Log("Successfully");
            }
            else
            {
                logger.Log("Wrong Password.Please do again");
            }
        }

        private void SolvedBalanse()
        {
            try
            {


                logger.Log("Enter password");
                string inputPassword = Console.ReadLine();
                if (inputPassword != null && inputPassword == plastCard.PlastCardCode)
                {
                    logger.Log("1 => 10$\n2 => 20$\n3 => 50$\n4 => Your choise");
                    string checkInput = Console.ReadLine();
                    int checkNumber = Convert.ToInt32(checkInput);
                    decimal solvedbalanse = 0;
                    switch (checkNumber)
                    {
                        case 1: solvedbalanse = 10; break;
                        case 2: solvedbalanse = 20; break;
                        case 3: solvedbalanse = 50; break;
                        case 4: solvedbalanse = Convert.ToDecimal(Console.ReadLine()); break;

                        default:
                            logger.Log("Please enter number between 1 and 4"); break;
                    }
                    if (solvedbalanse <= plastCard.PlastCardBalance)
                    {
                        plastCard.PlastCardBalance -= solvedbalanse;
                    }
                    else
                    {
                        logger.Log("You have not enought money");
                    }
                }
                else
                {
                    logger.Log("Wrong Password.Please do again");
                }
            }
            catch (FormatException formatException)
            {
                logger.Log("You should input number.Try again");
            }
            catch (Exception ex)
            {
                logger.Log(ex.Message);
                logger.Log("Please call admin {https://t.me/Abdullayev_d_98}");
            }
        }
        private void CheckBalanse()
        {
            logger.Log("Enter password");
            string inputPassword = Console.ReadLine();
            if (inputPassword != null && inputPassword == plastCard.PlastCardCode)
            {
                logger.Log($"Your balanse is => {plastCard.PlastCardBalance} $");
            }
        }
    }
}
