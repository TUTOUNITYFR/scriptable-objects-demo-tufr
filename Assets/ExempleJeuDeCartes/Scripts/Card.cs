using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    // Références aux textes et à l'image de mon UI de carte
    public Text nameText;
    public Text descriptionText;
    public Text atkText;
    public Text hpText;
    public Text costText;
    public Image image;

    // ScriptableObject avec les informations de la carte
    public CardData cardData; 

    void Start()
    {
        // Envoi des données du ScriptableObject aux éléments de UI
        nameText.text = cardData.name;
        descriptionText.text = cardData.cardDescription;
        atkText.text = cardData.cardAtk;
        hpText.text = cardData.cardHp;
        costText.text = cardData.cardCost;
        image.sprite = cardData.cardImage;
    }
}
