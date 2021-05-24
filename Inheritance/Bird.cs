using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Bird : Animal
    {

        // Create a class Bird
        // give this class 4 members that are specific to Bird
        // Set this class to inherit from your Animal Class

        public bool CanFly { get; set; }
        public int WingSpan { get; set; }

        public string ChirpSound { get; set; }

        public string FeatherColor { get; set; }
    }
}
