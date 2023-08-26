using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LockManager : MonoBehaviour
{
    public Button playbutton;
    public Image playButtonImg;
    public Sprite[] sprites;
    public bool isPaused = false;
    public bool isLocked = false;
    public GameObject Model;
    public Slider Scaler, Rotator;
    public Button ScaleButton, RotateButton;
    Anim_Trial TA;
    //Tap_Anim TA;
    bool wasClickedScale = false;
    bool wasClickedRotate = false;
    public bool FirstTime = true;

    /* For Rebinding (Resetting) all animations once the 
     *  user presses on Play Button to start animation.*/
    //public Image EvaporationMessage, TapOnScreenEva;
    //public Image CloudFormMessage, TapOnScreenCloudForm;
    //public Image CloudMoveMessage, TapOnScreenCloudMove;
    //public Image PrecipitationMessage, TapOnScreenPreci;

    public Animator animator_LF;
    public Animator animator_OF;
    public Animator animator_C1;
    public Animator animator_C2;
    public Animator animator_C3;
    public Animator animator_AS;
    public Animator animator_AE;
    public Animator animator_AC;
    public ParticleSystem R1, R2, R3;

    private void Start()
    {
        TA = gameObject.GetComponent<Anim_Trial>();
        //TA = gameObject.GetComponent<Tap_Anim>();
        
    }


    public void Lock()
    {
        //Deactivate all Prompts (TextBoxes/images)
        //Reset ALL Animators here
        //Try implementing Pause Button
        //Debug.Log("Hi");
        // Remove Tap Interaction with UI Button
        
        if (!isLocked)
        {
            isLocked = true;
            playButtonImg.sprite = sprites[1];
            Scaler.gameObject.SetActive(false);
            Rotator.gameObject.SetActive(false);
            ScaleButton.gameObject.SetActive(false);
            RotateButton.gameObject.SetActive(false);
            Model.GetComponent<Lean.Touch.LeanDragTranslate>().enabled = false;

            if (FirstTime)
            {
                TA.PlayAnim();
                FirstTime = false;
            }
        
        }

        else
        {
            isLocked = false;
            playButtonImg.sprite = sprites[0];
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
            //TA.StopAnim();
            
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

