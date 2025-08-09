// namespace OOP_Demo.AbstractClasses
// {
// public abstract class Circle : Shape
// {
//     public double Radius { get; set; }

//     public Circle(double radius)
//     {
//         Radius = radius;
//     }

//     public override double GetArea()
//     {
//         return Math.PI * Radius * Radius;
//     }
// }
// }


namespace dcit318_assignment2_11137631.AbstractClasses
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
