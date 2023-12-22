using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemySO", menuName = "Enemies/Enemy")]
public class EnemySO : ScriptableObject
{
    public string EnemyName;
    public float EnemyHealth;
    public float EnemyAttack;
    public float EnemyDefence;
    public float EnemyAttackRange;
    public float EnemyAttackSpeed;
    public float EnemyMovingSpeed;
    public Enums.SFX[] EnemySFX;

    public Sprite EnemySprite;
    public ItemSO[] DropItems;

    public float SkillCoolTime;
    public int EnemySkill;
}
