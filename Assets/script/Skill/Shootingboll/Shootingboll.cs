using UnityEngine;

public class Shootingboll : MonoBehaviour
{

    public Transform FirePoint;
    public float Boll_Time = 0;
    void Update()
    {
        // 공 발사 스킬 //

        // 1. 키다운 체크 및 쿨타임 체크
        if (Input.GetKeyDown(KeyCode.Space) && Boll_Time >= 0.3f)
        {
            Boll_Time = 0;
            float angle = Hack_Manager.instance.hack_Aimhelper.AimHelperAngle;
            float angle_radian = Mathf.Deg2Rad * angle;

            // 2.방향 및 속도 설정
            Vector2 ShootDirection = new Vector2(Mathf.Cos(angle_radian), Mathf.Sin(angle_radian)).normalized;

            //실제 발사 함수 실행
            Shoot(ShootDirection);
        }

        Boll_Time += Time.deltaTime;

    }

    public void Shoot(Vector2 Direction)
    {
        // 3. 오브젝트 생성 및 속도 적용
        GameObject Boll = poolmanager.instance.poolActive.Get(0);

        Boll.transform.position = FirePoint.transform.position;
        BollMove bollMove = Boll.GetComponent<BollMove>();
        bollMove.Initialize(Direction);
    }
}