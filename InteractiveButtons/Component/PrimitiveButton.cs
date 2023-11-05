using Exiled.API.Features;
using Exiled.API.Features.Toys;
using InteractiveButtons.API.Events.EventArgs;
using InteractiveButtons.API.Events.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace InteractiveButtons.Component;

public class PrimitiveButton : MonoBehaviour
{
    public bool IsUsingTextID;
    public string TextID;
    public int ID;

    public Primitive ButtonPrimitive;
    public GameObject ButtonGameObject;
    //public void Update()
    //{
    //    if (Input.GetKeyUp(KeyCode.E))
    //    {
    //        bool FoundSuitablePlayer = false;
    //        foreach (Player p in Player.List)
    //        {
    //            if (FoundSuitablePlayer == true)
    //                return;
    //            PluginAPI.Core.Log.Debug(Vector3.Distance(p.Position, ButtonGameObject.transform.position).ToString());
    //            if (Vector3.Distance(p.Position, ButtonGameObject.transform.position) <= 0.5)
    //            {
    //                FoundSuitablePlayer = true;
    //                Interacting(p);
    //            }
    //        }
    //    }
    //}
    //public void Interacting(Player p)
    //{
    //    PrimitiveButtonInteractedEventArgs pbiev = new PrimitiveButtonInteractedEventArgs(p,ButtonPrimitive.Base);
    //    Button.OnPrimitiveButtonCreated(pbiev);
    //}
}
