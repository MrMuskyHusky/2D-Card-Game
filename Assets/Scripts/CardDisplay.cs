using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    public Card card;

    [Header("Text Elements")]
    public Text nameText;
    public Text descriptionText, healthText, costText, attackText;
    [Header("Image Elements")]
    public Image attack;
    public Image health;
    public Image icon;
    public Image background, baseUI;
    public GameObject prefab;
    void Start()
    {
        nameText.text = card.name;
        descriptionText.text = card.description;
        healthText.text = card.health.ToString();
        costText.text = card.cost.ToString();
        attackText.text = card.attack.ToString();
        icon.sprite = card.icon;
        background.sprite = card.background;
        card.cardType.OnSetType(this);
    }
}
