using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Molenext : MonoBehaviour
{
    int ck = 0;
    public GameObject x;
    public GameObject o;
    
    // Start is called before the first frame update
    void Start()
    {
        //Invoke("xcall", 10f);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("manger").GetComponent<Timer>().LimitTime < 0.1)
        {
            xcall();
        }
        if(GameObject.Find("manger").GetComponent<molemanger>().score == 5)
        {
            ck = 1;
            Invoke("ocall", 0.1f);
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
        if (ck == 0)
        {
            GameObject.Find("Lifenum").GetComponent<Life>().Lifenum = GameObject.Find("Lifenum").GetComponent<Life>().Lifenum - 1;
            SceneManager.LoadScene("Round");
            
        }
    }

    public void round2()
    {
        GameObject.Find("BG").GetComponent<Bg>().gameround = GameObject.Find("BG").GetComponent<Bg>().gameround + 1;
        SceneManager.LoadScene("Round");

    }
}
