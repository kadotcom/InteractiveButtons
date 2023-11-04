using Exiled.API.Features;
using Exiled.API.Features.Pickups;
using Exiled.API.Features.Toys;
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
            API.API.ClearAllButtons();
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