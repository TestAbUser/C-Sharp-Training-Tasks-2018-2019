namespace Task2
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-04-09 18:17:48</DateOfCreation>
    /// <summary>
    /// Describes a circle. 
    /// </summary>
    public class Round : IFigure
    {
        private double r;
        private double area;
        private double perimiter;

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-04-09 18:18:24</DateOfCreation>
        /// <summary>
        /// Creates a circle with default parameters: x=0; y=0; r=1.
        /// </summary>
        public Round()
        {
            X = 0;
            Y = 0;
            R = 1;
        }

        public double X { get; set; }
        public double Y { get; set; }

        public double R
        {
            get
            {
                return r;
            }

            set
            {
                if (value > 0)
                {
                    r = value;
                }
                else
                {
                    Logger.PrintNegativeRadiusWarning();
                }
            }
        }

        public double Perimiter
        {
            get
            {
                RoundHandler roundHandler = new RoundHandler(R);
                perimiter = roundHandler.CalculatePerimiter();
                return perimiter;
            }
        }

        public double Area
        {
            get
            {
                RoundHandler roundHandler = new RoundHandler(R);
                area = roundHandler.CalculateArea();
                return area;
            }
        }
    }
}
