using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
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
    

    [Header("Player Name Refrence")]
    public TMP_InputField inputField;
    public TextMeshProUGUI playerText;

    [HideInInspector]
    public static int bodySelected;
    [HideInInspector]
    public static int headSelected;
    [HideInInspector]
    public static int legSelected;
    [HideInInspector]
    public static int classSelected;
    [HideInInspector]
    public static string playerName;


    public static CharacterSelectButtons instance;
    private void Awake()
    {

        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);

        classSelected = 0;

    }

    public void SubmitButton()
    {
        if(inputField.text == "")
        {
            textBox.text = "The people need a name to call their hero";
        }
        else if(inputField.text != "")
        {
            playerName = inputField.text;
            textBox.text = "Great " + playerName.ToString() + " now it is time for you to recruit a traveling party";
            StartCoroutine(TimeForNewScene());
        }
        
      
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
        else if (bodySelected == 3)
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
        else if (bodySelected == 0)
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
        else if (legSelected == 3)
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
        else if (legSelected == 0)
        {
            legSelected = 3;
            legContainer.sprite = legImages[legSelected];
        }
    }

    public void GoForwardClass()
    {
        if(classSelected < 3)
        {
            classSelected += 1;
            textBox.text = classStrings[classSelected];
            weaponContainer.sprite = weaponImages[classSelected];
        }
        else if(classSelected == 3)
        {
            classSelected = 0;
            textBox.text = classStrings[classSelected];
            weaponContainer.sprite = weaponImages[classSelected];
        }
    }

    public void GoBackwardsClass()
    {
        if(classSelected > 0)
        {
            classSelected -= 1;
            weaponContainer.sprite = weaponImages[classSelected];
            textBox.text = classStrings[classSelected];
        }
        else if(classSelected == 0)
        {
            classSelected = 3;
            textBox.text = classStrings[classSelected];
            weaponContainer.sprite = weaponImages[classSelected];
        }
    }

    IEnumerator TimeForNewScene()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(1);
    }
  
}
