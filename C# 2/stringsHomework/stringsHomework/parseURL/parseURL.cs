using System;

namespace parseURL
{
    class parseURL
    {

        static int firstIndex;
        static int secondIndex;

        static void Main()
        {
            string input = Console.ReadLine();

            Console.WriteLine("[protocol] = {0}",GetProtocol(input));
            Console.WriteLine("[server] = {0}", GetServer(input));
           Console.WriteLine("[resource] = {0}",GetResource(input));
            
        }



        static string GetProtocol(string input)
        {
            
                firstIndex = input.IndexOf("://");
            string protocol = input.Substring(0,firstIndex);

            return protocol;
        }




        static string GetServer(string input)
        {
            firstIndex = input.IndexOf("://") + 3;
            secondIndex = input.IndexOf("/",firstIndex);
            string server = input.Substring(firstIndex, secondIndex - firstIndex);

            return server;
        }





       static string GetResource(string input)
        {
            firstIndex = input.IndexOf("://") + 3 ;
            secondIndex = input.IndexOf("/",firstIndex) ;
            string resource = input.Substring(secondIndex, input.Length - secondIndex);

            return resource;
        }
    }
}
