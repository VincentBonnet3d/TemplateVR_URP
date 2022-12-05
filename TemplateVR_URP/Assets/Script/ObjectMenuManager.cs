using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class ObjectMenuManager : MonoBehaviour
{
    public GameObject menu;
    
    public void ActiveMenu()
    {
        Debug.Log("Grab!");
        menu.SetActive(!menu.activeSelf);

    }

    public void DesactiveMenu()
    {
        Debug.Log("unGrab...");
        menu.SetActive(false);

    }

}
