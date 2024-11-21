using Task2;

namespace Task3
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-04-09 18:23:27</DateOfCreation>
    /// <summary>
    /// Describes a triangle.
    /// </summary>
    public class Triangle : IFigure
    {
        private double sideA;
        private double sideB;
        private double sideC;

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-04-09 18:23:43</DateOfCreation>
        /// <summary>
        /// Creates a triangle with the default parameters: side A=1, side B=1,side C=1 .
        /// </summary>
        public Triangle()
        {
            SideA = 1;
            SideB = 1;
            SideC = 1;
        }

        public double SideA
        {
            get
            {
                return sideA;
            }

            set
            {
                if (value > 0)
                {
                    sideA = value;
                }
                else
                {
                    Logger.PrintNegativeSideWarning();
                }
            }
        }

        public double SideB
        {
            get
            {
                return sideB;
            }

            set
            {
                if (value > 0)
                {
                    sideB = value;
                }
                else
                {
                    Logger.PrintNegativeSideWarning();
                }
            }
        }

        public double SideC
        {
            get
            {
                return sideC;
            }

            set
            {
                if (value > 0)
                {
                    sideC = value;
                }
                else
                {
                    Logger.PrintNegativeSideWarning();
                }
            }
        }

        public double Perimiter
        {
            get
            {
                TriangleHandler triangleHandler = new TriangleHandler(this);
                return triangleHandler.CalculatePerimiter(); 
            }
        }

        public double Area
        {
            get
            {
                TriangleHandler triangleHandler = new TriangleHandler(this);
                return triangleHandler.CalculateArea();
            }
        }
    }
}
