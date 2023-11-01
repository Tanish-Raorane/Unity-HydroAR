using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ReadSpeaker;

public class NarratorScene6 : MonoBehaviour
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
        TTS.Say("Intrigued, Lily followed the raindrop as it danced through the air, leading her on an extraordinary adventure.", speaker);
    }
}