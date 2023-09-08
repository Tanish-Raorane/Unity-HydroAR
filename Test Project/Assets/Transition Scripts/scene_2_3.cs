using UnityEngine;
using UnityEngine.SceneManagement;




public class scene_2_3 : MonoBehaviour
{

    public AudioSource BGMusic;
    private void Awake()
    {
        DontDestroyOnLoad(BGMusic);
    }
    public void LoadSecondScene()
    {
        SceneManager.LoadScene("3rd_page");
    }

}