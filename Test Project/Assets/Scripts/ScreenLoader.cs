using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenLoader : MonoBehaviour
{
    public GameObject Warning;
    public GameObject Surface;
    public GameObject Lighting;
    public GameObject ARScreen1;
    public GameObject ARScreen2;
    public GameObject Indicator;
    public void SurfaceScreenLoader()
    {
        Warning.SetActive(false);
        Surface.SetActive(true);
    }
    
    public void LightingScreenLoader()
    {
        Surface.SetActive(false);
        Lighting.SetActive(true);
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

    //public void HamburgerButton()
    //{
    //    Surface.SetActive(false);
    //}

}
