using ControlRobotApi.Models;
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

        public void Update(StateInclinationModel newStateInclination)
        {
            State.stateHeadInclination = newStateInclination.stateHeadInclination;
            Context.SaveChanges();
        }
    }
}
