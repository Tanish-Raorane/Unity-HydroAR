using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    public GameObject ExitPage;
    public GameObject HamburgerPage;
    public GameObject Warning;
    public GameObject Surface;
    public GameObject Lighting;
    public GameObject ARScreen1;
    public GameObject ARScreen2;
  
    public void Restart()
    {
        Camera.main.gameObject.SetActive(true);
        HamburgerPage.SetActive(false);
        Surface.SetActive(false);
        Lighting.SetActive(false);
        ARScreen1.SetActive(false);
        ARScreen2.SetActive(false);
        Warning.SetActive(true);
    }

    public void Quit()
    {
        ExitPage.SetActive(true);
    }

    public void Okay()
    {
        Application.Quit();
    }

    public void Cancel()
    {
        ExitPage.SetActive(false);
        HamburgerPage.SetActive(true);
    }
}