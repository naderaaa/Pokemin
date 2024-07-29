using TMPro;
using UnityEngine;

public class AbilityButton : MonoBehaviour
{
    public Ability? ability; // ability potentially on display
    public TextMeshProUGUI abilityName;
    public TextMeshProUGUI cost;

    public void SetButton(Ability ability)
    {
        gameObject.SetActive(true); // reveal the button
        this.ability = ability; // set the ability
        abilityName.text = ability.Name; // set the name
        switch (ability)
        {
            case ActiveAbility active: // if its an active ability, display its cost
                cost.text = active.cost.ToString();
                break;
            case PassiveAbility: // if its a passive ability, display "passive"
                cost.text = "passive";
                break;
        }
    }

    public void HideButton() // close the button
    {
        gameObject.SetActive(false);
        ability = null;
    }

    public void OnClick() // called when the button is clicked
    {
        if (ability.Owner.Team == GameManager.whosTurn) // ensures the piece is on the board + is on your team
        {
            ability.OnUse();
        }
    }

}
