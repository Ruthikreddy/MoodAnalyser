using System;
using System.Collections.Generic;
using System.Text;
using MoodAnalyserNamespace;
namespace MoodAnalyserNamespace
{
    public class MoodAnalyser
    {
        public string message;
        /// <summary>
        /// Parameterised Constructor
        /// </summary>
        /// <param name="message"></param>
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public string AnalyserMethod()
        {
            try
            {

                if (this.message.Contains("sad"))
                {
                    return "SAD";
                }
                else
                    return "HAPPY";
            }

            catch 
            {
                return "HAPPY";
            }

        }
    }
}
