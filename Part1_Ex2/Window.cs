using System;

namespace Part1_Ex2
{
    public class Window
    {
        public Window(int top, int left)
        {
            this.top = top;
            this.left = left;
        }

        public virtual void DrawWindow()
        {
            Console.WriteLine("Window: drawing Window at {0}, {1}", top, left);
        }

        protected int top;
        protected int left;

        public Window(int i, int left1, string listBoxInArray)
        {
            throw new NotImplementedException();
        }
    }
}