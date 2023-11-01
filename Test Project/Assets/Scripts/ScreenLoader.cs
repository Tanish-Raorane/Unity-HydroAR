using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using ReadSpeaker;

public class ScreenLoader : MonoBehaviour
{
    public GameObject Warning;
    public GameObject Surface;
    public GameObject Lighting;
    public GameObject ARScreen1;
    public GameObject ARScreen2;
    public GameObject HamburgerButton;
    public GameObject Indicator;

    private GameObject AudBut;

    public TTSSpeaker speaker;

    private void Start()
    {
        //AudBut = GameObject.FindWithTag("AudioButton");
        TTS.Init();
        StartCoroutine(WarningCoroutine());
    }

    public void SurfaceScreenLoader()
    {
        Warning.SetActive(false);
        Surface.SetActive(true);
        StartCoroutine(SurfaceScreenCoroutine());
        
        
    }

    public void LightingScreenLoader()
    {
        Surface.SetActive(false);
        Lighting.SetActive(true);
        StartCoroutine(LightingScreenCoroutine());
        
    }

    public void ARScreenLoader()
    {
        if (!Indicator.activeInHierarchy)
        {
            Lighting.SetActive(false);
            ARScreen1.SetActive(true);
        }

        else
        {
            Lighting.SetActive(false);
            ARScreen2.SetActive(true);
        }
    }

    public void BackToWarning()
    {
        Surface.SetActive(false);
        Warning.SetActive(true);
    }
    public void BackToSurface()
    {
        Lighting.SetActive(false);
        Surface.SetActive(true);
    }
    public void BackToLightingFromAR1()
    {
        ARScreen1.SetActive(false);
        Lighting.SetActive(true);
    }

    public void BackToLightingFromAR2()
    {
        ARScreen2.SetActive(false);
        ARScreen1.SetActive(false);
        Lighting.SetActive(true);
       
    }


    public void Hamburger()

    {
        //Camera.main.gameObject.SetActive(false);
        HamburgerButton.SetActive(true);
    }


    public void BackFromHamburger()
    {
        //Camera.main.gameObject.SetActive(true);
        HamburgerButton.SetActive(false);
    }

    public void BackFromWarning()  //From Warning To 6th_page
    {

        //AudBut.SetActive(false);
        SceneManager.LoadScene("6th_page");
    }

    IEnumerator WarningCoroutine()
    {
        yield return new WaitForSecondsRealtime(1.75f);
        TTS.Say("Warning. Before playing this AR game, find a safe and clear space where you can move around easily. Don't play near busy roads or high places like balconies or roofs. Always be aware of what's around you and stay safe!", speaker);
    }

    IEnumerator SurfaceScreenCoroutine()
    {
        yield return new WaitForSecondsRealtime(1f);
        TTS.Say("Pick a surface that is flat, and has texture on it.", speaker);
    } 
    IEnumerator LightingScreenCoroutine()
    {
        yield return new WaitForSecondsRealtime(1f);
        TTS.Say("Make sure the lighting is not too bright, or too dark.", speaker);
    }
}
