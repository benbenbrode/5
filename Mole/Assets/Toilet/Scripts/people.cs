using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class people : MonoBehaviour
{
    private bool first = true;
    public int[] person = new int[10];
    public int cnt = 0;
    GameObject man;
    GameObject woman;
    public GameObject good;
    public GameObject bad;
    // Start is called before the first frame update
    void Awake()
    {
        man = Resources.Load("Prefabs/Man") as GameObject;
        woman = Resources.Load("Prefabs/Woman") as GameObject;
        good = Resources.Load("Prefabs/O") as GameObject;
        bad = Resources.Load("Prefabs/X") as GameObject;
        int x = 0;
        for(int i = 0; i < person.Length; i++)
        {
            int a = Random.Range(1, 3);
            if(a == 1)
            {
                GameObject obj = MonoBehaviour.Instantiate(man);
                obj.name = i.ToString();
                Vector3 pos = new Vector3(x, -5, 0);
                obj.transform.position = pos;
            }
            else
            {
                GameObject obj = MonoBehaviour.Instantiate(woman);
                obj.name = i.ToString();
                Vector3 pos = new Vector3(x, -5, 0);
                obj.transform.position = pos;
            }
            if(first == true)
            {
                x += 12;
                first = false;
            }
            else
            {
                x += 3;
            }
            person[i] = a;
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
