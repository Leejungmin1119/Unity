using UnityEngine;

public class Shootingboll : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            float angle = Hack_Manager.instance.hack_Aimhelper.AimHelperAngle;
            float angle_radian = Mathf.Deg2Rad * angle;

            Vector2 ShootDirection = new Vector2(Mathf.Cos(angle_radian), Mathf.Sin(angle_radian)).normalized;

            Shoot(ShootDirection);
        }


    }

    public void Shoot(Vector2 Direction)
    {
        GameObject Boll = poolmanager.instance.poolActive.Get(0);

        BollMove bollMove = Boll.GetComponent<BollMove>();

        bollMove.Initialize(Direction);

    }
}
