using ControlRobotApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlRobotApi.Services
{
    public class rightArmsElbowService
    {
        private Context _context;
        private States _state;
        public rightArmsElbowService(Context context)
        {
            _context = context;
            _state = _context.States.FirstOrDefault(state => state.Id == 1);
        }

        public StateRightElbowModel List()
        {
            StateRightElbowModel state = new StateRightElbowModel();
            state.stateRightelbow = _state.stateRightelbow;
            return state;
        }

        public void Update(StateRightElbowModel newStateInclination)
        {
            _state.stateRightelbow = newStateInclination.stateRightelbow;
            _context.SaveChanges();
        }
    }
}
