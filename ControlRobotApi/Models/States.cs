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
        public int stateLeftelbow { get; set; }
        public int stateLeftWrist { get; set; }
        public int stateRightelbow { get; set; } 
        public int stateRightWrist { get; set; } 
        public int stateHeadInclination { get; set; } 
        public int stateHeadRotation { get; set; } 
    }
}
