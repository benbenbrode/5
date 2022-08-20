using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class egg : MonoBehaviour
{
    public int eggnum;
    public int eggnum2;
    public GameObject egg2;
    public GameObject egg3;
    public Transform egg2pos;
    int ck = 0;
    int ck1 = 0;

    // Start is called before the first frame update
    void Start()
    {
        eggnum = 10 + (GameObject.Find("BG").GetComponent<Bg>().difficulty / 3) * 5;
        eggnum2 = 10 + (GameObject.Find("BG").GetComponent<Bg>().difficulty / 3) * 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (eggnum == 0)
        {
            if (ck == 0)
            {
                Instantiate(egg2, egg2pos.transform.position, egg2pos.transform.rotation, GameObject.Find("Canvas").transform);
                ck = 1;
            }
        }

        if (eggnum2 == 0)
        {
            if (ck1 == 0)
            {
                GameObject.Find("event").GetComponent<Timer>().gameclearck = 1;
                Instantiate(egg3, egg2pos.transform.position, egg2pos.transform.rotation, GameObject.Find("Canvas").transform);
                ck1 = 1;
            }
        }
    }
}
