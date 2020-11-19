using System;


namespace ConsoleApp2.Exceptions
{
    
    public class myException : InvalidCastException
    {
        public myException(string message) : base(message)  {}
        //public override string Message  { get { return "Format Exception!!!!"; } }
    }
}
