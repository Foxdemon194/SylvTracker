using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class CalculatorScript : MonoBehaviour
{

    public Text displayedTotal;
    public Button addButton;
    public InputField inputText;
    public Player player;
    public BackgroundManager backgroundManager;

    private void Start()
    {
        player.LoadPlayer();
        player.oldTotal = player.total;
        player.newTotal = player.oldTotal;
        displayedTotal.text = "$" + player.newTotal.ToString();
    }

    public void AddToTotal()
    {
        float newNum = float.Parse(inputText.text);
        player.newTotal += newNum;
        RoundNewTotal(player.newTotal);
        displayedTotal.text = "$" + player.newTotal.ToString();
        inputText.text = "";
    }

    float RoundNewTotal(float num)
    {
        float roundTotal = Mathf.Round(num * 100.0f) * 0.01f;

        return roundTotal;
    }

    public void UpdateOldTotal()
    {
        player.oldTotal = player.newTotal;
        player.total = player.newTotal;
        player.bg = backgroundManager.bG;
        player.SavePlayer();
    }

    public void UndoPlz()
    {
        player.newTotal = player.total;
        displayedTotal.text = "$" + player.newTotal.ToString();
    }
}
