using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalayzer
{
    /// <summary>
    /// MoodAnalysisException Class For Handling Exception.
    /// </summary>
    public class MoodAnalysisException : Exception
    {
       
        public enum ExceptionType
        {
            NULL_MESSAGE, Empty_Message
        }

       
        private readonly ExceptionType type;

        
        public MoodAnalysisException(ExceptionType Type, string message) : base(message)
        {
            this.type = Type;
        }
    }
}