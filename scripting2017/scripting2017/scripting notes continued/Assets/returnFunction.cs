using UnityEngine;
using System.Collections;

public class returnFunction : MonoBehaviour {

    int score = 100;
    private int health = 100;

    void Start()
    {
        float[] scores = { 24f, 60f, 100f, 86f };
        print(Average(scores));
    }

    float Sum(float num1, float num2)
    {
        float sum;
        sum = num1 + num2;
        return sum;
    }

    float Average(float[] scores)
    {
        float sum = 0;
        float average;
        foreach (float score in scores)
        {
            sum += score;
        }

        average = sum / scores.Length;

        return average;
    }
}

