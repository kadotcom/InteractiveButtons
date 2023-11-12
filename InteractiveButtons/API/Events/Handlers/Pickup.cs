using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveButtons.API.Events.Handlers
{
    using EventArgs;
    using Exiled.API.Extensions;
    using Exiled.Events.Features;

    public static class Pickup
    {
        public static Event<PickingUpCustomItemEventArgs> PickingUpCustomItem { get; set; } = new();

        internal static void OnPickingUpCustomItem(PickingUpCustomItemEventArgs ev) => PickingUpCustomItem.InvokeSafely(ev);
    }
}
