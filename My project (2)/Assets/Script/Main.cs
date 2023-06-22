using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    void Start()
    {
        EnemySpawn e1 = new EnemySpawn("elf", 10);
        EnemySpawn e2 = new EnemySpawn("dragon", 100);

        e1.GetEnemyInfo();
        e2.GetEnemyInfo();
    }
}
