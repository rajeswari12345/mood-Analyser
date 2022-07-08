using System;

using System;
namespace MoodAnalyserAppWithCore
{
    public class MoodAnalyZerCustomException : Exception
    {
        /// <summary>
        /// Enum to Exceotion Type
        /// </summary>

        public enum ExceptioType
        {
            NULL_MESSAGE, Empty_Message,
            NO_SUCH_FIELD, NO_SUCH_METHOD,
            NO_SUCH_CLASS, OBJECT_CREATION_ISSUE
        }

        ///Creating 'type' variable of type ExceptionType
        private readonly Exception Type;


        /// <summary>
        ///  parameterised Constructor set: the Exception Type and message
        /// </summary>
        /// <param name = "Type"></param>
        /// <param name = "message"></param>
        public MoodAnalyzeCustomExceptiion Type, string message):base(message)
        {
          this.type = type;
    }   }
}

