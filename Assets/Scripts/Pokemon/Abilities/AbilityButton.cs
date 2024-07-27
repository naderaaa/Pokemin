using TMPro;
using UnityEngine;

public class AbilityButton : MonoBehaviour
{
    public Ability? ability;
    public TextMeshProUGUI abilityName;
    public TextMeshProUGUI cost;

    public void SetButton(Ability ability)
    {
        this.gameObject.SetActive(true);
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

    public void HideButton()
    {
        gameObject.SetActive(false);
        this.ability = null;

    }

    public void OnClick()
    {
        if (ability.Owner.Team == GameManager.whosTurn)
        {
            ability.OnUse();
        }
    }

}
