using ControlRobotApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentResults;

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

        public Result Update(StateRightElbowModel newStateInclination)
        {
            if((newStateInclination.stateRightelbow == (_state.stateRightelbow + 1) || newStateInclination.stateRightelbow == (_state.stateRightelbow - 1)) && newStateInclination.stateRightelbow < 5 && newStateInclination.stateRightelbow > 0)
            {
                _state.stateRightelbow = newStateInclination.stateRightelbow;
                _context.SaveChanges();
                return Result.Ok();
            }

            return Result.Fail("Operação inválida");
            
        }
    }
}
