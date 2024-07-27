using TMPro;
using UnityEngine;

public class AbilityButton : MonoBehaviour
{
    public Ability? ability;
    public TextMeshProUGUI abilityName;
    public TextMeshProUGUI cost;

    public void SetButton(Ability ability)
    {
        this.enabled = true;
        this.ability = ability;
        abilityName.text = ability.Name;
        switch (ability)
        {
            case ActiveAbility active:
                cost.text = active.cost.ToString(); 
                break;
            case PassiveAbility:
                cost.text = "passive";
                break;
        }
    }
    //public AbilityButton(Ability? ability)
    //{
    //    this.ability = ability;
    //    abilityName.text = ability.name;
    //    switch (ability)
    //    {
    //        case ActiveAbility a:
    //            cost.text = a.cost.;
    //            break;
    //
    //
    //    }
    //}
}
