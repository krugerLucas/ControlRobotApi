using ControlRobotApi.Models;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlRobotApi.Services
{
    public class rightArmsWristService
    {
        private Context _context;
        private States _state;
        public rightArmsWristService(Context context)
        {
            _context = context;
            _state = _context.States.FirstOrDefault(state => state.Id == 1);
        }

        public StateRightWristModel List()
        {
            StateRightWristModel state = new StateRightWristModel();
            state.stateRightWrist = _state.stateRightWrist;
            return state;
        }

        public Result Update(StateRightWristModel newStateWrist)
        {
            if (newStateWrist.stateRightWrist == (_state.stateRightWrist + 1) ^ newStateWrist.stateRightWrist == (_state.stateRightWrist - 1))
            {
                if (_state.stateRightelbow != 4)
                {
                    return Result.Fail("Cotovelo não está fortemente contraído");
                }

                _state.stateRightWrist = newStateWrist.stateRightWrist;
                _context.SaveChanges();
                return Result.Ok();
            }

            return Result.Fail("Operação inválida");
            
        }
    }
}
