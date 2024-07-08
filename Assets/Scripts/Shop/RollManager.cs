using System.Collections.Generic;
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
        new Corsola(),
        new Corsola_G(),
        new Cottonee(),
        new Deino(),
        new Dratini(),
        new Dreepy(),
        new Dwebble(),
        new Flygon(),
        new Glimmet(),
        new Hatenna(),
        new IronBundle(),
        new IronValiant(),
        new Ivysaur(),
        new Jirachi(),
        new Joltik(),
        new Litwick(),
        new Magearna(),
        new Mantyke(),
        new Mareanie(),
        new Marill(),
        new Mawile(),
        new Porygon(),
        new Regieleki(),
        new Shaymin(),
        new Shroomish(),
        new SlitherWing(),
        new Sneasel(),
        new Starly(),
        new Staryu(),
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
