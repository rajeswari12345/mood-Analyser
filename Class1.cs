using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer.usecase1
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
            if (this.message.Contains("sad"))
            {
                return "SAD";
            }
            else
            {
                return "Happy";

            }
        }
    }
}
