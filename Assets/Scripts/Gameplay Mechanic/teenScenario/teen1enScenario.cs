using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class teen1enScenario : MonoBehaviour
{
    public static Scenario[] teen1enArr;
    public static Scenario[] gameArr;

    public static int numScene;

    public static void setNumScene(int i)
    {
        teen1enScenario.numScene = i;
    }

    public static int getNumScene()
    {
        return teen1enScenario.numScene;
    }

    public static void generateScenarios(int num)
    {
        teen1enArr = new Scenario[num];
        string temp = "Teen1en";

        for (int i = 0; i < num; i++)
        {
            int number = i + 1;
            teen1enArr[i] = new Scenario(number, temp + number);
        }
    }

    public static Scenario[] randomizeArray()
    {
        Scenario[] newArray = teen1enArr.Clone() as Scenario[];
        for (int i = 0; i < teen1enArr.Length; i++)
        {
            Scenario tmp = newArray[i];
            int r = Random.Range(i, newArray.Length);
            newArray[i] = newArray[r];
            newArray[r] = tmp;
        }
        return newArray;
    }
}
