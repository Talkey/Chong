using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleBase : MonoBehaviour
{
    protected static GameManager instance;
    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindAnyObjectByType<GameManager>();
            }
            return instance;
        }
    }
}
