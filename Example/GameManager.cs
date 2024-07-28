using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float[] input;
    public NeuralNetwork NN;
    public float[] output;

    private void Start()
    {
        output = NN.Activate(input);
    }
}
