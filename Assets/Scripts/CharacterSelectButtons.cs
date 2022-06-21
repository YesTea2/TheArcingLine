using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class CharacterSelectButtons : MonoBehaviour
{
    [Header("How Many Of Each Body Part")]
    public int bodyParts;

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
    [Header("Cape Refrence")]
    public Sprite[] capeImages;
    public Image capeContainer;

    [Header("Class Refrence")]
    public string[] classStrings;
    public TextMeshProUGUI textBox;
    

    [Header("Player Name Refrence")]
    public TMP_InputField inputField;
    public TextMeshProUGUI playerText;
    public TextMeshProUGUI endResponseText;

    [Header("Random Name Array")]
    public string[] randomNames;

    [HideInInspector]
    public static int bodySelected;
    [HideInInspector]
    public static int headSelected;
    [HideInInspector]
    public static int legSelected;
    [HideInInspector]
    public static int capeSelected;
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
        bodyParts -= 1;

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
            endResponseText.text = playerName;
            textBox.text = "<size=5.5> Now that the hero has a name it is time to choose a traveling party";
            StartCoroutine(TimeForNewScene());
        }
        
      
    }

    public void RandomButton()
    {
        headContainer.sprite = headImages[Random.Range(0,5)];
        bodyContainer.sprite = bodyImages[Random.Range(0, 5)];
        legContainer.sprite = legImages[Random.Range(0, 5)];
        capeContainer.sprite = capeImages[Random.Range(0, 6)];
        //weaponContainer.sprite = weaponImages[Random.Range(0, 5)];
        playerName = randomNames[Random.Range(0,17)];
        inputField.text = playerName;

        classSelected = Random.Range(0,3);
        textBox.text = classStrings[classSelected];
        weaponContainer.sprite = weaponImages[classSelected];
        
    }


    public void GoForwardHead()
    {
        if(headSelected < bodyParts)
        {
            headSelected += 1;
            headContainer.sprite = headImages[headSelected];
        }
        else if(headSelected == bodyParts)
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
            headSelected = bodyParts;
            headContainer.sprite = headImages[headSelected];
        }
    }

    public void GoForwardBody()
    {
        if (bodySelected < bodyParts)
        {
            bodySelected += 1;
            bodyContainer.sprite = bodyImages[bodySelected];
        }
        else if (bodySelected == bodyParts)
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
            bodySelected = bodyParts;
            bodyContainer.sprite = bodyImages[bodySelected];
        }
    }

    public void GoForwardLeg()
    {
        if (legSelected < bodyParts)
        {
            legSelected += 1;
            legContainer.sprite = legImages[legSelected];
        }
        else if (legSelected == bodyParts)
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
            legSelected = bodyParts;
            legContainer.sprite = legImages[legSelected];
        }
    }

    public void GoForwardCape()
    {
        if (capeSelected < bodyParts + 1)
        {
            capeSelected += 1;
            capeContainer.sprite = capeImages[capeSelected];
        }
        else if (capeSelected == bodyParts + 1)
        {
            capeSelected = 0;
            capeContainer.sprite = capeImages[capeSelected];
        }
    }

    public void GoBackwardCape()
    {
        if (capeSelected > 0)
        {
            capeSelected -= 1;
            capeContainer.sprite = capeImages[capeSelected];
        }
        else if (capeSelected == 0)
        {
            capeSelected = bodyParts + 1;
            capeContainer.sprite = capeImages[capeSelected];
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
        SceneManager.LoadScene(2);
        AkSoundEngine.PostEvent("stop_mus_theme_event", GameObject.Find("WwiseGlobal"));
        AkSoundEngine.PostEvent("play_mus_theme_event", GameObject.Find("WwiseGlobal"));
        yield break;
    }
  
}
