using System;

namespace Part1_Ex2
{
    public class ListBox : Window
    {
        private string listBoxContents;

        public ListBox(int top, int left, string contents)
            : base(top, left)
        {
            listBoxContents = contents;
        }

        public override void DrawWindow()
        {
            base.DrawWindow();
            Console.WriteLine("Writing string to the listbox: {0}", listBoxContents);
        }
    }
}