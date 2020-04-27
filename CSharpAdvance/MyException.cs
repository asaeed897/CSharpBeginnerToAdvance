using System;

namespace CSharpAdvance
{
    public class MyException : Exception
    {
        public MyException(string message, Exception innerException)
            :base(message, innerException) 
        {
            
        }
    }
}