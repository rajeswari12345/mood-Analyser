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

            if (this.message.Contains("sad"))
            {
                return "SAD";
            }
            else
            {
                return "Happy";

            }
        }
            catch
            {
                return "HAPPY";
            }
        }
    }
}
