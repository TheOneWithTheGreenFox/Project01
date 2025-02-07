using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillBuyScript : MonoBehaviour
{
    [SerializeField] private SkillScriptableObject skill;

    private void Start()
    {
        if (skill.unlocked)
        {
            GetComponent<Button>().interactable = false;
        }
    }

    public void BuySkill()
    {
        if (skill.canBeBrought)
        {
            skill.unlocked = true;
            Debug.Log("Brought " +  skill.Name);
            GetComponent<Button>().interactable = false;

            foreach (SkillScriptableObject dependant in skill.Dependants)
            {
                dependant.canBeBrought = true;
            }
        }

    }
}
