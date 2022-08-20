using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class choose : MonoBehaviour
{
    public int end = 0;
    public GameObject bt;
    GameObject c1;
    GameObject c2;
    GameObject c3;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(end == 1)
        {
            c1 = GameObject.Find("card1");
            c2 = GameObject.Find("card3");
            c3 = GameObject.Find("joker");
            Destroy(c1);
            Destroy(c3);
            Destroy(c2);
            bt.gameObject.SetActive(true);
        }
    }
}
