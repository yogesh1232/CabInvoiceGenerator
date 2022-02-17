using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    
    // Ride class to set data for particular ride
    public class Ride
    {
        // variables
        public double distance;
        public int time;
        
        // parameterized constructor for setting the data
        public Ride(double distance, int time)
        {
            this.distance = distance;
            this.time = time;
        }
    }
}
