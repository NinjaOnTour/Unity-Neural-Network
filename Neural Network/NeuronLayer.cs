using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class NeuronLayer
{
    public Neuron[] Neurons;

    public NeuronLayer(Neuron[] neurons)
    {
        Neurons = neurons;
    }

    public float[] Activate(float[] input)
    {
        float[] output = new float[Neurons.Length];

        for (int i = 0; i < output.Length; i++)
        {
            output[i] = Neurons[i].Activate(input[i]);
        }

        return output;
    }
}
