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
        new Chiyu(),
        new Corphish(),
        new Cottonee(),
        new Deino(),
        new Dratini(),
        new Dreepy(),
        new Dwebble(),
        new Glimmet(),
        new Hatenna(),
        new IronBundle(),
        new Ivysaur(),
        new Joltik(),
        new Litwick(),
        new Mareanie(),
        new Marill(),
        new Mawile(),
        new Porygon(),
        new SlitherWing(),
        new Starly(),
        new Swablu(),
        new Tinkatink(),
        new Trapinch(),
        new Victini(),
        new Wochien(),

        // items
        // new Leftovers()
    };
    public static List<IPurchasable> PotentialShopElements { get => new(potentialShopElements); }
    
}
