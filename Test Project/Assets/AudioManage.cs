using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManage : MonoBehaviour
{
    public AudioSource ContinueButtonSound;
    public AudioSource BackButtonSound;
    private GameObject BackgroundMusic;
    
    

    private void Awake()
    {
        BackgroundMusic = GameObject.FindWithTag("Audio");
        if(BackgroundMusic != null)
        {
            BackgroundMusic.SetActive(false);
        }
    }


    
    public void ContinueSound()
    {
        ContinueButtonSound.Play();
    }

    public void BackSound()
    {
        BackButtonSound.Play();
    }
}
