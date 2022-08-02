using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class yellow_button : MonoBehaviour
{
    private int num;

    // Start is called before the first frame update
    void Start()
    {
        num = 2;
    }

    public void CheckColor()
    {
        StartCoroutine(Checking());
    }
    IEnumerator Checking()
    {
        if (GameObject.Find("Canvas").GetComponent<colorQuiz>().showEnd == true && GameObject.Find("Canvas").GetComponent<colorQuiz>().cnt <= GameObject.Find("Canvas").GetComponent<colorQuiz>().arr.Length)
        {
            if (GameObject.Find("Canvas").GetComponent<colorQuiz>().arr[GameObject.Find("Canvas").GetComponent<colorQuiz>().cnt] != num)
            {
                GameObject obj = MonoBehaviour.Instantiate(GameObject.Find("Canvas").GetComponent<colorQuiz>().bad);
                obj.name = "X";
                GameObject.Find("Lifenum").GetComponent<Life>().Lifenum = GameObject.Find("Lifenum").GetComponent<Life>().Lifenum - 1;
                GameObject.Find("BG").GetComponent<Bg>().gameround = GameObject.Find("BG").GetComponent<Bg>().gameround + 1;
                Vector3 pos = new Vector3(0, 3, 0);
                obj.transform.position = pos;
                GameObject.Find("Canvas").GetComponent<colorQuiz>().cb1.interactable = false;
                GameObject.Find("Canvas").GetComponent<colorQuiz>().cb2.interactable = false;
                GameObject.Find("Canvas").GetComponent<colorQuiz>().cb3.interactable = false;
                GameObject.Find("Canvas").GetComponent<colorQuiz>().cb4.interactable = false;
                yield return new WaitForSeconds(1.5f);
                Destroy(obj);
                SceneManager.LoadScene("Round");
            }
            GameObject.Find("Canvas").GetComponent<colorQuiz>().cnt++;
        }
        if (GameObject.Find("Canvas").GetComponent<colorQuiz>().cnt == GameObject.Find("Canvas").GetComponent<colorQuiz>().arr.Length)
        {
            GameObject obj = MonoBehaviour.Instantiate(GameObject.Find("Canvas").GetComponent<colorQuiz>().good);
            obj.name = "O";
            GameObject.Find("timer").GetComponent<colortimer>().gameclearck = 1;
            GameObject.Find("BG").GetComponent<Bg>().gameround = GameObject.Find("BG").GetComponent<Bg>().gameround + 1;
            GameObject.Find("BG").GetComponent<Bg>().difficulty = GameObject.Find("BG").GetComponent<Bg>().difficulty + 1;
            Vector3 pos = new Vector3(0, 3, 0);
            obj.transform.position = pos;
            GameObject.Find("Canvas").GetComponent<colorQuiz>().cb1.interactable = false;
            GameObject.Find("Canvas").GetComponent<colorQuiz>().cb2.interactable = false;
            GameObject.Find("Canvas").GetComponent<colorQuiz>().cb3.interactable = false;
            GameObject.Find("Canvas").GetComponent<colorQuiz>().cb4.interactable = false;
            yield return new WaitForSeconds(1.5f);
            Destroy(obj);
            SceneManager.LoadScene("Round");
        }
    }
}