using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bg : MonoBehaviour
{
    public GameObject life;
    public int gameover = 0;
    public int gameround = 1;
    public int stageck = 0;
    public int difficulty = 0;
    public GameObject BGObject;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(BGObject);
    }

    // Update is called once per frame
    void Update()
    {
        if(gameover == 1)
        {
            Destroy(life);
            Destroy(gameObject);
        }
    }
}
