using JetBrains.Annotations;
using UnityEditor.Rendering;
using UnityEngine;

public abstract class Piece : IPurchasable
{
    public Team Team { get; set; }//which Team the piece is on
    public string Name { get; protected set; }//name of the piece (i.e. "Azurill", "Jirachi", "Galvantula")
    public int Tier { get; protected set; }//Tier of the piece in the shop
    public int MaxHP { get; protected set; }//set HP by default
    public int HP { get; set; }//current HP of piece, unit dies at 0
    public int Atk { get; set; }//damage it deals to opposing pokemon using a normal attack
    public int Speed { get; set; }//spaces it can move every turn
    public int Steps { get; set; }//spaces left it can move in this turn, reset after turn ends
    public int Range { get; set; }//how far the piece can attack
    public int NumPassive { get; protected set; }//number of passive abilities
    public string PassiveDesc { get; set; }//description of the passive abilities
    public int NumExtra { get; protected set; }//number of extra abilities
    public string ExtraDesc { get; set; }//description of the extra abilities
    public float Scale { get; protected set; } = 1.4f; // image scale

    public abstract string GetContents();//gets the image for the piece
    public Sprite Sprite { get; protected set; }
    public string GetInfo()//gets the info
    {
        Name = this.GetType().Name;// lol
        return $"{Name} - {HP}/{MaxHP} health\n{Atk} attack\n{Range} Range\nSteps remaining: {Steps}/{Speed}";
    }
}

public class Team//two Teams per game
{
    public string Name { get; set; }//name of the Team
    public Team(string name)
    {
        this.Name = name;
    }


}
public class Azurill : Piece
{


    public Azurill()
    {
        Tier = 1;

        MaxHP = 7;
        HP = MaxHP;
        Atk = 4;
        Speed = 1;
        Range = 1;
        Steps = Speed;


        NumPassive = 0;
        
        Sprite = Resources.Load<Sprite>(FilePaths.Azurill);

    }

    public override string GetContents()
    {
        return "azurill";
    }


}
public class Bulbasaur : Piece
{
    public Bulbasaur()
    {
        Tier = 1;

        MaxHP = 8;
        HP = MaxHP;
        Atk = 3;
        Speed = 1;
        Range = 2;
        Steps = Speed;
        NumPassive = 0;
        Sprite = Resources.Load<Sprite>(FilePaths.Bulbasaur);

    }
    public override string GetContents()
    {
        return "bulbasaur";
    }
}

public class Chiyu : Piece
{
    public Chiyu()
    {
        Tier = 6;

        MaxHP = 12;
        HP = MaxHP;

        Atk = 7;
        Speed = 2;
        Range = 2;
        Steps = Speed;
        NumPassive = 2;
        Sprite = Resources.Load<Sprite>(FilePaths.Chiyu);
    }

    public override string GetContents()
    {
        return "chi-yu";
    }
}

public class Corphish : Piece
{
    public Corphish()
    {
        Tier = 1;

        MaxHP = 8;
        HP = MaxHP;

        Atk = 4;
        Speed = 1;
        Range = 1;
        Steps = Speed;

        Sprite = Resources.Load<Sprite>(FilePaths.Corphish);
    }
    public override string GetContents()
    {
        return "corphish";
    }
}

public class Corsola : Piece
{
    public Corsola()
    {
        Tier = 2;
        MaxHP = 12;
        HP = MaxHP;

        Atk = 3;
        Speed = 1;
        Range = 1;
        Steps = Speed;

        NumPassive = 1;
        Sprite = Resources.Load<Sprite>(FilePaths.Corsola);
    }

    public override string GetContents()
    {
        return "corsola";
    }

}

public class Corsola_G : Piece
{
    public Corsola_G()
    {

        Tier = 2;
        MaxHP = 12;
        HP = MaxHP;

        Atk = 3;
        Speed = 1;
        Range = 1;
        Steps = Speed;

        Sprite = Resources.Load<Sprite>(FilePaths.Corsola_G);
    }

    public override string GetContents()
    {
        return "Galarian Corsola";
    }

}
public class Cottonee : Piece
{

    public Cottonee()
    {
        Tier = 1;

        MaxHP = 8;
        HP = MaxHP;

        Atk = 2;
        Speed = 2;
        Range = 2;
        Steps = Speed;
        NumPassive = 0;
        Sprite = Resources.Load<Sprite>(FilePaths.Cottonee);
    }

    public override string GetContents()
    {
        return "cottonee";
    }
}
public class Deino : Piece
{

    public Deino()
    {
        Tier = 1;

        MaxHP = 8;
        HP = MaxHP;

        Atk = 3;
        Speed = 1;
        Range = 1;
        Steps = Speed;
        Sprite = Resources.Load<Sprite>(FilePaths.Deino);

    }

    public override string GetContents()
    {
        return "deino";
    }
}
public class Dratini : Piece
{

    public Dratini()
    {
        Tier = 1;

        MaxHP = 7;
        HP = MaxHP;

        Atk = 3;
        Speed = 1;
        Range = 1;
        Steps = Speed;
        Scale = 1.2f;
        Sprite = Resources.Load<Sprite>(FilePaths.Dratini);


    }
    public override string GetContents()
    {
        return "dratini";
    }
}

public class Dreepy : Piece
{
    public Dreepy()
    {
        Tier = 1;

        MaxHP = 6;
        HP = MaxHP;

        Atk = 3;
        Speed = 1;
        Range = 1;
        Steps = Speed;
        Sprite = Resources.Load<Sprite>(FilePaths.Dreepy);

    }
    public override string GetContents()
    {
        return "dreepy";
    }
}
public class Dwebble : Piece
{
    public Dwebble()
    {
        Tier = 1;

        MaxHP = 8;
        HP = MaxHP;

        Atk = 3;
        Speed = 1;
        Range = 1;
        Steps = Speed;
        Sprite = Resources.Load<Sprite>(FilePaths.Dwebble);

    }

    public override string GetContents()
    {
        return "dwebble";
    }
}

public class Flygon : Piece
{
    public Flygon()
    {
        Tier = 4;

        MaxHP = 12;
        HP = MaxHP;

        Atk = 6;
        Speed = 2;
        Range = 2;
        Steps = Speed;

        Sprite = Resources.Load<Sprite>(FilePaths.Flygon);
    }

    public override string GetContents()
    {
        return "flygon";
    }
}

public class Glimmet : Piece
{
    public Glimmet()
    {
        Tier = 2;

        MaxHP = 8;
        HP = MaxHP;

        Atk = 5;
        Speed = 1;
        Range = 2;
        Steps = Speed;
        Sprite = Resources.Load<Sprite>(FilePaths.Glimmet);
    }

    public override string GetContents()
    {
        return "glimmet";
    }
}

public class Hatenna : Piece
{
    public Hatenna()
    {
        Tier = 1;

        MaxHP = 8;
        HP = MaxHP;

        Atk = 3;
        Speed = 1;
        Range = 2;
        Steps = Speed;
        Sprite = Resources.Load<Sprite>(FilePaths.Hatenna);

    }

    public override string GetContents()
    {
        return "hatenna";
    }
}

public class IronBundle : Piece
{
    public IronBundle()
    {
        Tier = 5;
        MaxHP = 9;
        HP = MaxHP;

        Atk = 6;
        Speed = 2;
        Range = 2;
        Steps = Speed;

        Sprite = Resources.Load<Sprite>(FilePaths.IronBundle);
    }

    public override string GetContents()
    {
        return "iron bundle";
    }
}

public class IronValiant : Piece
{
    public IronValiant()
    {
        Tier = 5;

        MaxHP = 10;
        HP = MaxHP;
        Atk = 7;
        Speed = 2;
        Range = 2;
        Steps = Speed;

        Sprite = Resources.Load<Sprite>(FilePaths.IronValiant);
    }
    public override string GetContents()
    {
        return "iron valiant";
    }

}

public class Ivysaur : Piece
{
    public Ivysaur()
    {
        Tier = 2;

        MaxHP = 10;
        HP = MaxHP;

        Atk = 4;
        Speed = 1;
        Range = 2;
        Steps = Speed;

        Sprite = Resources.Load<Sprite>(FilePaths.Ivysaur);
    }

    public override string GetContents()
    {
        return "ivysaur";
    }
}
public class Joltik : Piece
{
    public Joltik()
    {
        Tier = 1;

        MaxHP = 8;
        HP = MaxHP;

        Atk = 3;
        Speed = 1;
        Range = 2;
        Steps = Speed;
        Sprite = Resources.Load<Sprite>(FilePaths.Joltik);

    }

    public override string GetContents()
    {
        return "joltik";
    }

}
public class Litwick : Piece
{
    public Litwick()
    {
        Tier = 1;

        MaxHP = 8;
        HP = MaxHP;

        Atk = 3;
        Speed = 1;
        Range = 2;
        Steps = Speed;
        Sprite = Resources.Load<Sprite>(FilePaths.Litwick);

    }
    public override string GetContents()
    {
        return "litwick";
    }
}
public class Mareanie : Piece
{
    public Mareanie()
    {
        Tier = 1;

        MaxHP = 8;
        HP = MaxHP;

        Atk = 2;
        Speed = 1;
        Range = 1;
        Steps = Speed;
        Sprite = Resources.Load<Sprite>(FilePaths.Mareanie);

    }

    public override string GetContents()
    {
        return "mareanie";
    }
}

public class Marill : Piece
{
    public Marill()
    {
        Tier = 2;

        MaxHP = 9;
        HP = MaxHP;

        Atk = 5;
        Speed = 1;
        Range = 1;
        Steps = Speed;

        Sprite = Resources.Load<Sprite>(FilePaths.Marill);
    }
    public override string GetContents()
    {
        return "marill";
    }
}
public class Mawile : Piece
{
    public Mawile()
    {
        Tier = 2;

        MaxHP = 9;
        HP = MaxHP;

        Atk = 4;
        Speed = 1;
        Range = 1;
        Steps = Speed;
        Sprite = Resources.Load<Sprite>(FilePaths.Mawile);

    }
    public override string GetContents()
    {
        return "mawile";
    }
}

public class Porygon : Piece
{
    public Porygon()
    {
        Tier = 2;

        MaxHP = 10;
        HP = MaxHP;

        Atk = 4;
        Speed = 1;
        Range = 2;
        Steps = Speed;

        Sprite = Resources.Load<Sprite>(FilePaths.Porygon);
    }
    public override string GetContents()
    {
        return "porygon";
    }
}

public class Regieleki : Piece
{
    public Regieleki()
    {
        Tier = 6;

        MaxHP = 9;
        HP = MaxHP;

        Atk = 7;
        Speed = 4;
        Range = 2;
        Steps = Speed;

        Sprite = Resources.Load<Sprite>(FilePaths.Regieleki);
    }

    public override string GetContents()
    {
        return "regieleki";
    }

}

public class Shroomish : Piece
{
    public Shroomish()
    {
        Tier = 2;
        MaxHP = 9;
        HP = MaxHP;

        Atk = 2;
        Speed = 1;
        Range = 1;
        Steps = Speed;

        Sprite = Resources.Load<Sprite>(FilePaths.Shroomish);
    }

    public override string GetContents()
    {
        return "shroomish";
    }
}
public class SlitherWing : Piece
{
    public SlitherWing()
    {
        Tier = 5;

        MaxHP = 13;
        HP = MaxHP;

        Atk = 8;
        Speed = 1;
        Range = 1;
        Steps = Speed;

        Scale = 1.5f;

        Sprite = Resources.Load<Sprite>(FilePaths.SlitherWing);
    }

    public override string GetContents()
    {
        return "slither wing";
    }

}
public class Starly : Piece
{
    public Starly()
    {
        Tier = 1;

        MaxHP = 7;
        HP = MaxHP;

        Atk = 4;
        Speed = 1;
        Range = 1;
        Steps = Speed;
        Scale = 1.2f;
        Sprite = Resources.Load<Sprite>(FilePaths.Starly);
        

    }
    public override string GetContents()
    {
        return "starly";
    }
}

public class Staryu : Piece
{
    public Staryu()
    {
        Tier = 2;

        MaxHP = 7;
        HP = MaxHP;

        Atk = 4;
        Speed = 1;
        Range = 2;
        Steps = Speed;

        Sprite = Resources.Load<Sprite>(FilePaths.Staryu);
    }
    public override string GetContents()
    {
        return "staryu";
    }
}
public class Swablu : Piece
{
    public Swablu()
    {
        Tier = 1;

        MaxHP = 9;
        HP = MaxHP;

        Atk = 2;
        Speed = 1;
        Range = 1;
        Steps = Speed;
        Sprite = Resources.Load<Sprite>(FilePaths.Swablu);

    }
    public override string GetContents()
    {
        return "swablu";
    }
}
public class Tinkatink : Piece
{
    public Tinkatink()
    {
        Tier = 1;

        MaxHP = 8;
        HP = MaxHP;

        Atk = 2;
        Speed = 1;
        Range = 1;
        Steps = Speed;
        Sprite = Resources.Load<Sprite>(FilePaths.Tinkatink);

    }
    public override string GetContents()
    {
        return "tinkatink";
    }
}

public class Trapinch : Piece
{
    public Trapinch()
    {
        Tier = 2;

        MaxHP = 8;
        HP = MaxHP;

        Atk = 6;
        Speed = 1;
        Range = 1;
        Steps = Speed;

        Scale = 1.3f;
        Sprite = Resources.Load<Sprite>(FilePaths.Trapinch);

    }

    public override string GetContents()
    {
        return "trapinch";
    }
}

public class Victini : Piece
{
    public Victini()
    {
        Tier = 5;
        MaxHP = 13;
        HP = MaxHP;

        Atk = 5;
        Speed = 1;
        Range = 1;
        Steps = Speed;

        Sprite = Resources.Load<Sprite>(FilePaths.Victini);
    }
    public override string GetContents()
    {
        return "victini";
    }
}

public class Wochien : Piece
{
    public Wochien()
    {
        Tier = 6;
        MaxHP = 14;
        HP = MaxHP;

        Atk = 5;
        Speed = 1;
        Range = 2;
        Steps = Speed;

        Sprite = Resources.Load<Sprite>(FilePaths.Wochien);
    }
    public override string GetContents()
    {
        return "wo-chien";
    }
}