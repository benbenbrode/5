using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

public class CardMove : MonoBehaviour
{
    public RectTransform image1;
    public RectTransform image2;
    public RectTransform image3;
    public float speed = 200f;

    private Vector3 initialPos1;
    private Vector3 initialPos2;
    private Vector3 initialPos3;
    private bool swapping = false;
    public bool fin = false;
    private int swapnum = 0;
    private int swapnum2 = 10;
    private bool startcker = false;

    public GameObject jokercard;
    public Sprite after_img;

    void Start()
    {
        Invoke("wait", 2);
        // �̹����� �ʱ� ��ġ ����
        initialPos1 = image1.anchoredPosition;
        initialPos2 = image2.anchoredPosition;
        initialPos3 = image3.anchoredPosition;
        speed = speed + ((GameObject.Find("BG").GetComponent<Bg>().difficulty / 3) * 200);
    }

    void Update()
    {
        if (startcker == false)
            return;

        if (swapnum == 2 + (GameObject.Find("BG").GetComponent<Bg>().difficulty / 3) * 2)
        {
            fin = true;
            return;
        }

        if (!swapping)
        {
            swapnum2 = Random.Range(0, 3);
            swapping = true;
        }


        if(swapnum2 == 0)
        {
            // �̹���1�� �̹���2�� ��ġ�� �̵�
            image1.anchoredPosition = Vector3.MoveTowards(image1.anchoredPosition, initialPos2, speed * Time.deltaTime);
            // �̹���2�� �̹���1�� ��ġ�� �̵�
            image2.anchoredPosition = Vector3.MoveTowards(image2.anchoredPosition, initialPos1, speed * Time.deltaTime);

            // �̹������� ������ ��ġ�� �����ߴ��� Ȯ��
            if (Vector2.Distance(image1.anchoredPosition, initialPos2) < 0.1f &&
              Vector2.Distance(image2.anchoredPosition, initialPos1) < 0.1f)
            {
                initialPos1 = image1.anchoredPosition;
                initialPos2 = image2.anchoredPosition;
                initialPos3 = image3.anchoredPosition;
                swapnum++;
                swapping = false;
            }
        }

        if(swapnum2 == 1)
        {
            // �̹���1�� �̹���3�� ��ġ�� �̵�
            image1.anchoredPosition = Vector3.MoveTowards(image1.anchoredPosition, initialPos3, speed * Time.deltaTime);
            // �̹���3�� �̹���1�� ��ġ�� �̵�
            image3.anchoredPosition = Vector3.MoveTowards(image3.anchoredPosition, initialPos1, speed * Time.deltaTime);

            // �̹������� ������ ��ġ�� �����ߴ��� Ȯ��
            if (Vector2.Distance(image1.anchoredPosition, initialPos3) < 0.1f &&
              Vector2.Distance(image3.anchoredPosition, initialPos1) < 0.1f)
            {
                initialPos1 = image1.anchoredPosition;
                initialPos2 = image2.anchoredPosition;
                initialPos3 = image3.anchoredPosition;
                swapnum++;
                swapping = false;
            }
        }

        if(swapnum2 == 2)
        {
            // �̹���3�� �̹���2�� ��ġ�� �̵�
            image3.anchoredPosition = Vector3.MoveTowards(image3.anchoredPosition, initialPos2, speed * Time.deltaTime);
            // �̹���2�� �̹���3�� ��ġ�� �̵�
            image2.anchoredPosition = Vector3.MoveTowards(image2.anchoredPosition, initialPos3, speed * Time.deltaTime);

            // �̹������� ������ ��ġ�� �����ߴ��� Ȯ��
            if (Vector2.Distance(image3.anchoredPosition, initialPos2) < 0.1f &&
              Vector2.Distance(image2.anchoredPosition, initialPos3) < 0.1f)
            {
                initialPos1 = image1.anchoredPosition;
                initialPos2 = image2.anchoredPosition;
                initialPos3 = image3.anchoredPosition;
                swapnum++;
                swapping = false;
            }
        }

    }

    void wait()
    {
        startcker = true;
        jokercard.GetComponent<Image>().sprite = after_img;
    }
}
