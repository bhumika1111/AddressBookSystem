using System;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Printing Welcome Message
            Console.WriteLine("*******Welcome To Address Book System Program*******");
            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::::::::::");
            int choice;
            
            {
                Console.WriteLine("**Press 0 For Exit **");
                Console.WriteLine("**1.Enter Contact Is Present In Adress Book **");
                Console.WriteLine("**2.Add New Contact To Address Book**");
                Console.WriteLine("**3.Edit Contact Present In Adress Book**");
                Console.WriteLine("**4.Delete Contact Using Users First Name**");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        //creating Instance Object
                        AddressBook objDetails = new AddressBook("Bhumika", "Jadhav", "Nathnagar", "Umarkhed",
                                                                     "Yavatmal", 445206, 9579996326, "bumikamjadhav47@gmail.com");
                        //calling method
                        objDetails.DisplayContactDettails();
                        break;
                    case 2:
                        
                        ContactPersons Objaddnewcontact = new ContactPersons();
                        Objaddnewcontact.AddNewContact();
                        Objaddnewcontact.DisplayContactDetails();
                        break;
                    case 3:
                        //Here ,Creating Instance And Call The Method To Add New Contact.
                        ContactPersons Objeditcontact = new ContactPersons();
                        Objeditcontact.AddNewContact();
                        Objeditcontact.DisplayContactDetails();

                        //Here ,Edit Contact Details  And Call The Method For Editing Contact.
                        Console.WriteLine("**Edid Contact Using First Name. 1:Y/N**");
                        Console.Write("**Enter Your Choice: **");
                        string choice3 = Console.ReadLine();
                        if(choice3 == "Y")
                        {
                            Objeditcontact.EditContactDetails();
                            Objeditcontact.DisplayContactDetails();

                        }
                        break;
                    case 4:
                        //Here, Creating Instance For Call The Method To Edit And Delete Contact Details. 
                        ContactPersons objDeleteAddress = new ContactPersons();
                        objDeleteAddress.AddNewContact();
                        objDeleteAddress.DisplayContactDetails();

                        //Here,Asking To Edit Contact If Yes then Proceed.
                        Console.WriteLine("Enter Contact Using First Name: Y/N");
                        Console.Write("**Enter Your Choice:**");
                        string choice4_1 = Console.ReadLine();
                        if(choice4_1 == "Y")
                        {
                            objDeleteAddress.EditContactDetails();
                            objDeleteAddress.DisplayContactDetails();
                        }
                        //Asking To Delete The Contact Details If Y Then Proceed.
                        Console.WriteLine("Delete Contact Using First Name: Y/N");
                        Console.Write("Enter Your Choice: ");
                        string choice4_2 = Console.ReadLine();
                        if(choice4_2 == "Y")
                        {
                            objDeleteAddress.DeleteContactDetails();
                        }
                        else
                        {
                            objDeleteAddress.DisplayContactDetails();
                        }
                        break;
                }



            }

            
        }
    }
}

