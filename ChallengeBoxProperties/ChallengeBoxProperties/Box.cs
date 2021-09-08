using System;

namespace ChallengeBoxProperties
{
    class Box
    {

        // member variables
        // Private member variables are only accessable from whitin the class itself.
        // Public member variables are accessable from everywhere within the code
        public int height;
        //private int width;
        private int length;

        // properties
        // We can use the default propertie creator
        public int Width { get; set; }
        // which is simular like
        // in case of example below there must be a member variable called width
        /*
         * public int With 
         * {
         *      get
         *      {
         *          return width;
         *      }
         *      set
         *      {
         *          this.width = value;
         *      }
         */

        // it is also possible to use properties to access member variables and preform checks on the set and modify the get
        // for example below the value of this.length is always set positive.

        public int Length
        {
            get
            {
                return this.length;
            }
            set
            {
                if (value < 0)
                {
                    this.length = -value;
                }
                else
                {
                    this.length = value;
                }
            }
        }

        // we can also use properties to preform a calculation of modification when a get request is preformed.
        public int Volume
        {
            get
            {
                return this.Length * this.Width * this.height;
            }
        }

        public Box()
        {

        }
    }
}
