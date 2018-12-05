using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.State
{
    class SocialNetworkContext : ISocialNetworkState
    {

        public readonly ISocialNetworkState LOGGED_IN_STATE;
        public readonly ISocialNetworkState LOGGED_OUT_STATE;

        ISocialNetworkState currentState;

        public SocialNetworkContext()
        {
            LOGGED_IN_STATE = new LoggedIn(this);
            LOGGED_OUT_STATE = new LoggedOut(this);
            currentState = LOGGED_OUT_STATE;
        }

        public bool Login(int pass)
        {
            return currentState.Login(pass);
        }

        public bool Logout()
        {
            return currentState.Logout();
        }

        public bool Post()
        {
            return currentState.Post();
        }

        public void ChangeState(ISocialNetworkState newState)
        {
            currentState = newState;
        }

    }
}
