using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Property : MonoBehaviour
{
    public GameObject Hamburger_Settings;
    public GameObject Credits_Canvas;
    public GameObject Privacy_Policy;
    public GameObject Info_Page;

    public void ToCredit()
    {
        Credits_Canvas.SetActive(true);
        Hamburger_Settings.SetActive(false);
    }

    public void ToPrivacy()
    {
        Privacy_Policy.SetActive(true);
        Hamburger_Settings.SetActive(false);
    }

    public void ToAbout()
    {
        Info_Page.SetActive(true);
        Hamburger_Settings.SetActive(false);
    }

    public void Back()
    {
        Credits_Canvas.SetActive(false);
        Privacy_Policy.SetActive(false);
        Info_Page.SetActive(false);
        Hamburger_Settings.SetActive(true);
    }
}
