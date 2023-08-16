using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockManager : MonoBehaviour
{
   

    public void Lock()
    {
        gameObject.GetComponent<Scale>().enabled = false;
        //gameObject.GetComponent<Lean.Touch>().enabled = false;
    }
}
