using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager
{
    public Transform UIRoot;
    public UIManager()
    {

    }
    public Dictionary<string, UIObject> UIDictionary = new Dictionary<string, UIObject>();
    public Stack<UIObject> UIStack = new Stack<UIObject>();
    public UIObject OpenUI(string UIName)
    {
        UIObject component;
        if (UIDictionary.ContainsKey(UIName) == false)
        {
            GameObject res = ResourceLoader.LoadRes(UIName);
            GameObject gobject = GameObject.Instantiate(res, UIRoot);
            component = gobject.GetComponent<UIObject>();
            if(component == null)
            {
                Debug.LogError("Error UI: "+UIName+" 没有正确挂载组件！");
                component = gobject.AddComponent<UIObject>();
            }
            UIDictionary.Add(UIName, component);
        }
        else
        {
            component = UIDictionary[UIName];
            component.Open();
        }
        PushInStack(component);
        return component;
    }

    public void HideUI(string UIName)
    {
        if (UIDictionary.ContainsKey(UIName))
        {

        }
        else
        {

        }
    }

    public void CloseUI(string UIName)
    {
        if(UIDictionary.ContainsKey(UIName))
        {
            UIObject component = UIDictionary[UIName];
            UIDictionary.Remove(UIName);
            component.DestroyMySelf();
            PopOutStack();
        }
    }

    public void PushInStack(UIObject targetUI)
    {
        if(GetStackPeek()!=null)
        {
            UIObject uIObject = GetStackPeek();
            uIObject.Hide();
        }
        UIStack.Push(targetUI);
    }

    public UIObject PopOutStack()
    {
        if (IsStackNull() == false)
        {
            UIObject temp = UIStack.Pop();
            return temp;
        }
        return null;
    }

    public UIObject GetStackPeek()
    {
        return UIStack.Peek();
    }
    public void ClearStack()
    {

    }

    public bool IsStackNull()
    {
        return UIStack.Count == 0;
    }
}


