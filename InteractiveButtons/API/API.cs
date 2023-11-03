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
            ExistingButtons.Clear();
            ExistingButtons = null;
        }
        public static void ClearAllButtons()
        {
            ExistingButtons.Clear();
        }

        public API() { }
    }
}
