// See https://aka.ms/new-console-template for more information
using MovieBaseAndMethods;
using MovieStoreClasses.Classes;

Methods method = new Methods();


while(true)
{
    try
    {
        while (true)
        {
            
            Console.WriteLine("FOR LOGIN INSER 1, FOR REGISTER ISERT 2");
            int mainInput;
            bool mainUserInput = int.TryParse(Console.ReadLine(), out mainInput);
            
            if (!mainUserInput)
            {
                throw new Exception("Please inser right Number");

            }
            if (mainInput != 1 && mainInput != 2 )
            {
                throw new Exception("Please inser only 1 for login or 2 for register private user Number");
            }
            if(mainInput == 2)
            {
                method.userRegistration();

            };
            if (mainInput == 1) { 
            Console.WriteLine("Enter User Name ");
            string userName = Console.ReadLine();
           
            if (string.IsNullOrEmpty(userName))
            {
                throw new Exception("You must enter USER NAME !!!");
            }

            Employe employee = method.GetEmployeMember(userName);

            if (employee != null)
            {
                bool passwordMatch = method.passMatch(employee.Password);
                if (!passwordMatch)
                {
                    throw new Exception("Pass didnt match 3 times please try again");
                }

                while (!method.EmployeeChose());
                   
            }
            else
            {
                
                User user = method.GetUserMember(userName);
                if(user == null)
                {
                    throw new Exception("This User Does not EXIST TRY AGAIN !!!");
                }
                bool passwordMatch = method.passMatch(user.Password);
                if (!passwordMatch)
                {
                    throw new Exception("Pass didnt match 3 times please try again");
                }

                while (!method.UserChose(user)) ;
            }

        }
        }
    }

    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}






Console.WriteLine("Hello, World!");


