using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameStart : MonoBehaviour
{
    public bool startcker = false;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("wait", 1);
    }




    public void onclik()
    {
        if (startcker)
        {
            SceneManager.LoadScene("Round");
        }
    }
    void wait()
    {
        startcker = true;
    }
}
