using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyObject : MonoBehaviour
{
    [SerializeField] private Sprite[] enemyImg;
    [SerializeField] private Slider hpbar;

    EnemySpawn enemy;

    public void SetEnemy(EnemySpawn e)
    {
        this.enemy = e;

        hpbar.maxValue = enemy.Hp;
        hpbar.value = enemy.Hp;
    }

    private void Start()
    {
        SetEnemy(new EnemySpawn(EnemySpawn.EnemyType.Basic,"fool", 100, 10, 1.5f));
    }
    private void Update()
    {
        if (enemy == null) return;
        MoveEnemy();
    }
    private void MoveEnemy()
    {
        if (this.transform.position.y <= -2) return;
        this.transform.position -= new Vector3(0, 3 * Time.deltaTime, 0);
    }
}
