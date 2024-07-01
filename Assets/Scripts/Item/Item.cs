using UnityEngine;

public class Item : IPurchasable
{
    public int Tier { get; protected set; }//Tier of the item in the shop
    public Sprite Sprite { get; protected set; }
}

