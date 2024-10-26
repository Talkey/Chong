using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.IO;
using UnityEngine.UI;
using System;

public class UIObject : MonoBehaviour
{
    public virtual void Init()
    {

    }

    public virtual void Close()
    {
        this.DestroyMySelf();
    }

    public virtual void Open()
    {

    }    

    public virtual void DestroyMySelf()
    {
        GameObject.Destroy(this);
    }

    public virtual void Hide()
    {

    }
}
