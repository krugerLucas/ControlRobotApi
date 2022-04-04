using ControlRobotApi.Models;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlRobotApi.Services
{
    public class leftArmsWristService
    {
        private Context _context;
        private States _state;
        public leftArmsWristService(Context context)
        {
            _context = context;
            _state = _context.States.FirstOrDefault(state => state.Id == 1);
        }

        public StateLeftWristModel List()
        {
            StateLeftWristModel state = new StateLeftWristModel();
            state.stateLeftWrist = _state.stateLeftWrist;
            return state;
        }

        public Result Update(StateLeftWristModel newStateWrist)
        {
            if(((newStateWrist.stateLeftWrist == (_state.stateLeftWrist + 1)) || (newStateWrist.stateLeftWrist == (_state.stateLeftWrist - 1))) && (newStateWrist.stateLeftWrist < 8 && newStateWrist.stateLeftWrist > 0))
            {
                if (_state.stateLeftelbow != 4)
                {
                    return Result.Fail("Cotovelo não está fortemente contraído");
                }

            _state.stateLeftWrist = newStateWrist.stateLeftWrist;
            _context.SaveChanges();
            return Result.Ok();
            }

            return Result.Fail("Operação inválida");
            
        }
    }
}
