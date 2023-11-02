using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NarratorScene2 : MonoBehaviour
{
    public AudioSource narrator;
   
    void Start()
    {
        narrator.PlayDelayed(2.5f);
    }

    
}
