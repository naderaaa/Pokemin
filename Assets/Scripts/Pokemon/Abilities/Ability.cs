using UnityEngine;

public abstract class Ability
{
    public string Name { get; protected set; }
    public string Description { get; protected set; }
    public Piece Owner { get; set; }
    public abstract void OnUse();
}
