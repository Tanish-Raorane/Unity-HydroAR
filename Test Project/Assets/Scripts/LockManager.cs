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
    public Slider Scaler, Rotator;



    public void Lock()
    {
        Debug.Log("Hi");
        isLocked = !isLocked;
        if (isLocked)
        {
            lockbutton.GetComponentInChildren<TextMeshProUGUI>().text = "Locked";
            //Model.GetComponent<Scale_Rotate>().enabled = false;
            Scaler.gameObject.SetActive(false);
            Rotator.gameObject.SetActive(false);
            //Scaler.enabled = false;
            //Rotator.enabled = false;
            Model.GetComponent<Lean.Touch.LeanDragTranslate>().enabled = false;
        }

        else
        {
            lockbutton.GetComponentInChildren<TextMeshProUGUI>().text = "Unlocked";
            // Model.GetComponent<Scale_Rotate>().enabled = true;
            Scaler.gameObject.SetActive(true);
            Rotator.gameObject.SetActive(true);
            //Scaler.enabled = true;
            //Rotator.enabled = true;
            Model.GetComponent<Lean.Touch.LeanDragTranslate>().enabled = true;
        }

    }
}
