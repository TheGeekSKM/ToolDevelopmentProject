using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class EnemySpawnCreator : EditorWindow
{
    //Variables
    GameObject enemySpawnerObject;


    [MenuItem("Window/Enemy Spawn Creator")]
    static void OpenWindow()
    {
        EnemySpawnCreator window = (EnemySpawnCreator)GetWindow(typeof(EnemySpawnCreator));
        window.minSize = new Vector2(200, 500);
        window.Show();
    }

    void OnEnable()
    {
        enemySpawnerObject = Resources.Load<GameObject>("EnemySpawner");
    }

    void OnGUI()
    {
        if (GUILayout.Button("Create"))
        {
            Instantiate(enemySpawnerObject, Vector3.zero, Quaternion.identity);
        }
    }
}
