using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupaStuff.Core.Util
{
    public class LogException : Exception
    {
        public string message;
        public override string ToString()
        {
            return message;
        }
        public LogException()
        {
            message = "Unspecified log exception thrown!";
        }
        public LogException(string message)
        {
            this.message = message;
        }
        public static LogException NotUnity()
        {
            return new LogException("You tried to call a unity function when it is not currently running on unity mode!");
        }
    }
}
