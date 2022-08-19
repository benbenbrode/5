using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class card1bt : MonoBehaviour
{
    public GameObject x;
    public GameObject o;
    public GameObject jack;
    public GameObject joker;
    public Transform card1pos;
    public Transform card2pos;
    public Transform card3pos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        if (GameObject.Find("Canvas").GetComponent<rocktimer>().gameclearck == 0)
        {
            if (GameObject.Find("EventSystem").GetComponent<mix>().jokercker == 1)
            {
                Instantiate(joker, card1pos.transform.position, card1pos.transform.rotation, GameObject.Find("Canvas").transform);
                Instantiate(jack, card2pos.transform.position, card2pos.transform.rotation, GameObject.Find("Canvas").transform);
                Instantiate(jack, card3pos.transform.position, card3pos.transform.rotation, GameObject.Find("Canvas").transform);
                Instantiate(o, new Vector3(0, 0, 0), Quaternion.identity);
                GameObject.Find("Canvas").GetComponent<rocktimer>().gameclearck = 1;
                Invoke("round2", 2f);
            }
            else if (GameObject.Find("EventSystem").GetComponent<mix>().jokercker == 2)
            {
                Instantiate(joker, card2pos.transform.position, card2pos.transform.rotation, GameObject.Find("Canvas").transform);
                Instantiate(jack, card1pos.transform.position, card1pos.transform.rotation, GameObject.Find("Canvas").transform);
                Instantiate(jack, card3pos.transform.position, card3pos.transform.rotation, GameObject.Find("Canvas").transform);
                Instantiate(x, new Vector3(0, 0, 0), Quaternion.identity);
                GameObject.Find("Canvas").GetComponent<rocktimer>().gameclearck = 1;
                Invoke("round", 2f);
            }
            else if (GameObject.Find("EventSystem").GetComponent<mix>().jokercker == 3)
            {
                Instantiate(joker, card3pos.transform.position, card3pos.transform.rotation, GameObject.Find("Canvas").transform);
                Instantiate(jack, card2pos.transform.position, card2pos.transform.rotation, GameObject.Find("Canvas").transform);
                Instantiate(jack, card1pos.transform.position, card1pos.transform.rotation, GameObject.Find("Canvas").transform);
                Instantiate(x, new Vector3(0, 0, 0), Quaternion.identity);
                GameObject.Find("Canvas").GetComponent<rocktimer>().gameclearck = 1;
                Invoke("round", 2f);
            }
        }
    }

    public void round()
    {
        GameObject.Find("BG").GetComponent<Bg>().gameround = GameObject.Find("BG").GetComponent<Bg>().gameround + 1;
        GameObject.Find("Lifenum").GetComponent<Life>().Lifenum = GameObject.Find("Lifenum").GetComponent<Life>().Lifenum - 1;
        GameObject.Find("BG").GetComponent<Bg>().stageck = 5;
        SceneManager.LoadScene("Round");

    }

    public void round2()
    {
        GameObject.Find("BG").GetComponent<Bg>().stageck = 5;
        SceneManager.LoadScene("Round");
        GameObject.Find("BG").GetComponent<Bg>().gameround = GameObject.Find("BG").GetComponent<Bg>().gameround + 1;
        GameObject.Find("BG").GetComponent<Bg>().difficulty = GameObject.Find("BG").GetComponent<Bg>().difficulty + 1;
    }

}
