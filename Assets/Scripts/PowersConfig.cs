using UnityEngine;

public enum PowerRarity { Common, Rare, Epic, Legendary }

[CreateAssetMenu(fileName = "NewPower", menuName = "Roguelike/Power")]
public class PowerData : ScriptableObject
{
    public string powerName;
    public PowerRarity rarity;
    public Sprite icon;
    public string description;
}
