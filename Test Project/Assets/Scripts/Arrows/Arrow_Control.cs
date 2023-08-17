using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow_Control : MonoBehaviour
{
    public Animator animatorS;
    public Animator animatorE;
    int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        
        //gameObject.SetActive(false);

    }

    void DisableObject()
    {
        gameObject.SetActive(false);
        
    }

    void EnableObject()
    {
        gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            count++;
            if(count == 1)
            {
                animatorS.SetTrigger("Arrow_Sun");
            }
            
            if(count == 2)
            {
                animatorE.SetTrigger("Arrow_Evaporation");
            }
        }
    }
}
