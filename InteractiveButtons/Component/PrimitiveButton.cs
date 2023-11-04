using Exiled.API.Features.Toys;
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
}
