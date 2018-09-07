using System;

namespace SourceCodeMessages
{
    public class SourceCode
    {
        public static void Show()
        {
            Console.WriteLine();
        }

        public static void Show(bool value)
        {
            Console.WriteLine(value);
        }

        public static void Show(char value)
        {
            Console.WriteLine(value);
        }

        public static void Show(char[] buffer)
        {
            Console.WriteLine(buffer);
        }

        [CLSCompliant(false)]
        public static void Show(ulong value)
        {
            Console.WriteLine(value);
        }

        public static void Show(double value)
        {
            Console.WriteLine(value);
        }

        public static void Show(int value)
        {
            Console.WriteLine(value);
        }

        public static void Show(long value)
        {
            Console.WriteLine(value);
        }

        public static void Show(object value)
        {
            Console.WriteLine(value);
        }

        public static void Show(float value)
        {
            Console.WriteLine(value);
        }

        public static void Show(string value)
        {
            Console.WriteLine(value);
        }

        public static void Show(string format, object arg0)
        {
            Console.WriteLine(format, arg0);
        }

        public static void Show(string format, object arg0, object arg1)
        {
            Console.WriteLine(format, arg0, arg1);
        }

        public static void Show(string format, object arg0, object arg1, object arg2)
        {
            Console.WriteLine(format, arg0, arg1, arg2);
        }

        public static void Show(string format, params object[] arg)
        {
            Console.WriteLine(format, arg);
        }

        public static void Show(uint value)
        {
            Console.WriteLine(value);
        }

        public static void Show(decimal value)
        {
            Console.WriteLine(value);
        }
    }
}
