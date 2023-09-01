using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadSecondScene()
    {
        SceneManager.LoadScene("2nd_page");
    }
}
