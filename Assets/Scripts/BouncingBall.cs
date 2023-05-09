using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncingBall : MonoBehaviour
{
    public GameObject ball;
    public Vector3 velocity = new Vector3(1, 2, 0);
    LinearFunction f = new LinearFunction(1,2);

    private void Start()
    {
        Debug.Log(f.getY(2));
    }

    void Update()
    {
        ball.transform.position += velocity * Time.deltaTime;
        if(ball.transform.position.y > 4 - 0.5f)
        {
            velocity.y = -velocity.y;
        }
        if(ball.transform.position.y < -4 + 0.5f)
        {
            velocity.y = -velocity.y;
        }
        if(ball.transform.position.x > 10 - 0.5f)
        {
            velocity.x = -velocity.x;
        }
        if(ball.transform.position.x < -10 + 0.5f)
        {
            velocity.x = -velocity.x;
        }

        
    }
}
