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
        /*while (true)
         {
             gameck = Random.Range(1, 5);
             if(gameck != GameObject.Find("BG").GetComponent<Bg>().stageck)
             {
                 break;
             }
         }
         */
        gameck = 3;
        
        
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
        if (gameck == 3)
        {
            SceneManager.LoadScene("Toilet");
        }
        if (gameck == 4)
        {
            SceneManager.LoadScene("ColorQuiz");
        }
    }
}
