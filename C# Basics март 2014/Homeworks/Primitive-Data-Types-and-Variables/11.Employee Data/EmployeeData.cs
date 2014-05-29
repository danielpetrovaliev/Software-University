using System;


class EmployeeData
{
    static void Main()
    {
        string firstName, lastName;
        byte age;
        char gender;
        long IdNumber;
        ulong UniqueNumber;

        firstName = "Daniel";
        lastName = "Petrovaliev";
        age = 18;
        gender = 'm';
        IdNumber = 8306112507;
        UniqueNumber = 27569572;

        Console.WriteLine("Personal information about {0} {1} : \n First name : {0} \n Last name : {1} \n Age: {2} \n Gender : {3} \n Personal ID number : {4} \n Unique employee number : {5}",firstName,lastName,age,gender,IdNumber,UniqueNumber);
    }
}