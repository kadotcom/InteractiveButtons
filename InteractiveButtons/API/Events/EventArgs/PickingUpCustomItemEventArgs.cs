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
    using Exiled.CustomItems.API.Features;
    using Exiled.Events.EventArgs.Interfaces;
    using UnityEngine;

    public class PickingUpCustomItemEventArgs : EventArgs, IExiledEvent, IPickupEvent
    {
        public PickingUpCustomItemEventArgs(Player player, ItemPickupBase pickup, CustomItem customItem)
        {
            Player = player;
            Pickup = Pickup.Get(pickup);
            CustomItem = customItem;
        }
        public CustomItem CustomItem { get; }
        public Pickup Pickup { get; }
        public Player Player { get; }
    }
}
