using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn 
{
    private string name;
    private int hp;


    //������, �Ķ����(�� �ִ� ����) �Ű� ����, public Ŭ������()
    public EnemySpawn(string name, int hp)
    {
        this.name = name;
        this.hp = hp;
    }

    //�Լ�(���Ǳ�)
    public void GetEnemyInfo()
    {
        UnityEngine.Debug.Log($"NAME : {this.name} HP : {this.hp}");
    }

}

