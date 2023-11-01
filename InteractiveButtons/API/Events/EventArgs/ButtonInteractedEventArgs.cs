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

    public class ButtonInteractedEventArgs : EventArgs, IExiledEvent, IPickupEvent
    {
        public ButtonInteractedEventArgs(Player player, ItemPickupBase pickup)
        {
            Player = player;
            Pickup = Pickup.Get(pickup);
            InteractiveButton = Pickup.GameObject.GetComponent<InteractiveButton>();
        }
        public InteractiveButton InteractiveButton { get; set; }
        public Pickup Pickup { get; }
        public Player Player { get; }
    }
}
