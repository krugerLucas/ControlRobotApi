using ControlRobotApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public void Update(StateLeftElbowModel newStateEblow)
        {
            State.stateLeftelbow = newStateEblow.stateLeftelbow;
            Context.SaveChanges();
        }
    }
}
