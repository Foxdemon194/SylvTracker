using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundManager : MonoBehaviour
{
    public Sprite[] backgrounds = new Sprite[3];
    public Sprite currentBackground;
    public GameObject backgroundPanel;
    public int bG = 0;
    public Player player;


    private void Start()
    {
        player.LoadBG();
        bG = player.bg;

        if (bG == 0)
        {
            currentBackground = backgrounds[1];
            backgroundPanel.GetComponent<Image>().sprite = currentBackground;
        }
        else if (bG == 1)
        {
            currentBackground = backgrounds[2];
            backgroundPanel.GetComponent<Image>().sprite = currentBackground;
        }
        else if (bG == 2)
        {
            currentBackground = backgrounds[0];
            backgroundPanel.GetComponent<Image>().sprite = currentBackground;
        }
        else
        {
            Debug.Log("Well this shouldn't have happened...ChangeBackground method in BackgroundManager script didn't do a thing right");            
        }

    }

    public int MyBG()
    {
        return bG;
    }

    public void ChangeBackground()
    {
        if(bG == 2)
        {
            currentBackground = backgrounds[1];
            bG = 0;
        }
        else if (bG == 0)
        {
            currentBackground = backgrounds[2];
            bG = 1;
        }
        else if (bG == 1)
        {
            currentBackground = backgrounds[0];
            bG = 2;
        }
        else
        {
            Debug.Log("Well this shouldn't have happened...ChangeBackground method in BackgroundManager script didn't do a thing right");
        }                
        backgroundPanel.GetComponent<Image>().sprite = currentBackground;
    }

}
