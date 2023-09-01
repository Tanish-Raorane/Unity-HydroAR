using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quit_Button : MonoBehaviour
{
    public void ExitNow()
    {
        Application.Quit();
    }

    public void ExploreAgain()
    {
        SceneManager.LoadScene("Main Scene");
    }
}
