using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ReadSpeaker;

public class narratorScene8 : MonoBehaviour
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
        TTS.Say("Great job! We've successfully explored the water cycle. Let's test our understanding with a fun quiz now!", speaker);
    }
}