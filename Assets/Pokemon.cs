using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public abstract class Pokemon : MonoBehaviour
{
    public Team Team { get; set; }//which team the piece is on
    public string Name { get; protected set; }//name of the piece (i.e. "Azurill", "Jirachi", "Galvantula")
    public int Tier { get; protected set; }//tier of the piece in the shop
    public int MaxHp { get; protected set; }//set Hp by default
    public int Hp { get; set; }//current Hp of piece, unit dies at 0
    public int Atk { get; set; }//damage it deals to opposing pokemon using a normal attack
    public int Speed { get; set; }//spaces it can move every turn
    public int Steps { get; set; }//spaces left it can move in this turn, reset after turn ends
    public int Range { get; set; }//how far the piece can attack
    public int NumPassive { get; protected set; }//number of passive abilities
    public string PassiveDesc { get; set; }//description of the passive abilities
    public int NumExtra { get; protected set; }//number of extra abilities
    public string ExtraDesc { get; set; }//description of the extra abilities

    public abstract string GetContents();//gets the image for the piece
    public string PieceSprite { get; protected set; }

    public Sprite Sprite { get; protected set; }
    public string GetInfo()//gets the info
    {
        Name = this.GetType().Name;// lol
        return $"{Name} - {Hp}/{MaxHp} health\n{Atk} attack\n{Range} Range\nsteps remaining: {Steps}/{Speed}";
    }

    public void Awake()
    {
        Sprite = Resources.Load<Sprite>(PieceSprite);
    }



}
public class Team//two teams per game
{
    public string Name { get; }//name of the team
    public Team(string name)
    {
        this.Name = name;
    }


}

public class Azurill : Pokemon
{


    public Azurill()
    {
        MaxHp = 7;
        Hp = MaxHp;
        Atk = 4;
        Speed = 1;
        Range = 1;
        Steps = 1;
        NumPassive = 0;
        PieceSprite = FilePaths.Azurill;

    }

    public override string GetContents()
    {
        return "azurill";
    }


}
public class Bulbasaur : Pokemon
{
    public Bulbasaur()
    {
        MaxHp = 8;
        Hp = MaxHp;
        Atk = 3;
        Speed = 1;
        Range = 2;
        Steps = 1;
        NumPassive = 0;
        PieceSprite = FilePaths.Bulbasaur;

    }
    public override string GetContents()
    {
        return "bulbasaur";
    }
}
public class Cottonee : Pokemon
{

    public Cottonee()
    {
        MaxHp = 8;
        Hp = MaxHp;

        Atk = 2;
        Speed = 2;
        Range = 2;
        Steps = 2;
        NumPassive = 0;
        PieceSprite = FilePaths.Cottonee;

    }

    public override string GetContents()
    {
        return "cottonee";
    }
}
public class Deino : Pokemon
{
    public Deino()
    {
        MaxHp = 8;
        Hp = MaxHp;

        Atk = 3;
        Speed = 1;
        Range = 1;
        Steps = 1;
        PieceSprite = FilePaths.Deino;

    }

    public override string GetContents()
    {
        return "deino";
    }
}
public class Dratini : Pokemon
{

    public Dratini()
    {
        MaxHp = 7;
        Hp = MaxHp;

        Atk = 3;
        Speed = 1;
        Range = 1;
        Steps = 1;
        PieceSprite = FilePaths.Dratini;


    }
    public override string GetContents()
    {
        return "dratini";
    }
}

public class Dreepy : Pokemon   
{
    public Dreepy()
    {
        MaxHp = 6;
        Hp = MaxHp;

        Atk = 3;
        Speed = 1;
        Range = 1;
        Steps = 1;
        PieceSprite = FilePaths.Dreepy;

    }
    public override string GetContents()
    {
        return "dreepy";
    }
}
public class Dwebble : Pokemon
{
    public Dwebble()
    {
        MaxHp = 8;
        Hp = MaxHp;

        Atk = 3;
        Speed = 10;
        Range = 1;
        Steps = Speed;
        PieceSprite = FilePaths.Dwebble;

    }

    public override string GetContents()
    {
        return "dwebble";
    }
}

public class Hatenna :  Pokemon
{
    public Hatenna()
    {
        MaxHp = 8;
        Hp = MaxHp;

        Atk = 3;
        Speed = 1;
        Range = 2;
        Steps = 1;
        PieceSprite = FilePaths.Hatenna;

    }

    public override string GetContents()
    {
        return "hatenna";
    }
}
public class Joltik : Pokemon
{
    public Joltik()
    {
        MaxHp = 8;
        Hp = MaxHp;

        Atk = 3;
        Speed = 1;
        Range = 2;
        Steps = 1;
        PieceSprite = FilePaths.Joltik;

    }

    public override string GetContents()
    {
        return "joltik";
    }

}
public class Litwick : Pokemon
{
    public Litwick()
    {
        MaxHp = 8;
        Hp = MaxHp;

        Atk = 3;
        Speed = 1;
        Range = 2;
        Steps = 1;
        PieceSprite = FilePaths.Litwick;

    }
    public override string GetContents()
    {
        return "litwick";
    }
}
public class Mareanie :     Pokemon
{
    public Mareanie()
    {
        MaxHp = 8;
        Hp = MaxHp;

        Atk = 2;
        Speed = 1;
        Range = 1;
        Steps = 1;
        PieceSprite = FilePaths.Mareanie;

    }

    public override string GetContents()
    {
        return "mareanie";
    }
}
public class Mawile : Pokemon
{
    public Mawile()
    {
        MaxHp = 9;
        Hp = MaxHp;

        Atk = 4;
        Speed = 1;
        Range = 1;
        Steps = 1;
        PieceSprite = FilePaths.Mawile;

    }
    public override string GetContents()
    {
        return "mawile";
    }
}
public class Starly : Pokemon
{
    public Starly()
    {
        MaxHp = 7;
        Hp = MaxHp;

        Atk = 4;
        Speed = 1;
        Range = 1;
        Steps = 1;
        PieceSprite = FilePaths.Starly;

    }
    public override string GetContents()
    {
        return "starly";
    }
}
public class Swablu : Pokemon
{
    public Swablu()
    {
        MaxHp = 9;
        Hp = MaxHp;

        Atk = 2;
        Speed = 1;
        Range = 1;
        Steps = 1;
        PieceSprite = FilePaths.Swablu;

    }
    public override string GetContents()
    {
        return "swablu";
    }
}
public class Tinkatink : Pokemon
{
    public Tinkatink()
    {
        MaxHp = 8;
        Hp = MaxHp;

        Atk = 2;
        Speed = 1;
        Range = 1;
        Steps = 1;
        PieceSprite = FilePaths.Tinkatink;

    }
    public override string GetContents()
    {
        return "tinkatink";
    }
}