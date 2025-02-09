using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerAmplification : MonoBehaviour
{
    public void ApplyPower(PowerData power)
    {

        switch (power.powerName)
        {
            case "Damage Boost":
                Debug.Log("Damage + 10");
                break;
            case "Health Increase":
                Debug.Log("health + 10");
                break;
            case "Speed Boost":
                Debug.Log("Speed + 10");
                break;
            default:
                Debug.Log("Unknown Power Applied!");
                break;
        }
    }
}
