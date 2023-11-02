using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NarratorScene3 : MonoBehaviour
{
    public AudioSource narrator;

    void Start()
    {
        narrator.PlayDelayed(1f);
    }
}


