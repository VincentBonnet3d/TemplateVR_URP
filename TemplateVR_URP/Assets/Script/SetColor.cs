using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SetColor : MonoBehaviour
{
    public GameObject Object;
    public Material Red;
    public Material White;
    public Material Grey;

    public void SetTypeFromIndex(int index)
    {
        switch(index)
        {
            case 0:
                Object.GetComponent<Renderer>().material = Red;
                break;
            case 1:
                Object.GetComponent<Renderer>().material = White;
                break;
            case 2:
                Object.GetComponent<Renderer>().material = Grey;
                break;
        }
    }
}
