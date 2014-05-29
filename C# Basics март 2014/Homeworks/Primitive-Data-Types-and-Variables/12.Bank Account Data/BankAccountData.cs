using System;

class BankAccountData
{
    static void Main()
    {
        string firstName, middleName, lastName;
        decimal balance;
        string bankName, cardnum1, cardnum2, cardnum3, IBAN;
        firstName = "Daniel";
        middleName = "Dimitrov";
        lastName = "Petrovaliev";
        balance = 10254.0435m;
        bankName = "Pro Credit Bank";
        cardnum1 = "4319 7892 4568";     //Номерата на кредитните карти съм ги сложил в "strings" за да мога да ги разделя на по 4 числа
        cardnum2 = "4319 2548 6983";
        cardnum3 = "7895 1239 6543";
        IBAN = "GB19 LOYD 3096 1700 7099";


        Console.WriteLine("{0}\n\nName: {1} {2} {3}\nBalance: {4} \nFirst Card number: {5}\nSecond Card number: {6}\nThird Card number: {7}\nIBAN: {8}" ,bankName,firstName,middleName,lastName,balance,cardnum1,cardnum2,cardnum3,IBAN);
    }
}
