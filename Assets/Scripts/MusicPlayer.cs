using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    AudioSource audioSource;

    [SerializeField] float timer = 0;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void ClickSound()
    {
        audioSource.enabled = true ;
        timer = 2.1f;
    }

    private void Update()
    {
        if (timer <= 0f)
        {
            audioSource.enabled = false;
        }
        else 
        {
            timer -= Time.deltaTime;
        }
    }
}
