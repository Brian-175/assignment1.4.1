// Create a structure named “Point” and 2 data members: X and Y coordinate. Declare 2 points: P1 and P2.
// Determine if P2 is to the right or left of P1 or on same axis , by comparing the x xoordinates.
// ( if p1.x is more than p2.x , it is to the right )
using System.Drawing;
class Point
{
    
    public double XCoordinate { get; set; }
    public double YCoordinate { get; set; }
    public Point(int x, int y)
    {
        XCoordinate = x;
        YCoordinate = y;
    }

    

    public static void Main(string[] args)
    {
        Point p1 = new Point(25, 5);
        Point p2 = new Point(20, 5);

        if (p1.XCoordinate > p2.XCoordinate)
        {

            Console.WriteLine("Coordinate 1 is to the right of Coordinate 2");
        }
        else if(p1.XCoordinate == p2.XCoordinate)
        {
            Console.WriteLine("The two coordinates are on the same X-axis.");
        }
        else
        {
            Console.WriteLine("Coordinate 1 is to the left of Coordinate 2");
        }
         
        

}
}


