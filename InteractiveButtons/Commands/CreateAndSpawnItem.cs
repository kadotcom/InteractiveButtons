using CommandSystem;
using System;
using RemoteAdmin;
using UnityEngine;
using Exiled.API.Features.Pickups;

namespace InteractiveButtons.Commands
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    class CreateAndSpawnItem : ICommand
    {
        public string Command { get; } = "csi";

        public string[] Aliases { get; } = { "createandspawn" };

        public string Description { get; } = "A Command that creates and spawns an item.";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (sender is PlayerCommandSender player)
            {
                Pickup p = API.Features.Spawn.CreateInteractiveButton(ItemType.SCP207, Exiled.API.Enums.RoomType.EzGateA, 12, false, new Vector3(0, 2, 0), new Vector3(1, 1, 1), Quaternion.Euler(0, 0, 0));
                if(p != null)
                {
                    response = $"{p.Info.ItemId} has spawned at {p.Transform.localPosition} in room {p.Room.Type}";
                    return false;
                }
                else
                {
                    response = $"Pickup failed to spawn.";
                    return false;
                }
            }
            else
            {
                response = "World!";
                return true;
            }
        }
    }
}