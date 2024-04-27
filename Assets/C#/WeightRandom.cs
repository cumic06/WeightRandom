using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class WeightRandom : MonoBehaviour
{
    [SerializeField] private List<WeightData> weightData;

    [ContextMenu("Random")]
    public void GetRandomValue()
    {
        float maxWeight = 0;
        int count = 0;

        foreach (var item in weightData)
        {
            maxWeight += item.weightValue;
        }

        for (int j = 0; j < 1000; j++)
        {
            float pivot = Random.Range(0, maxWeight);
            float weight = 0;
            count++;
            for (int i = 0; i < weightData.Count; i++)
            {
                weight += weightData[i].weightValue;
                if (pivot <= weight)
                {
                    Debug.Log($"<color=red>{weightData[i].name}</color>");
                    break;
                }
            }
        }
    }
}

[System.Serializable]
public class WeightData
{
    public string name;
    public float weightValue;
}