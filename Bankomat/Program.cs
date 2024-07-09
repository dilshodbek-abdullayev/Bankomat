using Bankomat.Services;
using System;

internal class Progam
{
    static void Main(string[] args)
    {
        BankomatService service = new BankomatService();
        service.UserInterfaceEnter();
    }
}