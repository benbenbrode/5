using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class molemanger : MonoBehaviour
{
    public int ck = 0;
    public int mole = 0;
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ck == 0)
        {
            if (GameObject.Find("manger").GetComponent<Timer>().LimitTime > 0.5)
            {
                mole = Random.Range(1, 4);
                ck = 1;
                Invoke("cker", 2f);
            }
        }

    }

    public void cker()
    {
        ck = 0;
    }
}
