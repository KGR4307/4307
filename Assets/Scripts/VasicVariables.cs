using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VasicVariables : MonoBehaviour
{
    public int gold = 0;
    public float Hp = 100.0f;
    public string playerName = "오이아";
    private bool isAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("게임시작");

        if(gold > 50)
        {
            Debug.Log("아이템을 구매할 수 있습니다.");
        }
        else
        {
            Debug.Log("골드가 부족합니다.");
        }

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("게임 진행중");

        if(Input.GetKeyUp(KeyCode.Space))
        {
            gold = gold + 10;
            Debug.Log("현재 골드 : " + gold);
        }
    }
}
