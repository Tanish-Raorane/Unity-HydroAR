using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManage : MonoBehaviour
{
    public AudioSource ContinueButtonSound;
    public AudioSource BackButtonSound;

    public void ContinueSound()
    {
        ContinueButtonSound.Play();
    }

    public void BackSound()
    {
        BackButtonSound.Play();
    }
}
