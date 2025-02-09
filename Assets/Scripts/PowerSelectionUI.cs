using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
[Serializable]
public class Card
{
    public Button powerButtons;
    public Image image;
    public TMP_Text powerTexts;
    public TMP_Text Rarity;
    public TMP_Text Des;

}
public class PowerSelectionUI : MonoBehaviour
{
    public GameObject panel;

    public Card[] cards;

    private PowerData[] currentPowers;
    public PowerManager powerManager;
    public PowerAmplification powerAmplification;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShowPowerSelection();
        }
    }

    public void ShowPowerSelection()
    {
        currentPowers = powerManager.GetRandomPowers();

        for (int i = 0; i < 3; i++)
        {
            cards[i].image.sprite = currentPowers[i].icon;
            cards[i].powerTexts.text = currentPowers[i].powerName;
            cards[i].Rarity.text = currentPowers[i].rarity.ToString();
            cards[i].Des.text = currentPowers[i].description;

            int index = i;
            cards[i].powerButtons.onClick.AddListener(() => SelectPower(index));
        }

        panel.SetActive(true);
    }

    public void SelectPower(int index)
    {
        Debug.Log("Selected Power: " + currentPowers[index].powerName);
        powerAmplification.ApplyPower(currentPowers[index]);

        panel.SetActive(false);
    }
}