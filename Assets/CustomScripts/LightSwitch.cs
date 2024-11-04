using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    public void Toggle()
    {
        Debug.Log("Currently:" + gameObject.activeSelf);
        gameObject.SetActive(!gameObject.activeSelf);
    }
}