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
        SceneManager.LoadScene(0);
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
}
