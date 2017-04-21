using System;

namespace ShiranuiStream
{
    class Program
    {
        static void Main(string[] args)
        {
            IMiniblog TwitterInstance = new Twitter();
            TwitterInstance.StartStreaming();
        }
    }
}