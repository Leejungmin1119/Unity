using UnityEngine;

public class BollMove : MonoBehaviour
{

    public Rigidbody2D Boll;
    public float BollSpeed;
    private Vector2 BollDirect;

    void Awake()
    {
        Boll = GetComponent<Rigidbody2D>();
    }
    public void Initialize(Vector2 Direction)
    {
        BollDirect = Direction;

        Boll.linearVelocity = BollDirect * BollSpeed;
    }


}
