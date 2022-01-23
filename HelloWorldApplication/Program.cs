
using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace CalculatorApplication
{
    [AttributeUsage(AttributeTargets.Class |
                    AttributeTargets.Constructor |
                    AttributeTargets.Field |
                    AttributeTargets.Method |
                    AttributeTargets.Property,
        AllowMultiple = true)]
    public class DebugInfo : System.Attribute
    {
        private int bugNo;
        private string developer;
        private string lastReview;
        private string message;

        public DebugInfo(int bg, string dev, string d)
        {
            this.bugNo = bg;
            this.developer = dev;
            this.lastReview = d;
        }

        public int BugNo { get => bugNo; }

        public string LastReview
        {
            get => lastReview;
        }

        public string Message
        {
            get => message;
            set => message = value;
        }
        
    }

    [DebugInfo(45, "Zara", "12/8/2022", Message = "Return type mismatch")]
    [DebugInfo(49, "Xinyu", "10/10/2021", Message = "Unused Variable")]
    class Rectangle
    {
        protected double length;
        protected double width;

        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }
        
        [DebugInfo()]
    }
    
    
    class Tester
    {
        static void Main(string[] args)
        {
            Box Box1 = new Box(6.0, 7.0, 5.0);
            Box Box2 = new Box(12.0, 13.0, 10.0);

            Box Box3 = Box1 + Box2;
            Console.WriteLine(Box3.GetVolume());
            Box.PrintInfo();
        }
    }
}
