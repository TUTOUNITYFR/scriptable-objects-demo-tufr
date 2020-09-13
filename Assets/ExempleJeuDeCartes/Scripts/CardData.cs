using UnityEngine;

[CreateAssetMenu(fileName = "CardData", menuName = "My Game/Card Data")]
public class CardData : ScriptableObject
{
    // Une variable pour chaque caractéristique de notre carte
    public string cardName;
    public string cardDescription;
    public string cardAtk;
    public string cardHp;
    public string cardCost;
    public Sprite cardImage;
}
