using System;

namespace Singleton.ThreadSafe
{
    public sealed class Singleton
    {
        private static volatile Singleton instance;
        private static readonly object syncRoot = new object();

        Singleton() { }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton();
                        }
                    }
                }

                return instance;
            }
        }
    }
}
