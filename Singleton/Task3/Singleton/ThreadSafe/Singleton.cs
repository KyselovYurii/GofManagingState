﻿namespace Singleton.ThreadSafe
{
    public class Singleton
    {
        private static readonly Singleton instance = new Singleton();

        private Singleton() { }

        public static Singleton Instance => instance;
    }
}
