using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    public ElasticBall A;
    public ElasticBall B;
    bool colliding = false;
    // Start is called before the first frame update
    void Start()
    {
        print(A.m);
        print(B.m);
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(A.transform.position, B.transform.position);
        if(distance < A.transform.localScale.x/2 + B.transform.localScale.x/2 && !colliding)
        {
            colliding = true;

            Vector3 normaalA = (A.transform.position - B.transform.position).normalized;
            Vector3 normaalB = normaalA;

            normaalA = Vector3.Dot(normaalA, A.velocity) * normaalA;
            normaalB = Vector3.Dot(normaalB, B.velocity) * normaalB;

            Vector3 tangentA = A.velocity - normaalA;
            Vector3 tangentB = B.velocity - normaalB;   

            //A.velocity = tangentA + normaalB;
            // B.velocity = tangentB + normaalA;

            B.velocity = (2*A.m)/(A.m + B.m) * normaalA - (A.m -  B.m)/(A.m +B.m) * normaalB;
            A.velocity = (A.m - B.m) / (A.m + B.m) * normaalA + (2 * B.m) / (A.m + B.m) * normaalB;

            B.velocity += tangentB;
            A.velocity += tangentA;
            
        }
        if(distance > A.transform.localScale.x / 2 + B.transform.localScale.x / 2)
        {
            colliding = false;
        }
        
    }
}
