using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SetShape : MonoBehaviour
{
    public GameObject Object;
    public Mesh Cube;
    public Mesh Sphere;

    public void SetTypeFromIndex(int index)
    {
        switch(index)
        {
            case 0:
                Object.GetComponent<MeshFilter>().sharedMesh = Cube;
                break;
            case 1:
                Object.GetComponent<MeshFilter>().sharedMesh = Sphere;
                break;
        }
    }
}
