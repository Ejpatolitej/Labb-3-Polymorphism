namespace Labb_3_Polymorphism
{
    public class Circle : Drawing
    {
        public double Radius { get; set; }
        public double Pi { get; set; }
        public Circle()
        {
            Radius = 5;
            Pi = 3.14159265359;
        }

        public override double Area()
        {
            double area = Radius * Radius * Pi;
            return area;
        }
    }
}
