using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class Enermy : MonoBehaviour
{
    public float Enermy_Exp;
    public float Enermy_Hp;
    public float Enermy_Speed;
    public float Enermy_Damage;
    public GameObject Enermy_Object;

    void Awake()
    {
        Enermy_Object = this.gameObject;

        //스탯 적용 함수 실행
        Enermy_StatsApply(Mathf.Round(Game_Manager.instance.GamePlay_Timer / 60)); // 매개변수로 시간 적용
    }
    public Vector3 Target_direction;
    void FixedUpdate()
    {
        // **********|||타겟팅|||********* //

        // 1. 가야될 방향 벡터 구한후 크기 1로 정규화
        // 이 부분이 25번째 줄일 가능성이 높습니다.
        Target_direction = Enermy_Manager.instance.Kill_Target.transform.position - transform.position;

        Vector2 Speed = Target_direction.normalized * Enermy_Speed;

        // 2. 벡터 * 속도 해서 오브젝트에 적용
        GetComponent<Rigidbody2D>().linearVelocity = Speed;
    }

    //접촉 확인
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("boll"))
        {
            Enermy_Hp -= Hack_Manager.instance.hack.Player_Damage;

            collision.gameObject.SetActive(false);
            Hack_Manager.instance.Exp(Enermy_Exp);
        }
        if (Enermy_Hp <= 0)
        {
            Enermy_Object.SetActive(false);

        }
    }

    //***** 시간에 따른 적들의 스탯 적용 *****//
    public void Enermy_StatsApply(float current_time)
    {
        // 1. 분당 스탯 증가 비율 설정(시간에 따라 증가 비율이 올라감)
        // 분당 증가비율 0.1f씩 증가 최대 2f까지

        float Stats_Rate = Mathf.Clamp(0.1f, current_time * 0.1f, 2f);

        // 2. 스탯 실제 적용(분당 Stats_Rate 만큼 증가)
        Enermy_Exp = Mathf.Clamp(1, current_time*Stats_Rate + 1,2);
        Enermy_Damage = Mathf.Clamp(1, current_time * Stats_Rate + 1, 100);
        Enermy_Speed = Mathf.Clamp(1, (current_time * Stats_Rate / 3) + 1, 100);
        Enermy_Hp = Mathf.Clamp(1, current_time * Stats_Rate + 1, 100);

    }


}
