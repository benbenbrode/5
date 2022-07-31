using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Life : MonoBehaviour
{
    public int Lifenum = 0;
    public GameObject LifeObject;
    int ck = 0;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(LifeObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (ck == 0)
        {
            if (Lifenum == 0)
            {
                SceneManager.LoadScene("GameOver");
                ck = 1; 
            }
        }
    }
}
