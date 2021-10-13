using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;



public class LerpEditorScript : EditorWindow
{
    Texture2D headerSectionTexture;
    Texture2D leftTransformTexture;
    Texture2D rightTransformTexture;
    Texture2D calculateAreaTexture;

    Color headerSectionColor = new Color(0, 0.5f, 1, 0.2f);
    Color leftTransformColor = new Color(0.5f, 0, 1, 0.5f);
    Color rightTransformColor = new Color(1, 0.2f, 0, 0.5f);
    Color calculateAreaColor = new Color(1, 0.92f, 0.016f, 1);

    Rect headerSectionRect;
    Rect leftTransformRect;
    Rect rightTransformRect;
    Rect calculateAreaRect;



    [MenuItem("Window/Lerp")]
       static void OpenWindow()
       {
           LerpEditorScript window = (LerpEditorScript)GetWindow(typeof(LerpEditorScript));
           window.minSize = new Vector2(300, 500);
           window.maxSize = new Vector2(600, 1000);
           window.Show();
       }

       void OnEnable()
       {
            InitTextures();    
       }

       void InitTextures()
       {
            headerSectionTexture = new Texture2D(1, 1);
            headerSectionTexture.SetPixel(0, 0, headerSectionColor);
            headerSectionTexture.Apply();

            leftTransformTexture = new Texture2D(1, 1);
            leftTransformTexture.SetPixel(0, 0, leftTransformColor);
            leftTransformTexture.Apply();

            rightTransformTexture = new Texture2D(1, 1);
            rightTransformTexture.SetPixel(0, 0, rightTransformColor);
            rightTransformTexture.Apply();

            calculateAreaTexture = new Texture2D(1, 1);
            calculateAreaTexture.SetPixel(0, 0, calculateAreaColor);
            calculateAreaTexture.Apply();
       }

       void OnGUI()
       {
            DrawLayouts();
            DrawHeader();
            DrawLeftTransformSettings();
            DrawRightTransformSettings();
            DrawCalculateAreaSettings();
       }

       void DrawLayouts()
       {
            headerSectionRect.x = 0;
            headerSectionRect.y = 0;
            headerSectionRect.width = Screen.width;
            headerSectionRect.height = 50;

            GUI.DrawTexture(headerSectionRect, headerSectionTexture);

            leftTransformRect.x = 0;
            leftTransformRect.y = 50;
            leftTransformRect.width = Screen.width / 2f;
            leftTransformRect.height = Screen.height - 150;

            GUI.DrawTexture(leftTransformRect, leftTransformTexture);

            rightTransformRect.x = Screen.width / 2f;
            rightTransformRect.y = 50;
            rightTransformRect.width = Screen.width / 2f;
            rightTransformRect.height = Screen.height - 150;
            

            GUI.DrawTexture(rightTransformRect, rightTransformTexture);

            calculateAreaRect.x = 0;
            calculateAreaRect.y = Screen.height - 150;
            calculateAreaRect.width = Screen.width;
            calculateAreaRect.height = Screen.height;
            

            GUI.DrawTexture(calculateAreaRect, calculateAreaTexture);




       }

       void DrawHeader()
       {
          GUILayout.BeginArea(headerSectionRect);
          
          GUILayout.Label("Lerp Menu");
          
          GUILayout.EndArea();
       }

        void DrawLeftTransformSettings()
        {
          GUILayout.BeginArea(leftTransformRect);
               
               GUILayout.Label("Left Transform Menu");

          GUILayout.EndArea();
        }

        void DrawRightTransformSettings()
        {
          GUILayout.BeginArea(rightTransformRect);
               
               GUILayout.Label("Right Transform Menu");

          GUILayout.EndArea();
        }

        void DrawCalculateAreaSettings()
        {
          GUILayout.BeginArea(calculateAreaRect);

              GUILayout.Label("Calculate Area Menu");

          GUILayout.EndArea();
        }
   
}
