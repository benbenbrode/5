using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

enum TILE { ROAD = 0, WALL, CHECK, START, END };

public class Maze : MonoBehaviour
{
    [SerializeField] private int width;
    [SerializeField] private int height;
    private int[,] map;

    private Vector2Int[] direction = { Vector2Int.up, Vector2Int.down, Vector2Int.left, Vector2Int.right };
    private Vector2Int pos = Vector2Int.zero;
    private Stack<Vector2Int> stackDir = new Stack<Vector2Int>(); //������ ���� ���� ����

    [SerializeField] private Tilemap tilemap;
    [SerializeField] private Tile tile;
    private bool end = false;

    private void Awake()
    {
        width = 29;
        height = 29;
        Generate();

    }

    public void Generate()
    {
        Init(); //�̷� �ʱ�ȭ
        RandPosSelect(); //���� ���� ������ ����
        StartCoroutine(GenerateRoad()); //�̷� ����
    }

    private void Init()
    {
        map = new int[width, height];
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                map[x, y] = (int)TILE.WALL; //��� Ÿ���� ������ ä��
                OnDrawTile(x, y); //Ÿ�� ����
                SetTileColor(x, y); //Ÿ�� ���� ����
            }
        }
    }

    private void RandPosSelect()
    {
        do
        {
            pos = new Vector2Int(Random.Range(0, width), Random.Range(0, height)); //�̷� ���� ������ ������ ����
        } while (pos.x % 2 == 0 || pos.y % 2 == 0); //Ȧ�� ĭ���� ����
    }

    private void RandDirection() //�������� ������ ���� �޼ҵ�
    {
        for (int i = 0; i < direction.Length; i++)
        {
            int randNum = Random.Range(0, direction.Length); //4���� �� �������� ���� ����
            Vector2Int temp = direction[randNum]; //���� �ε����� �ش��ϴ� ����� �������� ������ ������ ���� �ٲ�
            direction[randNum] = direction[i];
            direction[i] = temp;
        }
    }

    private IEnumerator GenerateRoad()
    {
        map[pos.x, pos.y] = (int)TILE.START; //RandPosSelect �Լ����� �������� ������ ������ ���� �������� ����
        SetTileColor(pos.x, pos.y);
        do
        {
            int index = -1; //-1�� �� �� �ִ� ���� ������ �ǹ�

            RandDirection(); //���� �������� ����

            for (int i = 0; i < direction.Length; i++)
            {
                if (CheckForRoad(i))
                {
                    index = i; //������ ���⿡ ���� ���� ��� ���� �迭�� �ε��� ����
                    break;
                }
            }

            if (index != -1) //�� �� �ִ� ���� ���� ���
            {
                for (int i = 0; i < 2; i++) //��� �� ���̿� ���� �����ϱ� ���� 3ĭ�� ��� �ٲ�
                {
                    stackDir.Push(direction[index]); //���ÿ� ���� ����
                    pos += direction[index]; //��ġ ���� ����
                    map[pos.x, pos.y] = (int)TILE.CHECK; //Ÿ�� ����
                    SetTileColor(pos.x, pos.y); //Ÿ�� ���� ����
                }
            }
            else //�� �� �ִ� ���� ���� ���
            {
                for (int i = 0; i < 2; i++) //���� ���� �� 3ĭ�� ������� ������ �ڷ� ���ư� ���� 3ĭ �̵�
                {
                    if (end == false)
                    {
                        map[pos.x, pos.y] = (int)TILE.END; 
                        SetTileColor(pos.x, pos.y);
                        pos += stackDir.Pop() * -1;
                        end = true;
                    }
                    else
                    {
                        map[pos.x, pos.y] = (int)TILE.ROAD; //�ϼ��� �� �ǹ�
                        SetTileColor(pos.x, pos.y);
                        pos += stackDir.Pop() * -1; //������ �����ϴ� ���ÿ��� �����͸� ������ -1�� ���� ���� ����
                    }
                }
            }

            yield return null;
        }
        while (stackDir.Count != 0); //������ 0�̶�� ���� ��� ���� ��ȸ�ߴٴ� ���� �ǹ��ϹǷ� �ݺ��� ����

    }

    private bool CheckForRoad(int index)
    {
        if ((pos + direction[index] * 2).x > width - 2) return false; //2�� ���ϴ� ������ ��� �� ���̿� ���� �ֱ� ����
        if ((pos + direction[index] * 2).x < 0) return false;
        if ((pos + direction[index] * 2).y > height - 2) return false;
        if ((pos + direction[index] * 2).y < 0) return false;
        if (map[(pos + direction[index] * 2).x, (pos + direction[index] * 2).y] != (int)TILE.WALL) return false;
        return true;
    }

    private void SetTileColor(int x, int y)
    {
        Vector3Int pos = new Vector3Int(-width / 2 + x, -height / 2 + y, 0); //�̷��� ��ġ�� ī�޶� �߾����� ����
        tilemap.SetTileFlags(pos, TileFlags.None); 
        switch (map[x, y])
        {
            case (int)TILE.ROAD: tilemap.SetColor(pos, Color.white); break;
            case (int)TILE.WALL: tilemap.SetColor(pos, Color.black); break;
            case (int)TILE.CHECK: tilemap.SetColor(pos, Color.green); break;
            case (int)TILE.START: tilemap.SetColor(pos, Color.red); break;
            case (int)TILE.END: tilemap.SetColor(pos, Color.blue); break;
        }
    }

    private void OnDrawTile(int x, int y)
    {
        Vector3Int pos = new Vector3Int(-width / 2 + x, -height / 2 + y, 0);
        tilemap.SetTile(pos, tile); //Ÿ�� ����
    }
}