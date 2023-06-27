using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn 
{

    public enum EnemyType
    {
        Basic = 0,
        Range
    }

    private EnemyType enemyType;
    private int hp;
    private int atk;
    private float speed;


    //������, �Ķ����(�� �ִ� ����) �Ű� ����, public Ŭ������()
    public EnemySpawn(EnemyType type, string name, int hp, int atk, float speed)
    {
        this.enemyType = type;
        this.hp = hp;
        this.atk = atk;
        this.speed = speed;
    }

    //�Լ�(���Ǳ�)
    public int Hp
    {
        get { return this.hp; }
    }

    public int Atk
    {
        get { return this.atk; }
    }

    public float Speed
    {
        get { return this.speed; }
    }

    public bool Hit(int dmg)
    {
        if (this.hp - dmg <= 0) return false;

        this.hp -= dmg;
        return true;
    }
}

