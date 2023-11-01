using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.API.Features.Pickups;
using InteractiveButtons.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace InteractiveButtons.API.Features
{
    public class Spawn
    {
        public static Pickup CreateInteractiveButton(ItemType pickupItem, RoomType spawnRoom, int Id, bool HasGravity = true, Vector3? offset = null, Vector3? scale = null, Quaternion? rotation = null)
        {
            Vector3? off = null;
            if(offset != null)
            {
                off = new Vector3(Room.Get(spawnRoom).Position.x + offset.Value.x, Room.Get(spawnRoom).Position.y + offset.Value.y, Room.Get(spawnRoom).Position.z + offset.Value.z);

            }
            Pickup p = Pickup.CreateAndSpawn(pickupItem, off ?? Room.Get(spawnRoom).Position, rotation ?? Quaternion.Euler(0, 0, 0));
           
            p.Scale = scale ?? Vector3.one;

            if (p.GameObject.GetComponent<Rigidbody>() != null && HasGravity == false)
            {
                Rigidbody rg = p.GameObject.GetComponent<Rigidbody>();
                rg.useGravity = false;
            }else if (p.GameObject.GetComponent<Rigidbody>() != null && HasGravity == true)
            {
                Rigidbody rg = p.GameObject.GetComponent<Rigidbody>();
                rg.useGravity = true;
            }

            if (p.Base.GetComponent<Rigidbody>() != null && HasGravity == false)
            {
                Rigidbody rg = p.GameObject.GetComponent<Rigidbody>();
                rg.useGravity = false;
            }
            else if (p.GameObject.GetComponent<Rigidbody>() != null && HasGravity == true)
            {
                Rigidbody rg = p.GameObject.GetComponent<Rigidbody>();
                rg.useGravity = true;
            }

            p.GameObject.AddComponent<InteractiveButton>();

            InteractiveButton? i = p.GameObject.GetComponent<InteractiveButton>();
            i.Button = p.GameObject;
            i.HasIB = true;
            i.ID = Id;

            //API.ValidButtons.Add(p);

            if (Plugin.Instance.Config.Debug == true)
                PluginAPI.Core.Log.Debug("DEBUGGING: ITEM: " + p.Type + " - POS: " + p.Position + " - ROOM: " + p.Room.Type + " - Interactive Button ID: " + i.ID);

            Events.EventArgs.ButtonCreatedEventArgs ev = new Events.EventArgs.ButtonCreatedEventArgs(p.Base);
            Events.Handlers.Button.OnButtonCreated(ev);
            return p;
        }

        public static Pickup CreateInteractiveButton(ItemType pickupItem, int Id, Vector3 position, bool HasGravity = true, Vector3? scale = null, Quaternion? rotation = null)
        {
            Pickup p = Pickup.CreateAndSpawn(pickupItem, position, rotation ?? Quaternion.Euler(0, 0, 0));

            p.Scale = scale ?? Vector3.one;

            if (p.GameObject.GetComponent<Rigidbody>() != null && HasGravity == false)
            {
                Rigidbody rg = p.GameObject.GetComponent<Rigidbody>();
                rg.useGravity = false;
            }
            else if (p.GameObject.GetComponent<Rigidbody>() != null && HasGravity == true)
            {
                Rigidbody rg = p.GameObject.GetComponent<Rigidbody>();
                rg.useGravity = true;
            }

            if (p.Base.GetComponent<Rigidbody>() != null && HasGravity == false)
            {
                Rigidbody rg = p.GameObject.GetComponent<Rigidbody>();
                rg.useGravity = false;
            }
            else if (p.GameObject.GetComponent<Rigidbody>() != null && HasGravity == true)
            {
                Rigidbody rg = p.GameObject.GetComponent<Rigidbody>();
                rg.useGravity = true;
            }

            p.GameObject.AddComponent<InteractiveButton>();

            InteractiveButton? i = p.GameObject.GetComponent<InteractiveButton>();
            i.Button = p.GameObject;
            i.HasIB = true;
            i.ID = Id;

            //API.ValidButtons.Add(p);

            if (Plugin.Instance.Config.Debug == true)
                PluginAPI.Core.Log.Debug("DEBUGGING: ITEM: " + p.Type + " - POS: " + p.Position + " - ROOM: " + p.Room.Type + " - Interactive Button ID: " + i.ID);

            Events.EventArgs.ButtonCreatedEventArgs ev = new Events.EventArgs.ButtonCreatedEventArgs(p.Base);
            Events.Handlers.Button.OnButtonCreated(ev);
            return p;
        }

        public static Pickup CreatePickup(ItemType pickupItem, RoomType spawnRoom, bool HasGravity = true, Vector3? offset = null, Vector3? scale = null, Quaternion? rotation = null)
        {
            Vector3? off = null;
            if (offset != null)
            {
                off = new Vector3(Room.Get(spawnRoom).Position.x + offset.Value.x, Room.Get(spawnRoom).Position.y + offset.Value.y, Room.Get(spawnRoom).Position.z + offset.Value.z);

            }
            Pickup p = Pickup.CreateAndSpawn(pickupItem, off ?? Room.Get(spawnRoom).Position, rotation ?? Quaternion.Euler(0, 0, 0));

            p.Scale = scale ?? Vector3.one;

            if (p.GameObject.GetComponent<Rigidbody>() != null && HasGravity == false)
            {
                Rigidbody rg = p.GameObject.GetComponent<Rigidbody>();
                rg.useGravity = false;
            }
            else if (p.GameObject.GetComponent<Rigidbody>() != null && HasGravity == true)
            {
                Rigidbody rg = p.GameObject.GetComponent<Rigidbody>();
                rg.useGravity = true;
            }

            if (p.Base.GetComponent<Rigidbody>() != null && HasGravity == false)
            {
                Rigidbody rg = p.GameObject.GetComponent<Rigidbody>();
                rg.useGravity = false;
            }
            else if (p.GameObject.GetComponent<Rigidbody>() != null && HasGravity == true)
            {
                Rigidbody rg = p.GameObject.GetComponent<Rigidbody>();
                rg.useGravity = true;
            }

            if (Plugin.Instance.Config.Debug == true)
                PluginAPI.Core.Log.Debug("DEBUGGING: ITEM: " + p.Type + " - POS: " + p.Position + " - ROOM: " + p.Room.Type);
            return p;
        }
        
        public static Pickup CreatePickup(ItemType pickupItem, RoomType spawnRoom, Vector3 position, bool HasGravity = true, Vector3? scale = null, Quaternion? rotation = null)
        {
            Pickup p = Pickup.CreateAndSpawn(pickupItem, position, rotation ?? Quaternion.Euler(0, 0, 0));

            p.Scale = scale ?? Vector3.one;

            if (p.GameObject.GetComponent<Rigidbody>() != null && HasGravity == false)
            {
                Rigidbody rg = p.GameObject.GetComponent<Rigidbody>();
                rg.useGravity = false;
            }
            else if (p.GameObject.GetComponent<Rigidbody>() != null && HasGravity == true)
            {
                Rigidbody rg = p.GameObject.GetComponent<Rigidbody>();
                rg.useGravity = true;
            }

            if (p.Base.GetComponent<Rigidbody>() != null && HasGravity == false)
            {
                Rigidbody rg = p.GameObject.GetComponent<Rigidbody>();
                rg.useGravity = false;
            }
            else if (p.GameObject.GetComponent<Rigidbody>() != null && HasGravity == true)
            {
                Rigidbody rg = p.GameObject.GetComponent<Rigidbody>();
                rg.useGravity = true;
            }

            if (Plugin.Instance.Config.Debug == true)
                PluginAPI.Core.Log.Debug("DEBUGGING: ITEM: " + p.Type + " - POS: " + p.Position + " - ROOM: " + p.Room.Type);
            return p;
        }
    }
}
