using ControlRobotApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentResults;

namespace ControlRobotApi.Services
{
    public class leftArmsElbowService
    {
        private Context Context;
        private States State;
        public leftArmsElbowService(Context context)
        {
            Context = context;
            State = Context.States.FirstOrDefault(state => state.Id == 1);
        }

        public StateLeftElbowModel List()
        {
            StateLeftElbowModel state = new StateLeftElbowModel();
            state.stateLeftelbow = State.stateLeftelbow;
            return state;
        }

        public Result Update(StateLeftElbowModel newStateEblow)
        {
            if((newStateEblow.stateLeftelbow == (State.stateLeftelbow + 1) || newStateEblow.stateLeftelbow == (State.stateLeftelbow - 1)) && newStateEblow.stateLeftelbow < 5)
            {
                State.stateLeftelbow = newStateEblow.stateLeftelbow;
                Context.SaveChanges();
                return Result.Ok();
                
            }
            return Result.Fail("Operação inválida");
        }
    }
}
