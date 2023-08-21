using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AdditiveSceneLoad : MonoBehaviour
{
    public GameObject Indi;
 
    public void LoadScene(string SceneName)
    {
        
            SceneManager.LoadScene(SceneName, LoadSceneMode.Additive);
        
    }
}
