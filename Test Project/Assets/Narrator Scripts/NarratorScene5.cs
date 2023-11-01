using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ReadSpeaker;

public class NarratorScene5 : MonoBehaviour
{
    public TTSSpeaker speaker;

    void Start()
    {
        TTS.Init();
        StartCoroutine(NarratorCoroutine());
    }

    IEnumerator NarratorCoroutine()
    {
        yield return new WaitForSecondsRealtime(1f);
        TTS.Say("One sunny day, as she was strolling near a sparkling stream, she noticed a mysterious raindrop shimmering, with magical colors.", speaker);
    }
}