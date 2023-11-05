using Exiled.API.Features.Pickups;
using InteractiveButtons.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace InteractiveButtons.API
{
    public class API
    {
        public static List<InteractiveButton> ExistingButtons;
        public static void Init()
        {
            ExistingButtons = new List<InteractiveButton>();
        }
        
        public static void Destroy()
        {
            if (ExistingButtons != null)
            {
                ExistingButtons.Clear();
                ExistingButtons = null;
            }
        }
        public static void ClearAllButtons()
        {
            if (ExistingButtons != null)
            {
                ExistingButtons.Clear();
            }
            else
            {
                PluginAPI.Core.Log.Debug("There was an issue clearing all buttons, ExistingButtons is null.");
            }
        }

        public API() { }
    }
}
