using System;
using System.Collections.Generic;
using System.Text;

namespace TestReflections
{
    public class MoodAnalyser
    {
        private string message;

        /// <summary>
        /// setting parameterised constructor with sad or happy message
        /// </summary>
        /// <param name="message"></param>
        public MoodAnalyser(string message)
        {
            this.message = message;
            Console.WriteLine("Parameterized Constuctor");
        }
        public MoodAnalyser()
        {
            Console.WriteLine("Defalut Constuctor");
        }

        /// <summary>
        /// based on mood returing sad or happy message
        /// </summary>
        /// <param name="message"></param>
        public string AnalyserMethod()
        {
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.EMPTY_MESSAGE, "Mood should not be empty");

                }
                if (this.message.Contains("sad"))
                    return "SAD";
                else
                    return "HAPPY";
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NULL_MESSAGE, "Mood should not be null");
            }
        }

    }
}