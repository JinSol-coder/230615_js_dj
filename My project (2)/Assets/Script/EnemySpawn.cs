using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn 
{
    private string name;
    private int hp;


    //생성자, 파라미터(돈 넣는 구녕) 매개 변수, public 클래스명()
    public EnemySpawn(string name, int hp)
    {
        this.name = name;
        this.hp = hp;
    }

    //함수(자판기)
    public void GetEnemyInfo()
    {
        UnityEngine.Debug.Log($"NAME : {this.name} HP : {this.hp}");
    }

}

