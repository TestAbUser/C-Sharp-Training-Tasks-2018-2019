using Task2;

namespace Task02
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-05-29 11:47:27</DateOfCreation>
    /// <summary>
    /// Describes a ring.
    /// </summary>
    public class Ring : Round
    {
        private double r;
        private double outerR;
        private double outerCircumference;
        private double sumOfCircumferences;
        private double areaOfOuterCircle;
        private double areaOfRing;

        /// <Author>Rashid Isayev</Author>
        /// <DateOfCreation>2019-06-05 17:45:37</DateOfCreation>
        /// <summary>
        /// Creates a ring with default properties: x=0, y=0, R=1, outer R=2 .
        /// </summary>
        public Ring() : base()
        {
            OuterR = 2;
            R = 1;
        }

        public new double R
        {
            get
            {
                return r;
            }

            set
            {
                if (value > 0)
                {
                    if (value < outerR)
                    {
                        r = value;
                    }
                    else
                    {
                        Logger.PrintInnerRadiusTooBigWarning();
                    }
                }
                else
                {
                    Task2.Logger.PrintNegativeRadiusWarning();
                }
            }
        }

        public double OuterR
        {
            get
            {
                return outerR;
            }

            set
            {
                if (value > R)
                {
                    outerR = value;
                }
                else
                {
                    Logger.PrintOuterRadiusTooSmallWarning();
                }
            }
        }

        public double OuterPerimiter
        {
            get
            {
                RingHandler ringHandler = new RingHandler(R, OuterR);
                outerCircumference = ringHandler.CalculateOuterCircumference();
                return outerCircumference;
            }
        }

        public double SumOfPerimiters
        {
            get
            {
                RingHandler ringHandler = new RingHandler(R, OuterR);
                sumOfCircumferences = ringHandler.CalculateSumOfCircumferences();
                return sumOfCircumferences;
            }
        }

        public double OuterCircleArea
        {
            get
            {
                RingHandler ringHandler = new RingHandler(R, OuterR);
                areaOfOuterCircle = ringHandler.CalculateOuterArea();
                return areaOfOuterCircle;
            }
        }

        public double RingArea
        {
            get
            {
                RingHandler ringHandler = new RingHandler(R, OuterR);
                areaOfRing = ringHandler.CalculateAreaOfRing();
                return areaOfRing;
            }
        }
    }
}
