using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class WeightRandom : MonoBehaviour
{
    [SerializeField] private List<int> weightList = new();

    [ContextMenu("Random")]
    public void GetRandomValue()
    {
        int maxWeight = 0;

        foreach (var item in weightList)
        {
            maxWeight += item;
        }

        int randomValue = Random.Range(0, maxWeight);

        for (int i = 0; i < weightList.Count; i++)
        {
            if (randomValue >= weightList[i])
            {
                Debug.Log(weightList[i].ToString());
                return;
            }
        }
    }
}