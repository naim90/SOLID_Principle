using System;

namespace Geometry
{
    abstract class Polygone
    {
        public double perimetre;
        public abstract double Perimetre();
    }
    class Rectangle: Polygone
    {
        private double width;
        private double height;

        public void SetWidth(double width)
        {
            this.width = width;
        }

        public void SetHeight(double height)
        {
            this.height = height;
        }

        public double GetWidth()
        {
            return width;
        }

        public double GetHeight()
        {
            return height;
        }

        public override double Perimetre()
        {
            perimetre = width * height;
            return perimetre;
        }
    }

    class Square : Polygone
    {
        private double cote;
        
        public void SetCote(double cote)
        {
            this.cote = cote;
        }
        public double GetCote()
        {
            return cote;
        }

        public override double Perimetre()
        {
            perimetre = cote*cote;
            return perimetre;
        }
    }
}
