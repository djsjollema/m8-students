using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleCollderManager : MonoBehaviour
{
    public CollidingCircle circleA;
    public CollidingCircle circleB;

    public float distance;
    bool collision = false;

    public Arrow normA;

    void Start()
    {
        
    }

    void Update()
    {
        Vector3 normaalA = (circleB.transform.position - circleA.transform.position).normalized;
        Vector3 normaalB = normaalA;

        normaalA = Vector3.Dot(normaalA, circleA.velocity) * normaalA;
        normaalB = Vector3.Dot(normaalB,circleB.velocity) * normaalB;

        Vector3 tangentA = circleA.velocity - normaalA;
        Vector3 tangentB = circleB.velocity - normaalB;


        distance = Vector3.Distance(circleA.transform.position, circleB.transform.position);

        normA.transform.position = circleA.transform.position;
        normA.myVector = normaalA;

        if(distance < (circleA.transform.localScale.x + circleB.transform.localScale.x)/2 && !collision ) 
        {
            circleA.velocity = tangentA + normaalB;
            circleB.velocity = tangentB + normaalA;
        }
        
        if(distance > (circleA.transform.localScale.x + circleB.transform.localScale.x) / 2)
        {
            collision = false;
        }
    }
}
