using Exiled.API.Features;
using Exiled.API.Features.Pickups;
using Exiled.Events.EventArgs.Interfaces;
using InteractiveButtons.Component;
using InventorySystem.Items.Pickups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveButtons.API.Events.EventArgs
{
    using System;
    using Exiled.API.Features;
    using Exiled.Events.EventArgs.Interfaces;
    using UnityEngine;

    public class ButtonCreatedEventArgs : EventArgs, IExiledEvent, IPickupEvent
    {
        public ButtonCreatedEventArgs(ItemPickupBase pickup)
        {
            Pickup = Pickup.Get(pickup);
            InteractiveButton = Pickup.GameObject.GetComponent<InteractiveButton>();
        }
        public InteractiveButton InteractiveButton { get; set; }
        public Pickup Pickup { get; }
    }
}
