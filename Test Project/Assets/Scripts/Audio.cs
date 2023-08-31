using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    //public AudioSource ThunderSound;
    public AudioSource RainSound;
    public ParticleSystem Rain1;
    bool FirstTime = true;
    void Start()
    {

    }


    void Update()
    {

        if (Rain1.isEmitting)
        {
            if (!RainSound.isPlaying)
            {
                RainSound.PlayDelayed(3f);
            }
        }



        if (!Rain1.isEmitting)
        {
            RainSound.Stop();
        }
    }
}
