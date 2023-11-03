using Exiled.API.Features;

using Player = Exiled.Events.Handlers.Player;
using Server = Exiled.Events.Handlers.Server;

using MapEditorReborn.Commands.UtilityCommands;
using Exiled.API.Features.Pickups;
using System.Collections.Generic;
using InteractiveButtons.API.Events.Handlers;
using InteractiveButtons.API.Events.EventArgs;
using System;

namespace InteractiveButtons
{
    public sealed class Plugin : Plugin<Config>
    {
        public override string Author => "KadotCom";

        public override string Name => "InteractiveButtons";

        public override string Prefix => Name;

        public override Version Version => new Version(1,1,0);
        public override Version RequiredExiledVersion => new Version(8,2,0);
        public static Plugin Instance;

        private EventHandlers _handlers;

        public override void OnEnabled()
        {
            Instance = this;

            
            RegisterEvents();

            API.API.Init();

            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            UnregisterEvents();

            API.API.Destroy();
            
            Instance = null;

            base.OnDisabled();
        }

        private void RegisterEvents()
        {
            _handlers = new EventHandlers();
 
            Player.PickingUpItem += _handlers.OnInteracting;
            Server.RestartingRound += _handlers.OnRoundRestarting;
        }

        private void UnregisterEvents()
        {
            Player.PickingUpItem -= _handlers.OnInteracting;
            Server.RestartingRound -= _handlers.OnRoundRestarting;

            _handlers = null;
        }
    }
}