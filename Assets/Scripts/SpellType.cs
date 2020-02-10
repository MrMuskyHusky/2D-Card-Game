using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Spell", menuName = "Card/Type/Spell")]
public class SpellType : CardType
{
    public override void OnSetType(CardDisplay visuals)
    {
        base.OnSetType(visuals);
        //visuals.healthText.enabled = false;
        visuals.health.gameObject.SetActive(false);
        visuals.attack.gameObject.SetActive(false);
    }
}
