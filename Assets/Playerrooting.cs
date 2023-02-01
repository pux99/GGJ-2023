
using UnityEngine;

public class Playerrooting : MonoBehaviour
{
    public float MinVelocity = 2f;
    private Rigidbody2D rigidbody2D;
    public PlayerMovementController test;
    public float timer=1;
    public float OrgTimer;
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        OrgTimer=timer;
    }

    void Update()
    {
        if (rigidbody2D.velocity.magnitude < MinVelocity)
        {
            timer -= Time.deltaTime;
        }
        else
            timer = OrgTimer;
        if (timer <= 0&& test.speed>=1.4f)
            test.speed -= 0.2f*Time.deltaTime;
        else if (timer>=OrgTimer)
            test.speed = 3f;
    }
}