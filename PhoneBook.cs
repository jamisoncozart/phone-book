using System;
using System.Collections.Generic;

class PhoneBook
{
  public static Dictionary<string, string> phoneNumbers = new Dictionary<string, string>();
  static void Main()
  {
    Console.WriteLine("MAIN MENU");
    Console.WriteLine("Would you like to add a person to your phone book? ['Y' for Yes, 'Enter' for No]");
    string answer = Console.ReadLine();

    if(answer == "Y" || answer == "y")
    {
      AddNewContact();
    }
    else
    {
      Console.WriteLine("Would you like to look up a number in your phone book? ['Y' for Yes, 'Enter' for No]");
      string lookUpAnswer = Console.ReadLine();
      if(lookUpAnswer == "Y" || lookUpAnswer == "y")
      {
        LookUpContact();
      }
      else
      {
        Console.WriteLine("Are you finished using the program? ['Y' for Yes, 'Enter' for No]");
        string finishedAnswer = Console.ReadLine();
        if(finishedAnswer == "Y" || finishedAnswer == "y")
        {
          Console.WriteLine("Goodbye");
        }
        else{
          Main();
        }
      }
    }
  }
  static void AddNewContact()
  {
    Console.WriteLine("NEW CONTACT");
    Console.WriteLine("Enter a new contact name");
    string name = Console.ReadLine();
    Console.WriteLine("Enter a new contact phone number");
    string number = Console.ReadLine();
    if(phoneNumbers.ContainsKey(name))
    {
      Console.WriteLine("I'm sorry, that name is already in the Phone Book. " + name + "'s number is: " + phoneNumbers[name]);
    }
    else{
      phoneNumbers.Add(name, number);
    }
  }
  static void LookUpContact()
  {

  }
}