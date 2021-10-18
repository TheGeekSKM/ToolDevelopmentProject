using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    //This is the list of all the enemies that can spawn:
    [SerializeField] List<GameObject> _enemies = new List<GameObject>();

    public List<GameObject> Enemies
    {
        get
        {
            return _enemies;
        }
        set
        {
            _enemies = value;
        }
    }
    

}
