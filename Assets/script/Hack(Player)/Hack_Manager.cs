using System;
using System.Collections.Generic;
using UnityEngine;

public class Hack_Manager : MonoBehaviour
{
    // 변수 참조

    public Hack_Aimhelper hack_Aimhelper;
    public Hack hack;

    public static Hack_Manager instance;

    [Header("플레이어 시스템")]
    public GameObject Player_Object;
    public int Player_Level;
    public float Player_Exp;

    public float Player_NextExp = 3;

    // 싱글턴 인스턴스
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else if (instance != this)
        {
            Destroy(instance);
        }
    }

    // ***** 경험치 획득 및 레벨업 통 조정 *****//
    public void Exp(float exp)
    {
        // 1. 경험치 더하기
        Player_Exp += exp;

        // 2. 경험치가 100%가 되면 레벨업
        if(Player_Exp >= Player_NextExp)
        {
            Player_Level++;

            Player_Exp = 0;
            // 추가적으로 다음 레벨업 경험치 양 설정
            Player_NextExp += Mathf.Round(Player_NextExp * 0.3f);
        }
    }

}
