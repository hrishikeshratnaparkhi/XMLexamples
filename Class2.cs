using System;
using System.IO;



namespace Delegateexp
{
    class Ioops
    {
        public static void Main()
        {
            using (FileStream fs = new FileStream(@"C\Test\SampleFile.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
               // StreamWriter m_StreamWriter = new StreamWriter(fs);
                m_StreamWriter.BaseStream.Seek(0, SeekOrigin.End);


                m_StreamWriter.WriteLine(" file write operation");
                m_StreamWriter.WriteLine(" welcome to sample file");
                m_StreamWriter.WriteLine("this is next line in txt file");
                m_StreamWriter.Flush();


            }
            StreamReader m_StreamReader = new StreamReader(@"C:Test\SampleFile.txt ");
            String str;
            while ((str = m_StreamReader.ReadLine()) != null)
            {
                Console.WriteLine(str);
            }
        }
    }
}




