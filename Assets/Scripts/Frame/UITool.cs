using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public static class UITool
{
    public static void RegistButton(UIObject uiObj,string ButtonName,UnityAction call)
    {
        Button btn = uiObj.transform.Find(ButtonName).GetComponent<Button>();
        btn.onClick.AddListener(call);
    }

    public static void SetText(UIObject uiObj, string TextName, string content)
    {
        Text textCompo = uiObj.transform.Find(TextName).GetComponent<Text>();
        textCompo.text = content;
    }
}
