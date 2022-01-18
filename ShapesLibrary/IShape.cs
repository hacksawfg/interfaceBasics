using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapesLibrary
{
    // Interfaces establish rules for classes that implement them
    // Interfaces provide information for external use
    // Used to set requirements
    public interface IShape // Interfaces have the letter "I" in front, always as good practice
    {
        string Name { get; }

        public void Draw();

        double CalculateArea();
    }

}