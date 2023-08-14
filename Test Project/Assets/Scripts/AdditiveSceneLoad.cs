using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AdditiveSceneLoad : MonoBehaviour
{
    public void LoadTerrain()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Additive);
    }
}
