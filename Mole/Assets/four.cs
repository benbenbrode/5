using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class four : MonoBehaviour
{
    int ck = 0;
    public GameObject mole;
    public Transform molepos;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (ck == 0)
        {
            if (GameObject.Find("manger").GetComponent<molemanger>().mole == 4)
            {
                Instantiate(mole, molepos.transform.position, molepos.transform.rotation, GameObject.Find("Canvas").transform);
                ck = 1;
                Invoke("cker", GameObject.Find("manger").GetComponent<molemanger>().speed);
            }
        }
        if (ck == 0)
        {
            if (GameObject.Find("manger").GetComponent<molemanger>().mole2 == 4)
            {
                Instantiate(mole, molepos.transform.position, molepos.transform.rotation, GameObject.Find("Canvas").transform);
                ck = 1;
                Invoke("cker", GameObject.Find("manger").GetComponent<molemanger>().speed);
            }
        }
    }

    public void cker()
    {
        ck = 0;
    }


}
