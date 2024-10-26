using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceLoader
{
    public static GameObject LoadRes(string ResPath)
    {
        GameObject resLoad = Resources.Load<GameObject>(ResPath);
        return resLoad;
    }
}
