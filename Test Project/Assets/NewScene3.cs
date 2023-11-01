using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using ReadSpeaker;

public class NewScene3 : MonoBehaviour
{
    public static string playernamestr;
    public static string playernamestr1;
    public TextMeshProUGUI playername;
    public TTSSpeaker speaker3;


    private void Start()
    {
        TTS.Init();
       
        playernamestr1 = "<b>" + playernamestr + "</b>";
       
        playername.text = "Hey "+playernamestr1+","+ " Welcome to the magical world of discovery and imagination, where learning comes to life!";

        StartCoroutine(Scene3Coroutine());
    }

    IEnumerator Scene3Coroutine()
    {
        yield return new WaitForSecondsRealtime(1f);
        TTS.Say("Hey " + playernamestr + "," + " Welcome to the magical world of discovery and imagination, where learning comes to life!", speaker3);

    }
}
