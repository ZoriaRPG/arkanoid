﻿using UnityEngine;
using System.Collections;

#if UNITY_EDITOR
public class FPSDisplay : MonoBehaviour
{
    float deltaTime = 0.0f;

    private void Update()
    {
        deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
    }

    private void OnGUI()
    {
        int w = Screen.width;
        int h = Screen.height;

        GUIStyle style = new GUIStyle();
        Rect rect = new Rect(-2, 2, w, 10);

        style.alignment = TextAnchor.UpperRight;
        style.fontSize = 10;
        style.normal.textColor = new Color(255, 255, 255, 255);
        //float msec = deltaTime * 1000.0f;
        float fps = 1.0f / deltaTime;
        //string text = string.Format("{0:0.0} ms ({1:0.} fps)", msec, fps);
        string text = fps.ToString("0.");
        GUI.Label(rect, text, style);
    }
}
#endif