using UnityEngine;

public class Item : IPurchasable
{
    public int Tier { get; protected set; }//Tier of the item in the shop
    public Sprite Sprite { get; protected set; }


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

//public class Leftovers : HeldItem
//{
//    public Leftovers()
//    {
//        Tier = 1;
//
//    }
//}
