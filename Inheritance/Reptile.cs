using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Reptile : Animal
    {

        // Create a class Reptile
        // give this class 4 members that are specific to Reptile
        // Set this class to inherit from your Animal Class

        public int TailLength { get; set; }
        public bool HasLegs { get; set; }

        public string ScaleColor { get; set; }

        public string ReptileType { get; set; }
    }
}
