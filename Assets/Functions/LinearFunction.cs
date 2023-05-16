using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearFunction 
{
    public float slope;
    public float intercept;

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

    public void setLinearFunctionWithSlopeAndPoint(float slope, Vector3 A)
    {
        this.slope = slope;
        this.intercept = A.y - slope * A.x;
    }

    public Vector3 intersection(LinearFunction m)
    {
        float x = (m.intercept - this.intercept)/(this.slope - m.slope);
        float y = this.slope * x + this.intercept;
        return new Vector3 (x, y,0);
    }

}
