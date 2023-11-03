# InteractiveButtons
An EXILED plugin API that adds buttons by using items.

# Installation
1. Open the [Latest Releases](https://github.com/kadotcom/InteractiveButtons/releases/latest) tab.
2. Install the latest 'InteractiveButtons.dll' file.
3. Once it installs, put the InteractiveButtons.dll file in the ```EXILED/Plugins``` folder
4. Either start up your server if the server is offline, or restart your server if the server is online.
5. Start using the InteractiveButtons API.
   
# API - Functions
The InteractiveButtons plugin is an API to add buttons into SCP:SL by using items, and because of that, it has some functions needed to do certain things.

To create a button, you use the ```API.Features.Create.CreateInteractiveButton``` function, it does have some values attached to it, which you can see in the [CreateInteractiveButton example](#createinteractivebutton-example).

While this is a button API, we also have a way to create a Pickup, simply use the ```API.Features.Create.CreatePickup``` function, just like the CreateInteractiveButton function, this also has some values attached to it, which you can see in the [CreatePickup example](#createpickup-example).

# API - Events
InteractiveButtons needs events to run properly.

For interacting with buttons, use the ```API.Events.EventArgs.ButtonInteractedEventArgs``` event, if you need to see how to fully use it, you can view the [ButtonInteractedEventArgs example](#buttoninteractedeventargs-example).

You can also see when a button is created by using the ```API.Events.EventArgs.ButtonCreatedEventArgs``` event, if you need to see how to fully use it, you can view the [ButtonCreatedEventArgs example](#buttoncreatedeventargs-example).

# API Examples
### CreateInteractiveButton example

```csharp
public void OnRoundStart(){
  // CreateInteractiveButton(PickupItemType, SpawnRoom, ButtonId, ItemPickupTime = 1f, PickupHasGravity = true, ItemSpawnOffset = Vector3.zero, ItemScale = Vector3.one, ItemRotation = Quaternion.Euler(0, 0, 0))
  InteractiveButtons.API.Features.Create.CreateInteractiveButton(ItemType.SCP207, RoomType.EzGateA, 1, 1f, true, new Vector3(0, 2, 0), new Vector3(2, 2, 2), Quaternion.Euler(0, 0, 0));
}
```

### CreatePickup example

```csharp
public void OnRoundStart(){
  // CreatePickup(PickupItemType, SpawnRoom, PickupHasGravity = true, ItemPickupTime = 1f, ItemSpawnOffset = Vector3.zero, ItemScale = Vector3.one, ItemRotation = Quaternion.Euler(0, 0, 0))
  InteractiveButtons.API.Features.Create.CreatePickup(ItemType.Adrenaline, Exiled.API.Enums.RoomType.Lcz330, true, 1f, Vector3.zero, Vector3.one, Quaternion.Euler(0, 0, 0));
}
```

# Event Examples

### ButtonInteractedEventArgs example
```csharp
        public void SubscribeEvents()
        {
            Button.ButtonInteracted += ButtonInteracted;
        }

        public void ButtonInteracted(ButtonInteractedEventArgs ev)
        {
            if (ev.InteractiveButton.ID == 1)
            {
                ev.Player.Kill(Exiled.API.Enums.DamageType.Unknown);
            }
        }

        public void UnsubscribeEvents()
        {
            Button.ButtonInteracted -= ButtonInteracted;
        }
```

### ButtonCreatedEventArgs example
```csharp
        public void SubscribeEvents()
        {
            Button.ButtonCreated += ButtonCreated;
        }

        public void ButtonCreated(ButtonCreatedEventArgs ev)
        {
            if (ev.InteractiveButton.ID == 1)
            {
                PluginAPI.Core.Log.Debug("Hey look! I'm a special button");
            }
            else
            {
                PluginAPI.Core.Log.Debug("Hey look! I'm a button");
            }
        }

        public void UnsubscribeEvents()
        {
            Button.ButtonCreated -= ButtonCreated;
        }
```
