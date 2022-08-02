using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mole : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Des", GameObject.Find("manger").GetComponent<molemanger>().speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Des()
    {
        Destroy(gameObject);
    }

    public void OnClick()
    {
            GameObject.Find("manger").GetComponent<molemanger>().score = GameObject.Find("manger").GetComponent<molemanger>().score + 1;
            Destroy(gameObject);
    }
}
