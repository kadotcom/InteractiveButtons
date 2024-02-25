using Exiled.API.Features;

using Player = Exiled.Events.Handlers.Player;
using Server = Exiled.Events.Handlers.Server;

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

        public override Version Version => new Version(1,4,0);
        public override Version RequiredExiledVersion => new Version(8,4,0);
        public static Plugin Instance;

        private EventHandlers _handlers;

        public override void OnEnabled()
        {
            Instance = this;

            
            RegisterEvents();
            if (!Config.InitApiUsingExternalPlugin)
            {
                API.API.Init();
            }
            else
            {
                PluginAPI.Core.Log.Debug("InitApiUsingExternalPlugin is set to true, meaning that the API will need to be initiated by an external plugin.");
            }

            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            UnregisterEvents();

            if (!Config.InitApiUsingExternalPlugin)
            {
                API.API.Destroy();
            }
            else
            {
                PluginAPI.Core.Log.Debug("InitApiUsingExternalPlugin is set to true, meaning that the API will need to be uninitiated by an external plugin.");
            }
            
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