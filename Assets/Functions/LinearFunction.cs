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

}
