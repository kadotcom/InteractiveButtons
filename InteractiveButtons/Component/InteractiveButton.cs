using Exiled.API.Features.Pickups;
using Exiled.CustomItems.API.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace InteractiveButtons.Component;
public class InteractiveButton : MonoBehaviour
{
    public GameObject ButtonGameObject;
    public Pickup ButtonPickup;

    public bool IsUsingTextID;
    
    public int ID;
    public string TextID;


    /// Only for CustomItemButtons
    public CustomItem ButtonCustomItem;
    public uint CustomItemID;
    public bool IsCustomItemButton;
}
