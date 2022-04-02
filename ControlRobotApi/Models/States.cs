using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlRobotApi.Models
{
    public class States
    {
        [Key]
        public int Id { get; set; }
        public string stateLeftelbow { get; set; }
        public string stateLeftWrist { get; set; }
        public string stateRightelbow { get; set; } 
        public string stateRightWrist { get; set; } 
        public string stateHeadInclination { get; set; } 
        public string stateHeadRotation{ get; set; } 
    }
}
