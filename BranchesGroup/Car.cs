using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchesGroup
{
    internal class Car
    {
        public string Model { get; set; }
        public string Make { get; set; }
        public Car(string model, string make)
        {
            Model = model;
            Make = make;
        }

    }
}
