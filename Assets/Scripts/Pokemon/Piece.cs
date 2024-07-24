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
    public Ability[] Abilities { get; set; } = new Ability[2];
    public Piece? PreEvolution { get; set; } = null; // does this pokemon have a preevolution? if so what is it
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
        Attack attack = new(Atk);
        Events.OnAttackStart?.Invoke(this, attack);
        target.ReceiveAttack(attack);
        Events.OnAttackEnd?.Invoke(this, attack);
        return attack;
    }

    public virtual Attack ReceiveAttack(Attack attack)
    {
        Events.OnTakeDamageStart?.Invoke(this, attack);
        HP -= attack.Damage;
        Events.OnTakeDamageEnd?.Invoke(this, attack);
        return attack;
    }
}
