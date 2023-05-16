using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncingBall : MonoBehaviour
{
    public GameObject ball;
    public Vector3 velocity = new Vector3(1, 2, 0);
    LinearFunction f = new LinearFunction(1,2);
    public DraggablePoint A;
    public DraggablePoint B;
    public DrawLine lineL;
    public Arrow arrowBall;

    private void Start()
    {
        Debug.Log(f.getY(2));
    }

    void Update()
    {
        arrowBall.myVector = velocity;
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

        f.setLinearFunctionWithTwoPoints(A.transform.position, B.transform.position);
        lineL.startPosition = new Vector3(-10, f.getY(-10), 0);
        lineL.endPosition = new Vector3(10, f.getY(10), 0);

        
    }
}
