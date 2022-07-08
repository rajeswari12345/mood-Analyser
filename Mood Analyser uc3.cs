using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer.usecase2
{

    public class MoodAnalyse
    {
        private string message;
        /// <summary>
        /// parameterised constructor.
        /// </summary>	
        /// param name = "message"></param>
        public MoodAnalyse(string messsage)
        {
            this.message = messsage;
        }
        public string AnalyseMood()
        {
            try
            {
                if(this.message.Equals(string.Empty))
                {
                    throw new MoodAnalyseCustomException(MoodAnalyserCustomException.ExceptionType.Empty_Message, "Mood should not be happy")
                }

                if (this.message.Contains("SAD"))
                {
                    return "SAD";
                }
                else
                {
                    return "Happy";

                }
            }
            catch(NullReferenceException)
            {
                throw new MoodAnalyseCustomException(MoodAnalyserCustomException.ExceptionType.Empty_Message, "Mood should  bee Null")
            }
        }
    }
}
