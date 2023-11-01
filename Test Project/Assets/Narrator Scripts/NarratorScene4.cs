using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ReadSpeaker;

public class NarratorScene4 : MonoBehaviour
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
        TTS.Say("Once upon a time, in a small village nestled among green hills, there lived a curious and imaginative young student named Lily.", speaker);
    }
}
