using UnityEngine;

public class BollMove : MonoBehaviour
{

    public Rigidbody2D Boll;
    public float BollSpeed;
    private Vector2 BollDirect;

    public void Initialize(Vector2 Direction)
    {
        BollDirect = Direction;

    }

    public void FixedUpdate()
    {
        if(Boll != null)
        {
            Boll.linearVelocity = BollDirect * BollSpeed;
        }

    }

}
