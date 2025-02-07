using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Skills")]
public class SkillScriptableObject : ScriptableObject
{
    public string Name;
    public string Description;
    public bool unlocked;
    public bool canBeBrought;
    public ScriptableObject[] Dependants;
}
