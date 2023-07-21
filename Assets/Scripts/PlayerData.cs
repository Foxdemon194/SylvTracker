using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public float total;
    public int bg;

    public PlayerData(Player player)
    {
        total = player.total;
        bg = player.bg;
    }
}
