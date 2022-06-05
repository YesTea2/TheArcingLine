using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CharacterSelectButtons : MonoBehaviour
{
 

    [Header("Head Refrence")]
    public Sprite[] headImages;
    public Image headContainer;
    [Header("Body Refrence")]
    public Sprite[] bodyImages;
    public Image bodyContainer;
    [Header("Leg Refrence")]
    public Sprite[] legImages;
    public Image legContainer;
    [Header("Weapon Refrence")]
    public Sprite[] weaponImages;
    public Image weaponContainer;

    [Header("Class Refrence")]
    public string[] classStrings;
    public TextMeshProUGUI textBox;


    [HideInInspector]
    public int bodySelected;
    [HideInInspector]
    public int headSelected;
    [HideInInspector]
    public int legSelected;
    [HideInInspector]
    public int classSelected;

    private void Awake()
    {
        classSelected = 0;
    }



    public void GoForwardHead()
    {
        if(headSelected < 3)
        {
            headSelected += 1;
            headContainer.sprite = headImages[headSelected];
        }
        else if(headSelected == 3)
        {
            headSelected = 0;
            headContainer.sprite = headImages[headSelected];
        }
       
    }

    public void GoBackwardsHead()
    {
        if(headSelected > 0)
        {
            headSelected -= 1;
            headContainer.sprite = headImages[headSelected];
        }
        else if(headSelected == 0)
        {
            headSelected = 3;
            headContainer.sprite = headImages[headSelected];
        }
    }

    public void GoForwardBody()
    {
        if (bodySelected < 3)
        {
            bodySelected += 1;
            bodyContainer.sprite = bodyImages[bodySelected];
        }
        if (bodySelected == 3)
        {
            bodySelected = 0;
            bodyContainer.sprite = bodyImages[bodySelected];
        }
    }

    public void GoBackwardsBody()
    {
        if (bodySelected > 0)
        {
            bodySelected -= 1;
            bodyContainer.sprite = bodyImages[bodySelected];
        }
        if (bodySelected == 0)
        {
            bodySelected = 3;
            bodyContainer.sprite = bodyImages[bodySelected];
        }
    }

    public void GoForwardLeg()
    {
        if (legSelected < 3)
        {
            legSelected += 1;
            legContainer.sprite = legImages[legSelected];
        }
        if (headSelected == 3)
        {
            legSelected = 0;
            legContainer.sprite = legImages[legSelected];
        }
    }

    public void GoBackwardLeg()
    {
        if (legSelected > 0)
        {
            legSelected -= 1;
            legContainer.sprite = legImages[legSelected];
        }
        if (legSelected == 0)
        {
            legSelected = 3;
            legContainer.sprite = legImages[legSelected];
        }
    }

    public void GoForwardClass()
    {
        if(classSelected < 4)
        {
            classSelected += 1;
            textBox.text = classStrings[classSelected];
        }
        else if(classSelected == 4)
        {
            classSelected = 0;
            textBox.text = classStrings[classSelected];
        }
    }

    public void GoBackwardsClass()
    {
        if(classSelected > 0)
        {
            classSelected -= 1;
            textBox.text = classStrings[classSelected];
        }
        else if(classSelected == 0)
        {
            classSelected = 4;
            textBox.text = classStrings[classSelected];
        }
    }
}
