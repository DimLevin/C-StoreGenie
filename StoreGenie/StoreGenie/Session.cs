using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreGenie
{
    public class Session
    {
        // PRIVATE PROPERTIES
        private DclassUser _currUser;
        private ControllerUser _controller;

        // for singleton
        private static Session _instance = null;

        // CONSTR.
        private Session() { }

        // Singleton initiator
        public static Session Init()
        {
            if (Session._instance == null)
            {
                Session._instance = new Session();
            }

            return Session._instance;
        }
        
        // PUBLIC PROPERTIES
        public DclassUser CurrentUser { get => _currUser; set => _currUser = value; }
        public ControllerUser Controller { get => _controller; set => _controller = value; }
        
        // METHODS

        // Reset session
        public void Reset()
        {
            _currUser = null;
            _controller = null;
        }
    }
}
