using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData", menuName = "My Game/Enemy Data")]
public class EnemyData : ScriptableObject
{
    // Une variable pour chaque caractéristique de notre ennemi
    public string enemyName;
    public string description;
    public GameObject enemyModel;
    public int health = 100;
    public float speed = 1.5f;
    public int damage = 1;
}
