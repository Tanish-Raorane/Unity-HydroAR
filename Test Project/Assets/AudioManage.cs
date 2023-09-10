using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManage : MonoBehaviour
{
    public AudioSource ContinueButtonSound;
    public AudioSource BackButtonSound;
    private AudioSource BackgroundMusic;
    
    

    private void Awake()
    {
        scene_2_3 Obj = FindObjectOfType<scene_2_3>();
        Obj.BGMusic.Stop();
        Destroy(Obj.BGMusic);
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
