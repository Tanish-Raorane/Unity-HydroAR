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
   
   

    public void Lock()
    {
        isLocked = !isLocked;
        if(isLocked)
        {
            lockbutton.GetComponentInChildren<TextMeshPro>().text = "Locked";
            Model.GetComponent<Scale>().enabled = false;
            Model.GetComponent<Lean.Touch.LeanDragTranslate>().enabled = false;
        }
        
        else
        {
            lockbutton.GetComponentInChildren<TextMeshPro>().text = "Unlocked";
            Model.GetComponent<Scale>().enabled = true;
            Model.GetComponent<Lean.Touch.LeanDragTranslate>().enabled = true;
        }
        
    }
}
