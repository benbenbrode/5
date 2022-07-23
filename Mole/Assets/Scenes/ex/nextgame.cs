using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextgame : MonoBehaviour
{
    int gameck = 0;
    // Start is called before the first frame update
    void Start()
    {
        gameck = Random.Range(1, 3);
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("next", 2f);
    }

    public void next()
    {
        if (gameck == 1)
        {
            SceneManager.LoadScene("Mole");
        }
        if (gameck == 2)
        {
            SceneManager.LoadScene("Egg");
        }
    }
}
