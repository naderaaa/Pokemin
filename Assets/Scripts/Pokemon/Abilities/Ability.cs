using UnityEngine;

public abstract class Ability
{
    public string Name { get; set; }
    public string Description { get; set; }
    public abstract void OnUse();
}
