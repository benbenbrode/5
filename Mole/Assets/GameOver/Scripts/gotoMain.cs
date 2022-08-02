using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gotoMain : MonoBehaviour
{
    public GameObject bg;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject.Find("BG").GetComponent<Bg>().gameover = 1;
            SceneManager.LoadScene("Title");
        }
    }
}
