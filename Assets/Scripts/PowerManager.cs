using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class PowerManager : MonoBehaviour
{
    public List<PowerData> allPowers;

    public PowerData[] GetRandomPowers()
    {
        if (allPowers.Count < 3)
        {
            Debug.Log("Not enough unique powers!");
            return null;
        }

        List<PowerData> availablePowers = new List<PowerData>(allPowers);
        PowerData[] chosenPowers = new PowerData[3];

        for (int i = 0; i < 3; i++)
        {
            PowerData selectedPower = GetRandomPowerByRarity(availablePowers);
            chosenPowers[i] = selectedPower;
            availablePowers.Remove(selectedPower);
        }

        return chosenPowers;
    }

    private PowerData GetRandomPowerByRarity(List<PowerData> powerPool)
    {
        List<PowerData> weightedList = new List<PowerData>();

        foreach (var power in powerPool)
        {
            int weight = GetRarityWeight(power.rarity);
            for (int i = 0; i < weight; i++)
            {
                weightedList.Add(power);
            }
        }

        return weightedList[Random.Range(0, weightedList.Count)];
    }

    private int GetRarityWeight(PowerRarity rarity)
    {
        return rarity switch
        {
            PowerRarity.Common => 6,
            PowerRarity.Rare => 3,
            PowerRarity.Epic => 2,
            PowerRarity.Legendary => 1

        };
    }
}