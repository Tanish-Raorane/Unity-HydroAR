using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ReadSpeaker;

public class NarratorController : MonoBehaviour
{
    public TTSSpeaker speaker;
    
    void Start()
    {
        TTS.Init();
        StartCoroutine(SpeakerCoroutine());
        
    }

    IEnumerator SpeakerCoroutine()
    {
        yield return new WaitForSecondsRealtime(3f);
        TTS.Say("Hi, I'm Lily!! What's your name friend?", speaker);

    }
}
