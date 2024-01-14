using System.Collections;
using System.Collections.Generic;
using UnityEditor;//命明空间
using UnityEngine;

public class GMCmd
{
    [MenuItem("CMCmd/显示页面")]
    public static void ReadTable()
    {
        UIManager.Instance.OpenPanel(UIConst.TestView);
    }

    [MenuItem("CMCmd/关闭页面")]
    public static void CloseTable()
    {
        UIManager.Instance.ClosePanel(UIConst.TestView);
    }
}
