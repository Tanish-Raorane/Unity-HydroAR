using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AdditiveSceneLoad : MonoBehaviour
{
    public GameObject Indi;
    public GameObject backbutton;
 
    public void LoadScene(string SceneName)
    {

        backbutton.SetActive(false);
        SceneManager.LoadScene(SceneName, LoadSceneMode.Additive);
        
    }
}
