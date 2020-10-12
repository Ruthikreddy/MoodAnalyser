using System;
using System.Collections.Generic;
using System.Text;

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
            if (this.message.Contains("sad"))
                return "Sad";
            else
                return "Happy";
        }
    }
}
