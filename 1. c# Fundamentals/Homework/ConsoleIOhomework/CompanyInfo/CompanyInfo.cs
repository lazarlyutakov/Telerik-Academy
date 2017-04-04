using System;


    class CompanyInfo
    {
        static void Main()
        {
     
        string CompanyName = Console.ReadLine();
        string CompanyAddress = Console.ReadLine();
        string CompanyTelephone = Console.ReadLine();
        string CompanyFax = Console.ReadLine();
        string CompanyWebSite = Console.ReadLine();
        string ManagerFirstName = Console.ReadLine();
        string ManagerLastName = Console.ReadLine();
        int ManagerAge = Convert.ToInt32(Console.ReadLine());
        string ManagerPhone = Console.ReadLine();

         Console.WriteLine(CompanyName);   
          
          Console.WriteLine("Address: {0}",CompanyAddress);
      
          Console.WriteLine("Tel. {0}",CompanyTelephone);

          if(CompanyFax==string.Empty)
        {
            Console.WriteLine("Fax: (no fax)");
        }
        else
        {
            Console.WriteLine("Fax: {0}", CompanyFax);
        }

        Console.WriteLine("Web site: {0}",CompanyWebSite);
        Console.Write("Manager: {0} {1} (age: {2}, tel. {3})",ManagerFirstName,ManagerLastName,ManagerAge,ManagerPhone);
        }
    }

