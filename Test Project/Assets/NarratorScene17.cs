using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ReadSpeaker;

public class NarratorScene17 : MonoBehaviour
{
    public TTSSpeaker speaker;

    void Start()
    {
        TTS.Init();
        StartCoroutine(NarratorCoroutine());
    }

    IEnumerator NarratorCoroutine()
    {
        yield return new WaitForSecondsRealtime(1.5f);
        TTS.Say("Congratulations! You have completed the magical raindrop adventure and gained a deep understanding of the water cycle. Well done!", speaker);
    }
}