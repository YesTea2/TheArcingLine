using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroName : MonoBehaviour
{
    [HideInInspector]
    public SkillSelect sSelect;
    [HideInInspector]
    public string heroName;

    public int memberNumber;

    

    private void Awake()
    {
        sSelect = FindObjectOfType<SkillSelect>();
    }

    private void Start()
    {
        if (memberNumber == 1)
        {
            heroName = sSelect.partyMemberClassOne;

        }
        if(memberNumber == 2)
        {
            heroName = sSelect.partyMemberClasstwo;
        }
        if(memberNumber == 3)
        {
            heroName = CharacterSelectButtons.playerName.ToString();
        }
    }
}
