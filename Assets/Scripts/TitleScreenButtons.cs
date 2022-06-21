using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TitleScreenButtons : MonoBehaviour
{
  
    public GameObject startingText;
    public  GameObject startingButton;
    public GameObject creditContainer;
    public GameObject menuObject1;
    public GameObject menuObject2;
    public GameObject buttonObject;
    public GameObject secondButtonObject;
    
    public void GoToCharacterSelect()
    {
        SceneManager.LoadScene(1);
    }

    public void OpenCredits()
    {
        if (!creditContainer.activeInHierarchy)
        {
            creditContainer.SetActive(true);
        }
        else if (creditContainer.activeInHierarchy)
        {
            creditContainer.SetActive(false);
        }
    }

  
    
    public void GoToMenu()
    {

        startingButton.SetActive(false);
        startingText.SetActive(false);
        menuObject1.SetActive(true);
        menuObject2.SetActive(true);
        buttonObject.SetActive(true);
        secondButtonObject.SetActive(true);
    }
}
