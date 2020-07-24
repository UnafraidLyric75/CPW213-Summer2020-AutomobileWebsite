using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutomobileWebsite.Models
{
    public class Vehicle
    {
        [Key]
        public int VehicleId { get; set; }

        /// <summary>
        /// Is the VIN of the car
        /// </summary>
        public int VehicleIdNum { get; set; }

        /// <summary>
        /// Is the company the produce it
        /// ex. Ford, Chevey, Jeep, etc.
        /// </summary>
        public string Make { get; set; }

        /// <summary>
        /// Is what type of car from company
        /// Ex. Bug, Compass, Wrangler, Mita, etc.
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// Year car was produced
        /// </summary>
        public int Year { get; set; }
    }
}
