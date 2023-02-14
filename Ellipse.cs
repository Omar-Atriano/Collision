using System;

namespace colision
{
    public class Ellipse
    {
        private int width = 25;
        private int height = 25;

        public Ellipse(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public int GetWidth()
        {
            return width;
        }
        public void SetWidth(int width)
        {
            this.width = width;
        }
        public int GetHeight()
        {
            return height;
        }

        public void SetHeight(int height)
        {
            this.height = height;
        }
        public double GetArea()
        {
            return Math.PI * width * height / 4;
        }
    }
}