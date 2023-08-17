using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LockManager : MonoBehaviour
{
    public Button lockbutton;
    public bool isLocked = false;
    public GameObject Model;

    private void Start()
    {
       
    }



    public void Lock()
    {
        Debug.Log("Hi");
        isLocked = !isLocked;
        if(isLocked)
        {
            lockbutton.GetComponentInChildren<TextMeshProUGUI>().text = "Locked";
            Model.GetComponent<Scale>().enabled = false;
            Model.GetComponent<Lean.Touch.LeanDragTranslate>().enabled = false;
        }
        
        else
        {
            lockbutton.GetComponentInChildren<TextMeshProUGUI>().text = "Unlocked";
            Model.GetComponent<Scale>().enabled = true;
            Model.GetComponent<Lean.Touch.LeanDragTranslate>().enabled = true;
        }
        
    }
}
