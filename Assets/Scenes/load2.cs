using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class load2 : MonoBehaviour
{
    public void loading()
    {
        SceneManager.LoadScene("SampleScene");
        print("SampleScene");
    }
}
