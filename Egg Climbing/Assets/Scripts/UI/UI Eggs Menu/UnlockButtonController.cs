using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockButtonController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        CheckUnlockedEgg();

    }

    public void SetCurrentEgg()
    {
        if (PlayerPrefs.GetInt(GameObject.FindGameObjectWithTag("Eggs Selector").GetComponent<EggSelector>().eggList[GameObject.FindGameObjectWithTag("Eggs Selector").GetComponent<EggSelector>().currentEgg].name) == 1)
        {
            GameObject.FindGameObjectWithTag("Player Prefs").GetComponent<PlayerPreferences>().SetEgg(GameObject.FindGameObjectWithTag("Eggs Selector").GetComponent<EggSelector>().eggList[GameObject.FindGameObjectWithTag("Eggs Selector").GetComponent<EggSelector>().currentEgg]);
            Debug.Log("Seted egg " + GameObject.FindGameObjectWithTag("Player Prefs").GetComponent<PlayerPreferences>().GetCurrentEgg().name);
        }
        else
        {
            //Unlock code
            if (PlayerPrefs.GetInt("cascaras") > GameObject.FindGameObjectWithTag("Eggs Selector").GetComponent<EggSelector>().eggList[GameObject.FindGameObjectWithTag("Eggs Selector").GetComponent<EggSelector>().currentEgg].GetComponent<OtherStats>().collectableCost)
            {
                PlayerPrefs.SetInt("cascaras", PlayerPrefs.GetInt("cascaras") - GameObject.FindGameObjectWithTag("Eggs Selector").GetComponent<EggSelector>().eggList[GameObject.FindGameObjectWithTag("Eggs Selector").GetComponent<EggSelector>().currentEgg].GetComponent<OtherStats>().collectableCost);
                PlayerPrefs.SetInt(GameObject.FindGameObjectWithTag("Eggs Selector").GetComponent<EggSelector>().eggList[GameObject.FindGameObjectWithTag("Eggs Selector").GetComponent<EggSelector>().currentEgg].name, 1);
            }
        }
    }

    #region Select Crrect Image for the Button
    public void CheckUnlockedEgg()
    {
        if (PlayerPrefs.GetInt(GameObject.FindGameObjectWithTag("Eggs Selector").GetComponent<EggSelector>().eggList[GameObject.FindGameObjectWithTag("Eggs Selector").GetComponent<EggSelector>().currentEgg].name) == 1)
        {
            //unlocked
            if (GameObject.FindGameObjectWithTag("Eggs Selector").GetComponent<EggSelector>().eggList[GameObject.FindGameObjectWithTag("Eggs Selector").GetComponent<EggSelector>().currentEgg] == GameObject.FindGameObjectWithTag("Player Prefs").GetComponent<PlayerPreferences>().egg)
            {
                //Show the selected image
            }
            else
            {
                //get the unlocked (Select) image to the button
            }

        }
        else
        {
            //locked
            //get the Set Egg Image to the button
        }
    }
    #endregion
}
