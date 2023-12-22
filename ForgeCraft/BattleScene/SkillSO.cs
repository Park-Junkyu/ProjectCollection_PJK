using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SkillSO", menuName = "Skills")]
public class SkillSO : ScriptableObject
{
    [Header("SkillType")]
    public Enums.SkillType Type;

    [Header("Skill ID")]
    public int SkillID;

    [Header("Skill Effect")]
    [TextArea]
    public string SkillDesc;
    public float SkillAmount;
    public Sprite SkillIcon;
    public float SkillCoolTime;
    public GameObject SkillEffect;
    public Enums.SFX SkillSFX;

}
