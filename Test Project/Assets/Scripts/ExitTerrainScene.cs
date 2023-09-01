using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExitTerrainScene : MonoBehaviour
{
    public GameObject HamburgerScreen;
    public GameObject ExitPage;
    public void Hamburger()

    {
        HamburgerScreen.SetActive(true);
    }


    public void BackFromHamburger()
    {
        HamburgerScreen.SetActive(false);
    }

    public void Restart()
    {
        SceneManager.LoadScene("Main Scene");
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
        HamburgerScreen.SetActive(true);
    }

    public void Next()
    {
        SceneManager.LoadScene("8th_page");
    }
}
