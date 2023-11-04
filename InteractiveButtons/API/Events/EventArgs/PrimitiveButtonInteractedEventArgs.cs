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
    using AdminToys;
    using Exiled.API.Features;
    using Exiled.API.Features.Toys;
    using Exiled.Events.EventArgs.Interfaces;
    using UnityEngine;

    public class PrimitiveButtonInteractedEventArgs : EventArgs, IExiledEvent
    {
        public PrimitiveButtonInteractedEventArgs(Player player, PrimitiveObjectToy primitive)
        {
            Player = player;
            Primitive = Primitive.Get(primitive);
            PrimitiveButton = Primitive.Base.gameObject.GetComponent<PrimitiveButton>();
        }
        public PrimitiveButton PrimitiveButton { get; set; }
        public Primitive Primitive { get; }
        public Player Player { get; }
    }
}
