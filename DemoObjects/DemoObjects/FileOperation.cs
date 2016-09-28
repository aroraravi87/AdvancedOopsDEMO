using System;
using System.IO;
using System.Text;

namespace DemoObjects
{
    class MainProgram
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Main Started");
            string filePath = @"D:\SampleComponent_Projects\DemoOops\DemoObjects\DemoObjects\Content\hello.txt";
            string NewfilePath = @"D:\SampleComponent_Projects\DemoOops\DemoObjects\DemoObjects\Content\helloNew.txt";
            ReadByetoMemoryStream(filePath, NewfilePath);
            Console.WriteLine("File Read Sucessfully");
            Console.ReadKey();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="NewfilePath"></param>
        /// <returns></returns>
        private static byte[] ReadByteArray(string filePath, string NewfilePath)
        {
            byte[] buffer = new byte[100000];
            FileStream fs = null;
           
            try
            {
                using (fs =
                    new FileStream(filePath,
                        FileMode.Open, FileAccess.Read))
                {

                    string contents = null;
                    StreamReader sr=new StreamReader(fs);
                   contents= sr.ReadToEnd();
                    buffer = ToByteArray(contents);
                   FileStream fs1 =
                        new FileStream(NewfilePath,
                            FileMode.OpenOrCreate, FileAccess.Write);

                    if (buffer.Length > 0)
                    {
                        for (int i = 0; i < buffer.Length; i++)
                        {
                            fs1.WriteByte(buffer[i]);
                        }
                        fs1.Seek(0, SeekOrigin.Begin);
                        fs1.Close();
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                fs.Close();
            }
            return buffer;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static byte[] ToByteArray(string value)
        {
            char[] charArr = value.ToCharArray();
            byte[] bytes = new byte[charArr.Length];
            for (int i = 0; i < charArr.Length; i++)
            {
                byte current = Convert.ToByte(charArr[i]);
                bytes[i] = current;
            }

            return bytes;
        }


        private static void ReadByetoMemoryStream(string filePath, string NewfilePath)
        {
            using (FileStream FS1 =new FileStream(filePath,
                    FileMode.Open, FileAccess.Read))
            {

                string contents = null;
                StreamReader sr = new StreamReader(FS1);
                contents = sr.ReadToEnd();
                byte[] buffer = Encoding.ASCII.GetBytes(contents);

                MemoryStream ms = new MemoryStream(buffer);
                
                FileStream fswrite =
                        new FileStream(NewfilePath,
                            FileMode.OpenOrCreate, FileAccess.Write);
                ms.WriteTo(fswrite);   
                fswrite.Close();
                ms.Close();
            }
        }

    }
}
