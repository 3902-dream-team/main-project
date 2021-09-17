using Microsoft.Xna.Framework.Input;
using Project1.Command;
using System.Collections.Generic;

namespace Project1.Controller
{
    class KeyboardController : IController
    {
        private Dictionary<Keys, ICommand> controllerMappings;

        public KeyboardController()
        {
            controllerMappings = new Dictionary<Keys, ICommand>();
        }

        public void RegisterCommand(ICommand command, Keys key)
        {
            if (!controllerMappings.TryAdd(key, command))
            {
                controllerMappings[key] = command;
            }
        }


        public void Update()
        {
            Keys[] pressedKeys = Keyboard.GetState().GetPressedKeys();

            foreach (Keys key in pressedKeys)
            {
                controllerMappings[key].Execute();
            }
        }

        
    }
}