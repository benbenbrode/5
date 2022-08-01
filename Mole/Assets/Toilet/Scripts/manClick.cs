using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class manClick : MonoBehaviour
{
    private bool first = true;
    private float x;
    private float y;
    public int check;
    public GameObject target;
    public GameObject move;
    public Button manb;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find((GameObject.Find("Canvas").GetComponent<people>().cnt).ToString());
        manb = GameObject.Find("man").GetComponent<Button>();
        check = 1;
    }

    void Update()
    {

    }
    public void Choose()
    {
        StartCoroutine(Moving());
    }
    IEnumerator Moving()
    {
        x = target.transform.position.x;
        y = target.transform.position.y;
        while (y < 17)
        {
            y += 0.004f;
            target.transform.position = new Vector2(x, y);
        }
        while (x > -11)
        {
            x -= 0.001f;
            target.transform.position = new Vector2(x, y);
        }
        yield return new WaitForSeconds(0.2f);
        while (y < 45)
        {
            y += 0.004f;
            target.transform.position = new Vector2(x, y);
        }
        Destroy(target);
        if (check != GameObject.Find("Canvas").GetComponent<people>().person[GameObject.Find("Canvas").GetComponent<people>().cnt])
        {
            manb.interactable = false;
            GameObject.Find("woman").GetComponent<womanClick>().womanb.interactable = false;
            GameObject obj = MonoBehaviour.Instantiate(GameObject.Find("Canvas").GetComponent<people>().bad);
            obj.name = "X";
            Vector3 pos = new Vector3(0, 3, 0);
            obj.transform.position = pos;
            yield return new WaitForSeconds(1.5f);
            GameObject.Find("Lifenum").GetComponent<Life>().Lifenum = GameObject.Find("Lifenum").GetComponent<Life>().Lifenum - 1;
            GameObject.Find("BG").GetComponent<Bg>().gameround = GameObject.Find("BG").GetComponent<Bg>().gameround + 1;
            Destroy(obj);
            SceneManager.LoadScene("Round");
        }
        if (check == GameObject.Find("Canvas").GetComponent<people>().person[GameObject.Find("Canvas").GetComponent<people>().cnt] && GameObject.Find("Canvas").GetComponent<people>().cnt + 1 == GameObject.Find("Canvas").GetComponent<people>().person.Length)
        {
            manb.interactable = false;
            GameObject.Find("woman").GetComponent<womanClick>().womanb.interactable = false;
            GameObject obj = MonoBehaviour.Instantiate(GameObject.Find("Canvas").GetComponent<people>().good);
            obj.name = "O";
            GameObject.Find("timer").GetComponent<Timer>().gameclearck = 1;
            Vector3 pos = new Vector3(0, 3, 0);
            obj.transform.position = pos;
            yield return new WaitForSeconds(1.5f);
            GameObject.Find("BG").GetComponent<Bg>().gameround = GameObject.Find("BG").GetComponent<Bg>().gameround + 1;
            GameObject.Find("BG").GetComponent<Bg>().difficulty = GameObject.Find("BG").GetComponent<Bg>().difficulty + 1;
            Destroy(obj);
            SceneManager.LoadScene("Round");

        }
        if (GameObject.Find("Canvas").GetComponent<people>().cnt != GameObject.Find("Canvas").GetComponent<people>().person.Length)
        {
            for (int i = GameObject.Find("Canvas").GetComponent<people>().cnt + 1; i < GameObject.Find("Canvas").GetComponent<people>().person.Length; i++)
            {
                move = GameObject.Find(i.ToString());
                float x1 = move.transform.position.x;
                if (first == true)
                {
                    while (x1 > 0)
                    {
                        x1 -= 0.002f;
                        move.transform.position = new Vector2(x1, move.transform.position.y);
                    }
                    first = false;
                }
                else
                {
                    float x2 = move.transform.position.x - 3;
                    while (x1 > x2)
                    {
                        x1 -= 0.002f;
                        move.transform.position = new Vector2(x1, move.transform.position.y);
                    }
                }
            }
        }
        GameObject.Find("Canvas").GetComponent<people>().cnt++;
        first = true;
        target = GameObject.Find((GameObject.Find("Canvas").GetComponent<people>().cnt).ToString());
        GameObject.Find("woman").GetComponent<womanClick>().target = GameObject.Find((GameObject.Find("Canvas").GetComponent<people>().cnt).ToString());
        yield break;
    }
}

