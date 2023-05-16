using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public Vector3 myVector = new Vector3(1, 1, 0);
    Mesh mesh;
    Vector3[] vertices;
    int[] triangles;

    // Start is called before the first frame update
    void Start()
    {
        mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;

        createShape();
        updateMesh();

    }

    // Update is called once per frame
    void Update()
    {
        //
        createShape();
        updateMesh();
        
        transform.localEulerAngles = new Vector3(0, 0, Mathf.Atan2(myVector.y, myVector.x) * Mathf.Rad2Deg);

    }

    void createShape()
    {
        float length = myVector.magnitude;

        float arrowLength = 0.40f;
        float arrowWidth = 0.3f;
        float stickWidth = 0.1f;

        float stickLength = length - arrowLength;
        vertices = new Vector3[]
        {
            new Vector3(0,stickWidth,0),
            new Vector3(stickLength,stickWidth,0),
            new Vector3(stickLength,arrowWidth,0),
            new Vector3(length,0,0),
            new Vector3(stickLength,-arrowWidth,0),
            new Vector3(stickLength,-stickWidth,0),
            new Vector3(0,-stickWidth,0)
        };
        triangles = new int[]
        {
            0,1,6,
            1,5,6,
            2,3,4
        };
    }

    void updateMesh()
    {
        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
    }
}