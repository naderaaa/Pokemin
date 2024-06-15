using UnityEngine;

public abstract class Piece
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
    public Sprite PieceSprite { get; protected set; }
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
        MaxHP = 7;
        HP = MaxHP;
        Atk = 4;
        Speed = 1;
        Range = 1;
        Steps = Speed;
        NumPassive = 0;
        
        PieceSprite = Resources.Load<Sprite>(FilePaths.Azurill);

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
        MaxHP = 8;
        HP = MaxHP;
        Atk = 3;
        Speed = 1;
        Range = 2;
        Steps = Speed;
        NumPassive = 0;
        PieceSprite = Resources.Load<Sprite>(FilePaths.Bulbasaur);

    }
    public override string GetContents()
    {
        return "bulbasaur";
    }
}
public class Cottonee : Piece
{

    public Cottonee()
    {
        MaxHP = 8;
        HP = MaxHP;

        Atk = 2;
        Speed = 2;
        Range = 2;
        Steps = Speed;
        NumPassive = 0;
        PieceSprite = Resources.Load<Sprite>(FilePaths.Cottonee);
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
        MaxHP = 8;
        HP = MaxHP;

        Atk = 3;
        Speed = 1;
        Range = 1;
        Steps = Speed;
        PieceSprite = Resources.Load<Sprite>(FilePaths.Deino);

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
        MaxHP = 7;
        HP = MaxHP;

        Atk = 3;
        Speed = 1;
        Range = 1;
        Steps = Speed;
        Scale = 1.2f;
        PieceSprite = Resources.Load<Sprite>(FilePaths.Dratini);


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
        MaxHP = 6;
        HP = MaxHP;

        Atk = 3;
        Speed = 1;
        Range = 1;
        Steps = Speed;
        PieceSprite = Resources.Load<Sprite>(FilePaths.Dreepy);

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
        MaxHP = 8;
        HP = MaxHP;

        Atk = 3;
        Speed = 10; // fix this later lmao
        Range = 1;
        Steps = Speed;
        PieceSprite = Resources.Load<Sprite>(FilePaths.Dwebble);

    }

    public override string GetContents()
    {
        return "dwebble";
    }
}

public class Hatenna : Piece
{
    public Hatenna()
    {
        MaxHP = 8;
        HP = MaxHP;

        Atk = 3;
        Speed = 1;
        Range = 2;
        Steps = Speed;
        PieceSprite = Resources.Load<Sprite>(FilePaths.Hatenna);

    }

    public override string GetContents()
    {
        return "hatenna";
    }
}
public class Joltik : Piece
{
    public Joltik()
    {
        MaxHP = 8;
        HP = MaxHP;

        Atk = 3;
        Speed = 1;
        Range = 2;
        Steps = Speed;
        PieceSprite = Resources.Load<Sprite>(FilePaths.Joltik);

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
        MaxHP = 8;
        HP = MaxHP;

        Atk = 3;
        Speed = 1;
        Range = 2;
        Steps = Speed;
        PieceSprite = Resources.Load<Sprite>(FilePaths.Litwick);

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
        MaxHP = 8;
        HP = MaxHP;

        Atk = 2;
        Speed = 1;
        Range = 1;
        Steps = Speed;
        PieceSprite = Resources.Load<Sprite>(FilePaths.Mareanie);

    }

    public override string GetContents()
    {
        return "mareanie";
    }
}
public class Mawile : Piece
{
    public Mawile()
    {
        MaxHP = 9;
        HP = MaxHP;

        Atk = 4;
        Speed = 1;
        Range = 1;
        Steps = Speed;
        PieceSprite = Resources.Load<Sprite>(FilePaths.Mawile);

    }
    public override string GetContents()
    {
        return "mawile";
    }
}
public class Starly : Piece
{
    public Starly()
    {
        MaxHP = 7;
        HP = MaxHP;

        Atk = 4;
        Speed = 1;
        Range = 1;
        Steps = Speed;
        Scale = 1.2f;
        PieceSprite = Resources.Load<Sprite>(FilePaths.Starly);
        

    }
    public override string GetContents()
    {
        return "starly";
    }
}
public class Swablu : Piece
{
    public Swablu()
    {
        MaxHP = 9;
        HP = MaxHP;

        Atk = 2;
        Speed = 1;
        Range = 1;
        Steps = Speed;
        PieceSprite = Resources.Load<Sprite>(FilePaths.Swablu);

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
        MaxHP = 8;
        HP = MaxHP;

        Atk = 2;
        Speed = 1;
        Range = 1;
        Steps = Speed;
        PieceSprite = Resources.Load<Sprite>(FilePaths.Tinkatink);

    }
    public override string GetContents()
    {
        return "tinkatink";
    }
}

public class SlitherWing : Piece
{
    public SlitherWing()
    {
        MaxHP = 13;
        HP = MaxHP;

        Atk = 8;
        Speed = 1;
        Range = 1;
        Steps = Speed;

        Scale = 1.5f;

        PieceSprite = Resources.Load<Sprite>(FilePaths.SlitherWing);
    }

    public override string GetContents()
    {
        return "slither wing";
    }

}
public class Trapinch : Piece
{
    public Trapinch()
    {
        MaxHP = 8;
        HP = MaxHP;

        Atk = 6;
        Speed = 1;
        Range = 1;
        Steps = Speed;

        Scale = 1.3f;
        PieceSprite = Resources.Load<Sprite>(FilePaths.Trapinch);

    }

    public override string GetContents()
    {
        return "trapinch";
    }
}