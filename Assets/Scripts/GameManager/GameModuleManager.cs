using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameModuleManager : SingleBase
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InitDay(int SceneIndex)
    {
        SingleDayData todayData = new SingleDayData(SceneIndex);
        todayData.Favorability = RandomInRange(2,5);
        todayData.Popularity = RandomInRange(2, 5);
    }

    public int RandomInRange(int StartNum,int EndNum)
    {
        int num = Random.Range(StartNum, EndNum + 1);
        return num;
    }
}
