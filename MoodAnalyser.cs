using System;
using System.Collections.Generic;
using System.Text;
using MoodAnalyserNamespace;
using TestReflections;

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

                if (this.message.Equals(string.Empty))
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.EMPTY_MESSAGE, "mood should not be empty");
                if (this.message.Contains("sad"))
                    return "SAD";
                else
                    return "HAPPY";
            }

            catch (NullReferenceException )
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NULL_MESSAGE, "mood should not be null");
            }

        }
    }
}
