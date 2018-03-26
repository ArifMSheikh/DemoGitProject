using System;

namespace MIS310
{
    public class Math
    {
        private int numberOne;
        private int numberTwo;

        //Default constructor
        public Math()
        {
            //do nothing
        }

        //Constructor with parameter
        public Math(int numberOne, int numberTwo)
        {
            this.numberOne = numberOne;
            this.numberTwo = numberTwo;
        }

        //Method to add numbers
        public int AddNumbers()
        {
            return numberOne + numberTwo;
        }


    }
}
