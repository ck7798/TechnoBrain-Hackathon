using System;
					
public class Program
{
	public static void Main()
	{
		
	List<Shape> listOfShapes = new List<Shape>();
	
	if(listOfShapes[0] is Rectangle)
{
     Rectangle rec = (Rectangle)listOfShapes[0];
} 
		
	 Circle cir = new Circle(50,"Blue");	
	}
	public class Shape {
    
    public string colour { get; set; }
}

public class Circle : Shape {
    public double Radius;
    public Circle(int theRadius, string theColour) {
        this.Radius = theRadius;
        this.colour = theColour;
    }
}

public class Rectangle : Shape {
    public int height;
	public int width;
    public Rectangle(int theHeight, int theWidth, string theColour) {
        this.height = theHeight;
		this.width = theWidth;
        this.colour = theColour;
    }
}
	
}