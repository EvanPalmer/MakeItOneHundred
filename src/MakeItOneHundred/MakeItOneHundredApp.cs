using System;
using MakeItOneHundred.Acess;

namespace MakeItOneHundred
{
    public class MakeItOneHundredApp
    {
        private readonly IOutputWriter outputWriter;
        public MakeItOneHundredApp(IOutputWriter outputWriter = null)
        {
            this.outputWriter = outputWriter;
        }

        public void Run()
        {
            outputWriter.WriteLine("Yeah Son");
        }
    }
}