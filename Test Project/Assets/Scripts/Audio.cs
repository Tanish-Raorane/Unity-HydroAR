using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    //public AudioSource ThunderSound;
    public AudioSource RainSound;
    public ParticleSystem Rain1;
    bool FirstTime = true;

    public GameObject PreciMessage;
    public GameObject AfterPreciMessage;
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

            if(PreciMessage.activeInHierarchy || AfterPreciMessage.activeInHierarchy)
            {
                RainSound.volume = 0.3f;
            }
            
            else
            {
                RainSound.volume = 0.905f;
            }
        }



        if (!Rain1.isEmitting)
        {
            RainSound.Stop();
        }
    }
}
