using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class choose : MonoBehaviour
{
    public int end = 0;
    public GameObject bt;
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
            bt.gameObject.SetActive(true);
        }
    }
}
