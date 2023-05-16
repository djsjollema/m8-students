using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearFunction 
{
    float slope;
    float intercept;

    public LinearFunction(float slope, float intercept)
    {
        this.slope = slope;
        this.intercept = intercept;
    }

    public float getY(float x) {
        return x*slope + intercept; 
    }

    public void setLinearFunctionWithTwoPoints(Vector3 A, Vector3 B)
    {
        this.slope = (B.y - A.y)/(B.x - A.x);
        this.intercept = A.y - this.slope * A.x;
    }

}
