using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace arg_parser
{
    public enum Option : int
    {
        TEST,
        OPTION_COUNT
    };

    class Program
    {

        static void Main(string[] args)
        {
            Dictionary<string, Option> options = new Dictionary<string, Option>()
            {
                { "test", Option.TEST }
            };

            bool arg_option = false;
            foreach (string arg in args)
            {
                if (!arg_option)
                {

                }
                else
                {
                    if (arg[0] == '-')
                    {
                        arg_option = true;
                    }
                }

                if (arg_option)
                {
                    string arg_option_name = arg.Substring(1, arg.Length - 1);
                    Option option;
                    if (options.TryGetValue(arg_option_name, out option))
                    {

                    }
                }
                

                Console.WriteLine(arg);
            }

            Console.Read();

        }
    }
}
