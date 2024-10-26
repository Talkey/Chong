using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleDayData
{
    public int Money;
    public int currnetSceneIndex;
    public int Popularity;
    public int Favorability;

    public SingleDayData(int SceneIndex)
    {
        Money = 0;
        currnetSceneIndex = SceneIndex;
        Popularity = 0;
        Favorability = 0;
    }


}
