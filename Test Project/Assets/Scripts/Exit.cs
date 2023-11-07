using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    public GameObject ExitPage;
    public GameObject HamburgerPage;
    public GameObject Warning;
    public GameObject Surface;
    public GameObject Lighting;
    public GameObject ARScreen1;
    public GameObject ARScreen2;
    public string TerrainScene;

    ScreenLoader screenloader;

    private void Start()
    {
        screenloader = gameObject.GetComponent<ScreenLoader>();
    }

    public void Restart()
    {
        
        HamburgerPage.SetActive(false);
        Surface.SetActive(false);
        Lighting.SetActive(false);
        ARScreen1.SetActive(false);
        ARScreen2.SetActive(false);
        Warning.SetActive(true);
        screenloader.SurfaceVoice.Stop();
        screenloader.LightingVoice.Stop();
        screenloader.HoldTheDevice.Stop();
        screenloader.WarningVoice.PlayDelayed(1f);
        

        if (SceneManager.GetSceneByName(TerrainScene).isLoaded)
        {
            //SceneManager.UnloadSceneAsync(1);
            SceneManager.LoadScene("Main Scene");
           
        }
        
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