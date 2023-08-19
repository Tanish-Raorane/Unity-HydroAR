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
    public Button ScaleButton, RotateButton;
    bool wasClickedScale = false;
    bool wasClickedRotate = false;
    


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
            ScaleButton.gameObject.SetActive(false);
            RotateButton.gameObject.SetActive(false);
            //Scaler.enabled = false;
            //Rotator.enabled = false;
            Model.GetComponent<Lean.Touch.LeanDragTranslate>().enabled = false;
        }

        else
        {
            lockbutton.GetComponentInChildren<TextMeshProUGUI>().text = "Unlocked";
            // Model.GetComponent<Scale_Rotate>().enabled = true;
            if (wasClickedScale)
            {
                Scaler.gameObject.SetActive(true);
            }
            if (wasClickedRotate)
            {
                Rotator.gameObject.SetActive(true);
            }
            ScaleButton.gameObject.SetActive(true);
            RotateButton.gameObject.SetActive(true);
            //Scaler.enabled = true;
            //Rotator.enabled = true;
            Model.GetComponent<Lean.Touch.LeanDragTranslate>().enabled = true;
        }

    }

    public void OnClickScale()
    {
        if (!Scaler.gameObject.activeInHierarchy)
        {
            Scaler.gameObject.SetActive(true);
            wasClickedScale = true;
        }
        else
        {
            Scaler.gameObject.SetActive(false);
            wasClickedScale = false;
        }
    }

    public void OnClickRotate()
    {
        if (!Rotator.gameObject.activeInHierarchy)
        {
            Rotator.gameObject.SetActive(true);
            wasClickedRotate = true;
        }
        else
        {
            Rotator.gameObject.SetActive(false);
            wasClickedRotate = false;
        }
    }
}

