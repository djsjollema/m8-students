using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElasticBall : MonoBehaviour
{
    public Vector3 velocity = new Vector3(1, 2, 0);
    public GameObject playGround;
    public float m;
    bool colliding = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += velocity * Time.deltaTime;
        if(transform.position.magnitude > playGround.transform.localScale.x/2 - transform.localScale.x/2 && !colliding)
        {
            colliding = true;
            Vector3 normaal = transform.position.normalized;
            normaal = Vector3.Dot(normaal, velocity) * normaal;
            Vector3 trangent = velocity - normaal;
            normaal = -normaal; 
            velocity = normaal + trangent;
        }

        if(transform.position.magnitude < playGround.transform.localScale.x / 2 - transform.localScale.x / 2)
         {
            colliding = false;
        }


    }
}
