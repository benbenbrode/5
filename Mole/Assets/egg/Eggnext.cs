using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Eggnext : MonoBehaviour
{
    public GameObject x;
    public GameObject o;
   
    int xck = 0;
    int ock = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("event").GetComponent<Timer>().LimitTime < 0.01)
        {
            if (xck == 0)
            {
                GameObject.Find("event").GetComponent<Timer>().gameclearck = 1;
                xcall();
                xck = 1;
                
            }
        }

        if (GameObject.Find("event").GetComponent<egg>().eggnum2 == 0)
        {
            if (ock == 0 )
            {
               
                Invoke("ocall", 0.1f);
                ock = 1;
                
            }
        }
    }

    public void xcall()
    {
        Instantiate(x, new Vector3(0, 0, 0), Quaternion.identity);
        Invoke("round", 2f);
    }

    public void ocall()
    {
        Instantiate(o, new Vector3(0, 0, 0), Quaternion.identity);
        Invoke("round2", 2f);
        GameObject.Find("event").GetComponent<Timer>().gameclearck = 1;
    }
    public void round()
    {
        GameObject.Find("BG").GetComponent<Bg>().gameround = GameObject.Find("BG").GetComponent<Bg>().gameround + 1;
        GameObject.Find("Lifenum").GetComponent<Life>().Lifenum = GameObject.Find("Lifenum").GetComponent<Life>().Lifenum - 1;
        GameObject.Find("BG").GetComponent<Bg>().stageck = 2;
        SceneManager.LoadScene("Round");
           
    }

    public void round2()
    {
        GameObject.Find("BG").GetComponent<Bg>().stageck = 2;
        SceneManager.LoadScene("Round");
        GameObject.Find("BG").GetComponent<Bg>().gameround = GameObject.Find("BG").GetComponent<Bg>().gameround + 1;
        GameObject.Find("BG").GetComponent<Bg>().difficulty = GameObject.Find("BG").GetComponent<Bg>().difficulty + 1;
    }

}
