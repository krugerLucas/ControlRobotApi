using ControlRobotApi.Models;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlRobotApi.Services
{
    public class headInclinationService
    {
        private Context Context;
        private States State;
        public headInclinationService(Context context)
        {
            Context = context;
            State = Context.States.FirstOrDefault(state => state.Id == 1);

        }
        public StateInclinationModel List()
        {
            StateInclinationModel state = new StateInclinationModel();
            state.stateHeadInclination = State.stateHeadInclination;
            return state;
        }

        public Result Update(StateInclinationModel newStateInclination)
        {
            if(newStateInclination.stateHeadInclination == (State.stateHeadInclination + 1) ^ newStateInclination.stateHeadInclination == (State.stateHeadInclination - 1))
            {
                State.stateHeadInclination = newStateInclination.stateHeadInclination;
                Context.SaveChanges();
                return Result.Ok();
            }

            return Result.Fail("Operação Inválida");
        }
    }
}
