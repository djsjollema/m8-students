using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollidingCircle : MonoBehaviour
{
    public Vector3 velocity = new Vector3(1, 2, 0);
    public float speed = 2.0f;
    Vector2 minView;
    Vector2 maxView;

    void Start()
    {
        minView = Camera.main.ScreenToWorldPoint(Vector2.zero);
        maxView = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += velocity * speed * Time.deltaTime;
        if(transform.position.y > maxView.y - transform.localScale.x/2)
        {
            velocity = new Vector3(velocity.x, -Mathf.Abs(velocity.y), 0);
        }

        if(transform.position.y < minView.y + transform.localScale.x / 2)
        {
            velocity = new Vector3(velocity.x, Mathf.Abs(velocity.y), 0);
        }

        if (transform.position.x > maxView.x - transform.localScale.x / 2)
        {
            velocity = new Vector3(-Mathf.Abs(velocity.x), velocity.y, 0);
        }

        if (transform.position.x < minView.x + transform.localScale.x / 2)
        {
            velocity = new Vector3(Mathf.Abs(velocity.x), velocity.y, 0);
        }



    }
}
