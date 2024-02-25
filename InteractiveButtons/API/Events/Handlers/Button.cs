using Exiled.Events.Features;
using InteractiveButtons.API.Events.EventArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveButtons.API.Events.Handlers
{
    using EventArgs;
    using Exiled.API.Extensions;
    public static class Button
    {
        public static Event<ButtonInteractedEventArgs> ButtonInteracted { get; set; } = new();

        internal static void OnButtonInteracted(ButtonInteractedEventArgs ev) => ButtonInteracted.InvokeSafely(ev);

        public static Event<ButtonCreatedEventArgs> ButtonCreated { get; set; } = new();

        internal static void OnButtonCreated(ButtonCreatedEventArgs ev) => ButtonCreated.InvokeSafely(ev);

        //public static Event<PrimitiveButtonInteractedEventArgs> PrimitiveButtonCreated { get; set; } = new();

        //internal static void OnPrimitiveButtonCreated(PrimitiveButtonInteractedEventArgs ev) => PrimitiveButtonCreated.InvokeSafely(ev);

    }
}
