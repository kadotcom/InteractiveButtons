using Exiled.API.Features;
using Exiled.API.Features.Pickups;
using Exiled.API.Features.Toys;
using Exiled.CustomItems.API.Features;
using Exiled.Events.EventArgs.Player;
using InteractiveButtons.API.Events.EventArgs;
using InteractiveButtons.API.Events.Handlers;
using InteractiveButtons.Component;
using MEC;
using UnityEngine;

namespace InteractiveButtons
{
    public class EventHandlers
    {
        public ButtonInteractedEventArgs buttonInteracting;

        public void OnRoundRestarting()
        {
            if (!Plugin.Instance.Config.InitApiUsingExternalPlugin)
            {
                API.API.ClearAllButtons();
            }
            else
            {
                API.API.ClearAllButtons();
                PluginAPI.Core.Log.Debug("Despite InitApiUsingExternalPlugin being set to true. We still need to clear all buttons on round restart. If ExistingButtons haven't been initiated, you should see a message about it.");
            }
        }

        public void OnInteracting(PickingUpItemEventArgs e)
        {
            if (e.Pickup == null)
                return;

            if (e.Pickup.GameObject.TryGetComponent(out InteractiveButton c))
            {

                buttonInteracting = new(e.Player, e.Pickup.Base);
                Button.OnButtonInteracted(buttonInteracting);
                
                e.IsAllowed = false;
            }
        }
    }
}