using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScreenLoader : MonoBehaviour
{
    public GameObject Warning;
    public GameObject Surface;
    public GameObject Lighting;
    public GameObject ARScreen1;
    public GameObject ARScreen2;
    public GameObject HamburgerButton;
    public GameObject Indicator;

    public AudioSource WarningVoice;
    public AudioSource SurfaceVoice;
    public AudioSource LightingVoice;
    public AudioSource HoldTheDevice;


    private GameObject AudBut;

    private void Start()
    {
        WarningVoice.PlayDelayed(1.5f);
        //AudBut = GameObject.FindWithTag("AudioButton");
    }

    public void SurfaceScreenLoader()
    {
        Warning.SetActive(false);
        Surface.SetActive(true);
        WarningVoice.Stop();
        SurfaceVoice.PlayDelayed(0.5f);
    }

    public void LightingScreenLoader()
    {
        Surface.SetActive(false);
        Lighting.SetActive(true);
        WarningVoice.Stop();
        SurfaceVoice.Stop();
        LightingVoice.PlayDelayed(0.5f);
    }

    public void ARScreenLoader()
    {
        if (!Indicator.activeInHierarchy)
        {
            Lighting.SetActive(false);
            ARScreen1.SetActive(true);
            WarningVoice.Stop();
            SurfaceVoice.Stop();
            LightingVoice.Stop();
            HoldTheDevice.PlayDelayed(0.5f);
        }

        else
        {
            Lighting.SetActive(false);
            ARScreen2.SetActive(true);
            WarningVoice.Stop();
            SurfaceVoice.Stop();
            LightingVoice.Stop();
            HoldTheDevice.Stop();
        }
    }

    
    public void BackToWarning()
    {
        Surface.SetActive(false);
        Warning.SetActive(true);
        WarningVoice.Stop();
        SurfaceVoice.Stop();
        LightingVoice.Stop();
        HoldTheDevice.Stop();
    }
    public void BackToSurface()
    {
        Lighting.SetActive(false);
        Surface.SetActive(true);
        WarningVoice.Stop();
        SurfaceVoice.Stop();
        LightingVoice.Stop();
        HoldTheDevice.Stop();
    }
    public void BackToLightingFromAR1()
    {
        ARScreen1.SetActive(false);
        Lighting.SetActive(true);
        WarningVoice.Stop();
        SurfaceVoice.Stop();
        LightingVoice.Stop();
        HoldTheDevice.Stop();
    }

    public void BackToLightingFromAR2()
    {
        ARScreen2.SetActive(false);
        ARScreen1.SetActive(false);
        Lighting.SetActive(true);
        WarningVoice.Stop();
        SurfaceVoice.Stop();
        LightingVoice.Stop();
        HoldTheDevice.Stop();
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
}
