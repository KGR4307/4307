using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VasicVariables : MonoBehaviour
{
    public int gold = 0;
    public float Hp = 100.0f;
    public string playerName = "���̾�";
    private bool isAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("���ӽ���");

        if(gold > 50)
        {
            Debug.Log("�������� ������ �� �ֽ��ϴ�.");
        }
        else
        {
            Debug.Log("��尡 �����մϴ�.");
        }

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("���� ������");

        if(Input.GetKeyUp(KeyCode.Space))
        {
            gold = gold + 10;
            Debug.Log("���� ��� : " + gold);
        }
    }
}
