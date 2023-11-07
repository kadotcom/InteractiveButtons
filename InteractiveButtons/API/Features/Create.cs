using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.API.Features.Pickups;
using Exiled.API.Features.Toys;
using Exiled.CustomItems.API.Features;
using InteractiveButtons.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace InteractiveButtons.API.Features
{
    public class Create
    {
        public static Pickup CreateInteractiveButton(ItemType pickupItem, RoomType spawnRoom, int Id, float PickupTime = 1f, bool HasGravity = true, bool HasObjectCollision = true, Vector3? offset = null, Vector3? scale = null, Quaternion? rotation = null)
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
            }
            else if (p.GameObject.GetComponent<Rigidbody>() != null && HasGravity == true)
            {
                Rigidbody rg = p.GameObject.GetComponent<Rigidbody>();
                rg.useGravity = true;
            }

            if (p.GameObject.GetComponent<Rigidbody>() != null && HasObjectCollision == false)
            {
                Rigidbody rg = p.GameObject.GetComponent<Rigidbody>();
                rg.isKinematic = false;
            }
            else if (p.GameObject.GetComponent<Rigidbody>() != null && HasObjectCollision == true)
            {
                Rigidbody rg = p.GameObject.GetComponent<Rigidbody>();
                rg.isKinematic = true;
            }


            p.GameObject.AddComponent<InteractiveButton>();

            p.PickupTime = PickupTime;
            
            InteractiveButton? i = p.GameObject.GetComponent<InteractiveButton>();
            i.ButtonGameObject = p.GameObject;
            i.ButtonPickup = p;
            i.IsUsingTextID = false;
            i.ID = Id;
            
            API.ExistingButtons.Add(i);
            //API.ValidButtons.Add(p);

            if (Plugin.Instance.Config.Debug == true)
                PluginAPI.Core.Log.Debug("DEBUGGING: ITEM: " + p.Type + " - POS: " + p.Position + " - ROOM: " + p.Room.Type + " - Interactive Button ID: " + i.ID);

            Events.EventArgs.ButtonCreatedEventArgs ev = new Events.EventArgs.ButtonCreatedEventArgs(p.Base);
            Events.Handlers.Button.OnButtonCreated(ev);
            return p;
        }

        public static Pickup CreateInteractiveButton(ItemType pickupItem, int Id, Vector3 position, float PickupTime = 1f, bool HasGravity = true, bool HasObjectCollision = true, Vector3? scale = null, Quaternion? rotation = null)
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

            if (p.GameObject.GetComponent<Rigidbody>() != null && HasObjectCollision == false)
            {
                Rigidbody rg = p.GameObject.GetComponent<Rigidbody>();
                rg.isKinematic = false;
            }
            else if (p.GameObject.GetComponent<Rigidbody>() != null && HasObjectCollision == true)
            {
                Rigidbody rg = p.GameObject.GetComponent<Rigidbody>();
                rg.isKinematic = true;
            }

            p.GameObject.AddComponent<InteractiveButton>();

            p.PickupTime = PickupTime;

            InteractiveButton? i = p.GameObject.GetComponent<InteractiveButton>();
            i.ButtonGameObject = p.GameObject;
            i.ButtonPickup = p;
            i.IsUsingTextID = false;
            i.ID = Id;
            API.ExistingButtons.Add(i);

            //API.ValidButtons.Add(p);

            if (Plugin.Instance.Config.Debug == true)
                PluginAPI.Core.Log.Debug("DEBUGGING: ITEM: " + p.Type + " - POS: " + p.Position + " - ROOM: " + p.Room.Type + " - Interactive Button ID: " + i.ID);

            Events.EventArgs.ButtonCreatedEventArgs ev = new Events.EventArgs.ButtonCreatedEventArgs(p.Base);
            Events.Handlers.Button.OnButtonCreated(ev);
            return p;
        }

        public static Pickup CreateInteractiveButton(ItemType pickupItem, RoomType spawnRoom, string Id, float PickupTime = 1f, bool HasGravity = true, bool HasObjectCollision = true, Vector3? offset = null, Vector3? scale = null, Quaternion? rotation = null)
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

            if (p.GameObject.GetComponent<Rigidbody>() != null && HasObjectCollision == false)
            {
                Rigidbody rg = p.GameObject.GetComponent<Rigidbody>();
                rg.isKinematic = false;
            }
            else if (p.GameObject.GetComponent<Rigidbody>() != null && HasObjectCollision == true)
            {
                Rigidbody rg = p.GameObject.GetComponent<Rigidbody>();
                rg.isKinematic = true;
            }

            p.GameObject.AddComponent<InteractiveButton>();
            p.PickupTime = PickupTime;

            InteractiveButton? i = p.GameObject.GetComponent<InteractiveButton>();
            i.ButtonGameObject = p.GameObject;
            i.ButtonPickup = p;
            i.IsUsingTextID = true;
            i.TextID = Id;
            API.ExistingButtons.Add(i);

            //API.ValidButtons.Add(p);

            if (Plugin.Instance.Config.Debug == true)
                PluginAPI.Core.Log.Debug("DEBUGGING: ITEM: " + p.Type + " - POS: " + p.Position + " - ROOM: " + p.Room.Type + " - Interactive Button ID: " + i.ID);

            Events.EventArgs.ButtonCreatedEventArgs ev = new Events.EventArgs.ButtonCreatedEventArgs(p.Base);
            Events.Handlers.Button.OnButtonCreated(ev);
            return p;
        }
        
        public static Pickup CreateInteractiveButton(ItemType pickupItem, string Id, Vector3 position, float PickupTime = 1f, bool HasGravity = true, bool HasObjectCollision = true, Vector3? scale = null, Quaternion? rotation = null)
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

            if (p.GameObject.GetComponent<Rigidbody>() != null && HasObjectCollision == false)
            {
                Rigidbody rg = p.GameObject.GetComponent<Rigidbody>();
                rg.isKinematic = false;
            }
            else if (p.GameObject.GetComponent<Rigidbody>() != null && HasObjectCollision == true)
            {
                Rigidbody rg = p.GameObject.GetComponent<Rigidbody>();
                rg.isKinematic = true;
            }

            p.GameObject.AddComponent<InteractiveButton>();
            p.PickupTime = PickupTime;

            InteractiveButton? i = p.GameObject.GetComponent<InteractiveButton>();
            i.ButtonGameObject = p.GameObject;
            i.ButtonPickup = p;
            i.IsUsingTextID = true;
            i.TextID = Id;
            API.ExistingButtons.Add(i);

            //API.ValidButtons.Add(p);

            if (Plugin.Instance.Config.Debug == true)
                PluginAPI.Core.Log.Debug("DEBUGGING: ITEM: " + p.Type + " - POS: " + p.Position + " - ROOM: " + p.Room.Type + " - Interactive Button ID: " + i.ID);

            Events.EventArgs.ButtonCreatedEventArgs ev = new Events.EventArgs.ButtonCreatedEventArgs(p.Base);
            Events.Handlers.Button.OnButtonCreated(ev);
            return p;
        }

        #nullable enable
        public static CustomItem? CreateCustomItemPickup(uint customItemId)
        {
            CustomItem? t = CustomItem.Get(customItemId);

            if(t == null)
            {
                return t;
            }
           
            return null;
        }


        /*
         public static Primitive CreatePrimitiveButton(int Id, PrimitiveType primitiveType, RoomType roomType, Vector3? offset, Vector3? rotation, Vector3? scale)
        {
            Vector3? off = null;
            if(offset != null)
            {
                off = new Vector3(Room.Get(roomType).Position.x + offset.Value.x, Room.Get(roomType).Position.y + offset.Value.y, Room.Get(roomType).Position.z + offset.Value.z);
            }

            Primitive p = Primitive.Create(off ?? Room.Get(roomType).Position, rotation ?? Vector3.zero, scale ?? Vector3.one, true);
            PrimitiveButton pb = p.GameObject.gameObject.AddComponent<PrimitiveButton>();

            pb.IsUsingTextID = false;
            pb.ID = Id;
            pb.ButtonGameObject = pb.gameObject;
            pb.ButtonPrimitive = p;

            return p;
        }
        */

        public static Pickup CreatePickup(ItemType pickupItem, RoomType spawnRoom, bool HasGravity = true, float PickupTime = 1f, Vector3? offset = null, Vector3? scale = null, Quaternion? rotation = null)
        {
            Vector3? off = null;
            if (offset != null)
            {
                off = new Vector3(Room.Get(spawnRoom).Position.x + offset.Value.x, Room.Get(spawnRoom).Position.y + offset.Value.y, Room.Get(spawnRoom).Position.z + offset.Value.z);

            }
            Pickup p = Pickup.CreateAndSpawn(pickupItem, off ?? Room.Get(spawnRoom).Position, rotation ?? Quaternion.Euler(0, 0, 0));

            p.Scale = scale ?? Vector3.one;
            p.PickupTime = PickupTime;

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

            if (Plugin.Instance.Config.Debug == true)
                PluginAPI.Core.Log.Debug("DEBUGGING: ITEM: " + p.Type + " - POS: " + p.Position + " - ROOM: " + p.Room.Type);
            return p;
        }
        
        public static Pickup CreatePickup(ItemType pickupItem, RoomType spawnRoom, Vector3 position, bool HasGravity = true, float PickupTime = 1f, Vector3? scale = null, Quaternion? rotation = null)
        {
            Pickup p = Pickup.CreateAndSpawn(pickupItem, position, rotation ?? Quaternion.Euler(0, 0, 0));

            p.Scale = scale ?? Vector3.one;
            p.PickupTime = PickupTime;

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

            if (Plugin.Instance.Config.Debug == true)
                PluginAPI.Core.Log.Debug("DEBUGGING: ITEM: " + p.Type + " - POS: " + p.Position + " - ROOM: " + p.Room.Type);
            return p;
        }
    }
}
