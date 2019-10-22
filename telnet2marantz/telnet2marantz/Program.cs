using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimS.Telnet;

namespace telnet2marantz
{
    public class Program
    {
        static void Main(string[] args)
        {
            if (args == null)
            {
                Console.WriteLine("args is null");
            }
            else
            {
                Console.Write("args length is ");
                Console.WriteLine(args.Length.ToString());

                if ((args.Length) != 2)
                    Console.Write(" args length is wrong");
                else



                    using (Client client = new Client(args[0], Int32.Parse(args[1]), new System.Threading.CancellationToken()))
                    {
                        if (client.IsConnected)
                        {

                            client.WriteLine("PWON");
                            Console.WriteLine("PWON");
                            client.WriteLine("SIAUX2");
                            Console.WriteLine("SIAUX2");
                        }

                        else

                            Console.Write("connection lost");





                    }
            }
        }
    }
}
