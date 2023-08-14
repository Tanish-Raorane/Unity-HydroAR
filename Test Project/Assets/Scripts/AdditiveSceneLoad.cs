using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AdditiveSceneLoad : MonoBehaviour
{
    GameObject Indi;
    void Start()
    {
        Indi = GameObject.Find("PlaceIndicator");
    }
    
    public void LoadTerrain()
    {
        if (Indi.activeInHierarchy)
        {
            SceneManager.LoadScene(1, LoadSceneMode.Additive);
        }
    }
}
