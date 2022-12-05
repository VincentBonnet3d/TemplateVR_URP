using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public string sceneToLoad;
     public void OnRestartButtonClick(){

        SceneManager.LoadScene(sceneToLoad);
     }
}
