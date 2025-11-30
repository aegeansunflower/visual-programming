using System;

class AccountTest
{
    static void Main()
    {
        Account myAccount = new Account();
        Console.WriteLine($"Başlangıç ismi: {myAccount.GetName()}");
        Console.Write("Lütfen hesap adını giriniz: ");
        string theName = Console.ReadLine();
        myAccount.SetName(theName);
        Console.WriteLine($"myAccount nesnesinin adı: {myAccount.GetName()}");
    }
}
