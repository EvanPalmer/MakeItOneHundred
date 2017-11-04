using System;

namespace MakeItOneHundred.Acess
{
    public interface IOutputWriter
    {
        void WriteLine(string output);
    }
    public class OutputWriter : IOutputWriter
    {
        public void WriteLine(string output)
        {
            Console.WriteLine(output);
        }
    }
}