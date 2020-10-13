using MoodAnalyserNamespace;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace TestReflections
{
    public class MoodAnalyserFactory
    {
        /// <summary>
        /// UC 4 - Create CreateMoodAnalyserObject to create MoodAnalyser Object
        /// </summary>
        /// <param name="className"></param>
        /// <param name="constructor"></param>
        /// <returns></returns>
        public static object CreateMoodAnalyserObject(string className, string constructor)
        {
            string pattern = @"." + constructor + "$";
            var result = Regex.Match(className, pattern);
            if (result.Success)
            {
                try
                {
                    Assembly assembly = Assembly.GetExecutingAssembly();
                    Type moodAnalyserType = assembly.GetType(className);
                    return Activator.CreateInstance(moodAnalyserType);
                }
                catch (NullReferenceException)
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NO_SUCH_CLASS, "no such class is found");
                }


            }
            else
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NO_SUCH_CONSTRUCTOR, "no such constructor found");
        }
        /// <summary>
        /// UC 5 - Create CreateMoodAnalyserParameterizedObject to create Parameterized MoodAnalyser Object
        /// </summary>
        /// <param name="className"></param>
        /// <param name="constructor"></param>
        /// <returns></returns>
        public static object CreateMoodAnalyserParameterizedObject(string className, string constructor, string message)
        {
            Type type = typeof(MoodAnalyser);

            if (type.Name.Equals(className) || type.FullName.Equals(className))
            {
                if (type.Name.Equals(constructor))
                {
                    ConstructorInfo construt = type.GetConstructor(new Type[] { typeof(string) });
                    Object obj = construt.Invoke(new object[] { message });
                    return obj;
                }
                else
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NO_SUCH_CONSTRUCTOR, "no such constructor found");
            }
            else
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NO_SUCH_CLASS, "no such class found");
            }
        }
        /// <summary>
        /// UC 6 - Create InvokeAnalyserMethod to invoke AnalyserMethod using Reflections
        /// </summary>
        /// <param name="message"></param>
        /// <param name="methodName"></param>
        /// <returns></returns>
        public static string InvokeAnalyserMethod(string message, string methodName)
        {
            try
            {
                Type type = Type.GetType("TestReflections.MoodAnalyser");
                MethodInfo methodInfo = type.GetMethod(methodName);
                object moodAnalyserObject = CreateMoodAnalyserParameterizedObject("TestReflections.MoodAnalyser", "MoodAnalyser", "happy");
                object info = methodInfo.Invoke(moodAnalyserObject, null);
                return info.ToString();
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NO_SUCH_METHOD, "No such method found");
            }
        }

    }
    }

