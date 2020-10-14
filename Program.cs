using System;
using TestReflections;

namespace MoodAnalyserNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            //MoodAnalyser analyser = new MoodAnalyser("I am in sad Mood");
            //Console.WriteLine(analyser.AnalyserMethod());
            MoodAnalyserFactory.CreateMoodAnalyserObject("TestReflections.MoodAnaly", "MoodAnalyser");
           // MoodAnalyserFactory.CreateMoodAnalyserParameterizedObject("TestReflections.MoodAnaler", "MoodAnalyser", "happy");
            Console.ReadLine();
        }
    }
}
