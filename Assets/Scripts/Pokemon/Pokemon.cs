using Assets.Scripts.Pokemon;
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
    public PokemonEvents Events { get; } = new PokemonEvents();
    public float Scale { get; protected set; } = 1.4f; // image scale
    public abstract string GetContents();//gets the image for the piece
    public Sprite Sprite { get; protected set; }

    public string GetInfo()//gets the info
    {
        Name = GetType().Name;// lol
        return $"{Name} - {HP}/{MaxHP} health\n{Atk} attack\n{Range} Range\nSteps remaining: {Steps}/{Speed}";
    }

    public virtual Attack Attack(Piece target)
    {
        Attack attack = new Attack(Atk);
        Events.OnAttackStart?.Invoke(this, attack);
        target.ReceiveAttack(attack);
        Events.OnAttackEnd?.Invoke(this, attack);
        return attack;
    }

    public virtual Attack ReceiveAttack(Attack attack)
    {
        Events.OnTakeDamageStart?.Invoke(this, attack);
        HP = -attack.Damage;
        Events.OnTakeDamageEnd?.Invoke(this, attack);
        return attack;
    }
}

public class Team//two Teams per game
{
    public string Name { get; set; }//name of the Team

    public int MaxEnergy { get; protected set; } = 6;

    public int Energy { get; set; }
    public Team(string name)
    {
        this.Name = name;
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
