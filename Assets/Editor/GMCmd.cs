using System.Collections;
using System.Collections.Generic;
using UnityEditor;//�����ռ�
using UnityEngine;

public class GMCmd
{
    [MenuItem("CMCmd/��ʾҳ��")]
    public static void ReadTable()
    {
        UIManager.Instance.OpenPanel(UIConst.TestView);
    }

    [MenuItem("CMCmd/�ر�ҳ��")]
    public static void CloseTable()
    {
        UIManager.Instance.ClosePanel(UIConst.TestView);
    }
}
