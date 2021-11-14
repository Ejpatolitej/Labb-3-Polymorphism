namespace Labb_3_Polymorphism
{
    public class Rectangle : Drawing
    {
        public double Height { get; set; }
        public double Length { get; set; }
        public Rectangle()
        {
            Height = 3;
            Length = 5;
        }
        public override double Area()
        {
            double area = Height * Length;
            return area;
        }
    }
}
