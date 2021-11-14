namespace Labb_3_Polymorphism
{
    public class Square : Drawing
    {
        public double Side { get; set; }
        public Square()
        {
            Side = 6;
        }
        public override double Area()
        {
            double area = Side * Side;
            return area;
        }
    }
}
