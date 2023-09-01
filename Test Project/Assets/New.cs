using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class New : MonoBehaviour
{
    public InputField PlayerName;
    public void Level()
    {
        Debug.Log("Hi " + PlayerName.text);
        NewScene3.playernamestr = PlayerName.text;
    }
}
