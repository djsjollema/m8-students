using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Col : MonoBehaviour
{
    public GameObject Ball;
    public GameObject Wall;
    public Vector3 velocity = new Vector3(1,0,0);
    RaycastHit2D hit;


    // Update is called once per frame
    void Update()
    {
        hit = Physics2D.Raycast(Ball.transform.position, velocity,Ball.transform.localScale.x/2);
        Debug.DrawRay(Ball.transform.position, velocity, Color.yellow);
        if(hit.collider != null)
        {
            velocity = Vector3.Reflect(velocity, hit.normal);
        }
        Ball.transform.position += velocity * Time.deltaTime;
        
    }
}
