using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="EnemyData", menuName ="Script/EnemyData")]
public class EnemyData : ScriptableObject
{
    public int typeId;
    public new string name;
    public float moveSpeed;
    public float life;
    public float fireMode;
    public float fireInterval;
}
