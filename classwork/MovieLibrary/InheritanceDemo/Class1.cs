using System;

namespace InheritanceDemo
{
    public class Shape
    {
        public int OriginX { get; set; }
        public int OriginY { get; set; }

        public void Draw ()
        { }

        public void DisplayText()
        { }
    }
    public class DrawingList
    {
        public void Sample ()
        {
            var list = new DrawingList();
            list.Shape1 = new Circle();
            list.Shape2 = new Rectangle();
        }

    public Shape Shape1 { get; set; }
        
        public Shape Shape2 { get; set; }
        public Shape Shape3 { get; set; }
        public Shape Shape4 { get; set; }
        public Shape Shape5 { get; set; }

        public void Draw ()
        {
            Shape1?.Draw();
            Shape2?.Draw();
            Shape3?.Draw();
            Shape4?.Draw();
            Shape5?.Draw();
        }
    }
    public int X { get ; }
        public int Y { get ; }
}
    public class Circle : Shape
{

}
public class Rectangle : Shape

{ 
    public Point TopLeft { get; set; }
    public Point BottomRight { get; set; }
}
}
