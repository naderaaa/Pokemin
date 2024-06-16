using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class Item : ShopElement
{
    //public int Tier;
   
    
}

public class HeldItem : Item
{

}

public class FedItem : Item
{
    // mouf hurts
    // i bit the side of my mouth and i dont want it to swell
    // teehee
    // i will
   
}
// WOOOOOOOOOOOOOOOOOOOOOOOOOO

public class Leftovers : HeldItem
{
    public Leftovers()
    {
        Tier = 1;
    }
}
