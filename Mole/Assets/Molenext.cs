using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Molenext : MonoBehaviour
{
    public GameObject x;
    public GameObject o;
    int ock = 0;
    int xck = 0;
    public int goal = 10;
    int gameclear = 0;

    // Start is called before the first frame update
    void Start()
    {
        goal = 10 + (GameObject.Find("BG").GetComponent<Bg>().difficulty / 3) * 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("manger").GetComponent<Timer>().LimitTime < 0.01)
        {
            if (xck == 0)
            {
                xcall();
                xck = 1;
                gameclear = 1;
            }
        }
        if(GameObject.Find("manger").GetComponent<molemanger>().score == 10 + (GameObject.Find("BG").GetComponent<Bg>().difficulty / 3) * 3)
        {
            if (gameclear == 0)
            {
                if (ock == 0)
                {
                    Invoke("ocall", 0.1f);
                    ock = 1;
                }
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
        GameObject.Find("manger").GetComponent<Timer>().gameclearck = 1;
        Invoke("round2", 2f);
    }

    public void round()
    {

        GameObject.Find("BG").GetComponent<Bg>().gameround = GameObject.Find("BG").GetComponent<Bg>().gameround + 1;
        GameObject.Find("Lifenum").GetComponent<Life>().Lifenum = GameObject.Find("Lifenum").GetComponent<Life>().Lifenum - 1;
        SceneManager.LoadScene("Round");
            
        
    }

    public void round2()
    {
        GameObject.Find("BG").GetComponent<Bg>().gameround = GameObject.Find("BG").GetComponent<Bg>().gameround + 1;
        GameObject.Find("BG").GetComponent<Bg>().difficulty = GameObject.Find("BG").GetComponent<Bg>().difficulty + 1;
        SceneManager.LoadScene("Round");

    }
}
