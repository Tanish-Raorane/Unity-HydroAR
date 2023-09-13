using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioButtonCont : MonoBehaviour
{
    bool isOn = true;
    GameObject BGM;

    public Image AudioButtonImg;
    public Sprite[] sprites;
    void Start()
    {
        BGM = GameObject.FindWithTag("Audio");
        if (BGM.activeInHierarchy)
        {
            AudioButtonImg.sprite = sprites[0];
        }
        else
        {
            AudioButtonImg.sprite = sprites[1];
        }
        
        
    }

    public void ONPress()
    {
        if (BGM.activeInHierarchy)
        {
                AudioButtonImg.sprite = sprites[1];
                BGM.SetActive(false);            
        }

        else
        {
            AudioButtonImg.sprite = sprites[0];
            BGM.SetActive(true);
        }    
    }
    
    

    
    void Update()
    {
        
    }
}
