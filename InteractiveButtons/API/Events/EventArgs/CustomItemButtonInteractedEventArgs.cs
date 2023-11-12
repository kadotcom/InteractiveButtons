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

    public class CustomItemButtonInteractedEventArgs : EventArgs, IExiledEvent, IPickupEvent
    {
        public CustomItemButtonInteractedEventArgs(Player player, ItemPickupBase pickup, CustomItem customItem)
        {
            Player = player;
            Pickup = Pickup.Get(pickup);
            CustomItem = customItem;
            InteractiveButton = Pickup.GameObject.GetComponent<InteractiveButton>();
            CustomItemID = customItem.Id;
        }
        public uint CustomItemID { get; }
        public CustomItem CustomItem { get; }
        public InteractiveButton InteractiveButton { get; set; }
        public Pickup Pickup { get; }
        public Player Player { get; }
    }
}
