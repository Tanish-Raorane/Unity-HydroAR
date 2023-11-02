using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NarratorScene4 : MonoBehaviour
{
    public AudioSource narrator;

    void Start()
    {
        narrator.PlayDelayed(1f);
    }
}


