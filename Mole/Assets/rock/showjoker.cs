using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showjoker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("Des", 3f);
    }

    void Des()
    {

        GameObject.Find("EventSystem").GetComponent<mix>().start = 1;
        gameObject.SetActive(false);
        
    }
}
