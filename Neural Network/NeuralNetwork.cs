using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class NeuralNetwork 
{
    public NeuronLayer[] NeuronLayers; // first one is input layer, last one is output layer, other ones are hidden layer

    public NeuralNetwork(NeuronLayer[] neuronLayers)
    {
        NeuronLayers = neuronLayers;
    }

    public float[] Activate(float[] input)
    {
        float[] output = new float[NeuronLayers[NeuronLayers.Length-1].Neurons.Length];

        for (int i = 0; i < NeuronLayers.Length-1; i++)
        {
            float[] preOutput = NeuronLayers[i].Activate(input);
            float[] nextInput = new float[NeuronLayers[i + 1].Neurons.Length];
            for (int k = 0; k < NeuronLayers[i+1].Neurons.Length; k++)
            {
                for (int j = 0; j < NeuronLayers[i].Neurons.Length; j++)
                {
                    nextInput[k] += NeuronLayers[i].Neurons[j].Weights[k] * preOutput[j];
                }
            }
            
            input = nextInput;
            output = nextInput;
        }

        output = NeuronLayers[NeuronLayers.Length - 1].Activate(input);

        return output;
    }
}
