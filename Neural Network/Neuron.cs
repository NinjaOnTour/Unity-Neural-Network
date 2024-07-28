using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Neuron
{
    public float Thresold;
    public float Bias;
    public float[] Weights;

    public Neuron(float thresold, float bias, float[] weights)
    {
        Thresold = thresold;
        Bias = bias;
        Weights = weights;
    }

    public float Activate(float input)
    {
        float y = SigmoidFunction(input + Bias);

        if(y >= Thresold)
        {
            return y;
        }

        return 0;
    }

    public static float SigmoidFunction(float x)
    {
        return 1.0f / (1 + Mathf.Exp(-x));
    }
}
