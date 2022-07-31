using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mix : MonoBehaviour
{
    public Vector3 nowPosition;
    public Vector3 onePosition;
    public Vector3 twoPosition;
    public Vector3 threePosition;
    private  float step = 3f;


    int mixck = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mixck = Random.Range(1, 7);
        
    }

    public void mix1()
    {
        Invoke("round2", 1f);
        transform.position = Vector3.MoveTowards(nowPosition, onePosition, step);
    }
}
