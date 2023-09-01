using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NewScene3 : MonoBehaviour
{
    public static string playernamestr;
    public TextMeshProUGUI playername;

    private void Start()
    {
        playername.text = "Hey "+playernamestr+","+ " Welcome to the magical world of discovery and imagination, where learning comes to life!";
    }
}
