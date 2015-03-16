

using System;

namespace Week3Ex2
{
    class Tank:IDisposable
    {
        public bool isFull;

        public Tank()
        {
        }

        public Tank(bool isFull)
        {
            this.isFull = isFull;
        }
        
        public void Add()
        {
            isFull = true;
        }
       

        public void EmptyTheTank()
        {
            isFull = false;
        }

        public void Dispose()
        {
            if(isFull)
                Console.WriteLine("The Tank is not empty");
        }
    }
}
