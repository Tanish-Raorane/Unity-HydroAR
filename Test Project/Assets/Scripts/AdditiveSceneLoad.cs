using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AdditiveSceneLoad : MonoBehaviour
{
    public GameObject Indi;
    
    
    public void LoadTerrain()
    {
        if (Indi.activeInHierarchy)
        {
            SceneManager.LoadScene(1, LoadSceneMode.Additive);
        }
    }
}
