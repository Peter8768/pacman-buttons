using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class load1 : MonoBehaviour
{
    public void load()
    {
        SceneManager.LoadScene("scene1");
        print ("scene 1");
    }
}
