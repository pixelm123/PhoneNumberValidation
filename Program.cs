using System;
using System.Text.RegularExpressions;

namespace PhoneNumberValidation
{
    class Program
    {
        
        public static String isValidNumber(String inputMobileNumber)
        {
            
            String strRegX = "^((?!(0))[0-9]{10})$";
            Regex re = new Regex(strRegX);

            
            if (re.IsMatch(inputMobileNumber))
            {
                return "t";
            }
            else
            {
                return "f";
            }
        }
        public static void choiceSelect()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("1 : Check The Number \t 2 : Exit");
            Console.WriteLine("------------------------------------");
            Console.Write("\nEnter Your Choice: ");
        }
        
        static void Main(string[] args)
        {
            
            bool flag = false;
            
            while (true)
            {
                
                choiceSelect();
                
                
                try
                {
                    int choice = int.Parse(Console.ReadLine());
                    if (choice >= 1 && choice <= 2)
                    {
                        switch (choice)
                        {
                            case 1:
                                
                                try
                                {
                                    
                                    Console.Write("\nEnter Your Phone Number : ");
                                    String str = Console.ReadLine();

                                    
                                    bool isEmpty = String.IsNullOrEmpty(str);

                                     
                                    if (isEmpty == true)
                                    {
                                        Console.WriteLine("Number Cannot Be Null");
                                        Console.ReadLine();
                                    }
                                   
                                    else
                                    {
                                        
                                        if (isValidNumber(str) == "t")
                                        {
                                            
                                            Console.WriteLine("----Number is Valid----");
                                        }
                                        else
                                        {
                                            
                                            Console.WriteLine("----Invalid Number----");
                                        }
                                        Console.ReadLine();
                                    }
                                }

                                catch (Exception err)
                                {
                                    
                                    Console.WriteLine("Something wrong.....\n Try Again.....");
                                    Console.WriteLine(err.StackTrace);
                                }
                                break;
                            case 2:
                                flag = true;
                                Console.WriteLine("Exited Successfully ........");
                                Console.ReadLine();
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nCan't take negative value or Value Which is Greater then 2");
                        Console.WriteLine("Please select the only option which is in the menu\n");
                        Console.ReadLine();
                    }
                    if (flag == true)
                    {
                        break;
                    }
                }
                catch (FormatException err)
                {
                    Console.WriteLine("\nCan't Inputed String Value , Null Value or Special Character");
                    Console.WriteLine(err.Message+"\n\n");
                }
            }
        }
    }
}
