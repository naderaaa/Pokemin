using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RollManager : MonoBehaviour
{
    private static readonly List<IPurchasable> potentialShopElements = new()
    {
        // pokemons
        new Azurill(),
        new Bulbasaur(),
        new Cottonee(),
        new Deino(),
        new Dratini(),
        new Dreepy(),
        new Dwebble(),
        new Hatenna(),
        new Joltik(),
        new Litwick(),
        new Mareanie(),
        new Mawile(),
        new Starly(),
        new Swablu(),
        new Tinkatink(),
        new SlitherWing(),
        new Trapinch(),

        // items
        // new Leftovers()
    };
    public static List<IPurchasable> PotentialShopElements { get => new(potentialShopElements); }
    
}
