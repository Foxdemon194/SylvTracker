using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float total;
    public float oldTotal;
    public float newTotal;
    public int bg;

    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        total = data.total;
    }

    public void LoadBG()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        bg = data.bg;
    }
}
