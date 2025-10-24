using UnityEngine;

public class Game_Manager : MonoBehaviour
{

    public static Game_Manager instance;

    [Header("정지상태 확인")]
    public bool IsLive = true;

    [Header("적 스폰 게임 오브젝트")]
    public int AnermyKill = 0; // 킬 갯수
    public float Enermy_Spawn_Timer;// 적이 스폰되는 시간
    public float Enermy_CoolTime;// 적 스폰 쿨타임
    [Header("게임 타이머")]
    public float GamePlay_Timer;

    void Awake()
    {
        if (!instance)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(instance);
        }
    }

    void Update()
    {
        // 시간 증가(증가할수록 적들이 강해짐)
        GamePlay_Timer += Time.deltaTime;

    }
    void FixedUpdate()
    {
        Enermy_Spawn_CoolTimeCheck();


    }



    //***** 적 오브젝트 생성 타이머 *****//
    void Enermy_Spawn_CoolTimeCheck()
    {

        // 1. 적이 생성되야 되는지 시간체크
        if (Enermy_CoolTime >= Enermy_Spawn_Timer)
        {
            // 만약 시간이 됬다면 적 프리펩 오브젝트 활성화
            Enermy_CoolTime = 0f;
            GameObject Enermy_Object = poolmanager.instance.poolActive.Get(poolmanager.instance.Enermy_Prefab);

            Enermy_Object.transform.position = Enermy_Manager.instance.enermy_Spawner.Enermy_Random_Spawn();

        }
        // 주기적으로 시간 증가
        Enermy_CoolTime += Time.deltaTime;
    }


    //***** 플레이어 레벨업 *****//
    public void LevelUp()
    {

        // 1.레벨올리기
        Hack_Manager.instance.Player_Level++;


        // 2. 증강 선택을 위한 실행 일시정지 및 함수 실행(증강 선택 구현후 할 예정)
        //Stop();

    }


    //***** 게임오버시 실행하는 함수 *****//
    public void GameOver()
    {
        print("플레이어가 죽어 게임을 종료합니다.");

        Stop();
    }

    public void Stop()
    {
        IsLive = false;
        Time.timeScale = 0;
    }
}
