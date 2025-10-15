using UnityEngine;

public class Hack_Aimhelper : MonoBehaviour
{
    public float AimRotationSpeed;
    public float AimHelperAngle;

    public Transform AimHelper_Object;
    void Update()// Aimhelper 기능 구현 함수
    {

        // 1. A,D 입력 받기(이게임에서는 A와 D로 움직입니다.)
        float horizontal = Input.GetAxisRaw("Horizontal");

        // 2. 입력 확인
        if (horizontal != 0)
        {
            // 3. 입력값에 따른 각도 설정 및 각도 보정
            AimHelperAngle += horizontal * AimRotationSpeed * Time.deltaTime;

            AimHelperAngle = AimHelperAngle % 360;

            if (AimHelperAngle < 0f) { AimHelperAngle -= 360; }





        }
        

        // 3. 실제 에임 도우미 회전 적용
        Aimline_Rotation(AimHelperAngle);
    }
    
    public void Aimline_Rotation(float angle)
    {
        AimHelper_Object.Rotate(0f, 0f, angle);

        print(AimHelperAngle);
    }
}
