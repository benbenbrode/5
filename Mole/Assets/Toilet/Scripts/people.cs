using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class people : MonoBehaviour
{
    private bool first = true;
    public int[] person;
    public int cnt = 0;
    GameObject man;
    GameObject woman;
    public GameObject good;
    public GameObject bad;
    public GameObject x;
    int ck = 0;
    // Start is called before the first frame update
    void Awake()
    {
        person = new int[8 + GameObject.Find("BG").GetComponent<Bg>().difficulty / 3]; 
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
        if (ck == 0)
        {
            if (GameObject.Find("timer").GetComponent<Timer>().LimitTime < 0.01)
            {
                GameObject.Find("man").GetComponent<manClick>().manb.interactable = false;
                GameObject.Find("woman").GetComponent<womanClick>().womanb.interactable = false;
                Instantiate(x, new Vector3(0, 0, 0), Quaternion.identity);
                Invoke("nextround",2f);
                ck = 1;
            }
        }
    }

    public void nextround()
    {
        GameObject.Find("BG").GetComponent<Bg>().gameround = GameObject.Find("BG").GetComponent<Bg>().gameround + 1;
        GameObject.Find("Lifenum").GetComponent<Life>().Lifenum = GameObject.Find("Lifenum").GetComponent<Life>().Lifenum - 1;
        SceneManager.LoadScene("Round");
    }
}
