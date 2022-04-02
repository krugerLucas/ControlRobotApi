using ControlRobotApi.Models;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlRobotApi.Services
{
    public class headRotationService
    {
        private Context Context;
        private States State;
        public headRotationService(Context context)
        {
            Context = context;
            State = Context.States.FirstOrDefault(state => state.Id == 1);
        }

        public StateRotationModel List()
        {
            StateRotationModel state = new StateRotationModel();
            state.stateHeadRotation = State.stateHeadRotation;
            return state;
        }

        public Result Update(StateRotationModel newStateRotation)
        {

            if(State.stateHeadInclination == "Para Baixo")
            {
                return Result.Fail("Não é permitido rotacionar com cabeça inclinada para baixo");
            }

            State.stateHeadRotation = newStateRotation.stateHeadRotation;
            Context.SaveChanges();
            return Result.Ok();
        }
    }
}
