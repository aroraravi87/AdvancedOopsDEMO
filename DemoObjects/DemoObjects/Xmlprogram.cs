using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoObjects
{
    internal class Xmlprogram
    {
        public static void Main(string[] args)
        {
            const string xmlstring = @"<root>
                        <book>
                        <title>Test</title>
                        <Quantity>1000</Quantity>
                        <Price>200</Price>
                        </book>
                        </root>";
            if (ValidateXml(xmlstring))
            {
                Console.WriteLine("Xml is Valid");
            }
            else
            {
                Console.WriteLine("Xml is not Valid");
            }
            Console.Read();
        }


        public static bool ValidateXml(string xml)
        {
            List<string> tags = new List<string>();
            string str = xml.Replace(" ", "");
            string temp = str;
            int j = 0;
            StringBuilder substr=new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                if (!string.IsNullOrEmpty(str[i].ToString()))
                {
                    if (str[i] == '<'  )
                    {
                        while (str[j]!='>')
                        {
                            substr.Append(str[j]);
                             temp=str.Remove(0,substr.Length+1);
                            j++;
    
                        }
                        Console.WriteLine(substr.ToString() + ">");
                        substr.Clear();
                        str = temp;
                    }
                }
                //foreach (var item in tags)
                //{
                //    Console.WriteLine(item);                    
                //}


            }
           
            return true;
        }
    }
}
