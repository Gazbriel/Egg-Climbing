using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LifeDuration : MonoBehaviour {

	// Use this for initialization
	void Start () {
        LoadEgg();
	}
	
	// Update is called once per frame
	void Update () {
        UpdateHigherPosition();//Controls the las higer position
        DamageController();//defines if the egg can be hurt
        VerifyEggLife();//clear as water
	}

    #region Load Egg
    //this funtion in the future is gonna load the Egg that the players is currently using
    //but now just load a value:
    private void LoadEgg()
    {
        //eggLife = 3;

        

        //pass the value to the braker layer controller
        GetComponentInChildren<BrakeLayerController>().SetStarterLife(eggLife);
    }

    public int GetStarterLife()
    {
        return 3;
    }
    #endregion

    #region Damage Region
    private bool eggIsDead;
    public int eggLife;
    public int GetEggLife()
    {
        return eggLife;
    }
    public float damageHight;
    private float higherPosition;
    private void UpdateHigherPosition()
    {
        if (transform.position.y > higherPosition)
        {
            higherPosition = transform.position.y;
        }
    }
    public void Damage()
    {
        if (canDamage && (higherPosition - transform.position.y) > damageHight)
        {
            eggLife--;
            FindObjectOfType<AudioManager>().Play("Shatter Egg");
            Debug.Log("Damage");

            //Update the brake layer to see the damage in the gg
            GetComponentInChildren<BrakeLayerController>().UpdateBrakeLayer();
            //----------------------------------------------------
            //reset the higher position
            higherPosition = transform.position.y;
            //--------------------------
        }
        canDamage = false;
    }

    public bool canDamage;
    public void SetCanDamage(bool a)
    {
        canDamage = a;
    }
    private void DamageController()
    {
        //when is not grounded, you can damage the egg on the fall
        //this way you can damage the egg just one time
        if (!GetComponent<CollisionDetector>().GetGrounded())
        {
            canDamage = true;
        }
    }

    public void Die()
    {
        if (!eggIsDead)
        {
            //Stop the Music
            GameObject.Find("Audio Manager").GetComponent<AudioManager>().Stop("Gameplay");
            GameObject.Find("Audio Manager").GetComponent<AudioManager>().Stop("Ambient");
            //----------------------------------------------------------------------------------

            //Set the cascaras obtained
            GameObject.FindGameObjectWithTag("Player Prefs").GetComponent<PlayerPreferences>().SetCascarasObtained();
            //The method knows how many cascaras give to the player.
            //----------------------------

            //Set the Braker layer to the last one
            GetComponentInChildren<BrakeLayerController>().DieLayer();
            //----------------------------------------

            //Eliminate the rigidbody and the colliders
            Destroy(GetComponent<Rigidbody2D>());
            Destroy(GetComponent<CapsuleCollider2D>());
            //-----------------------------------------



            //Close the big leafs
            GameObject.Find("Leaf Pass").GetComponent<Animator>().SetBool("out", false);
            GameObject.Find("Leaf Pass").GetComponent<Animator>().SetBool("in", true);
            StartCoroutine(LoadSceneAfterDie());

            //to run this metho only once
            eggIsDead = true;
        }
        
    }

    public float secondsToWaitAfterDeath;
    IEnumerator LoadSceneAfterDie()
    {
        Debug.Log("Waiting");
        yield return new WaitForSeconds(secondsToWaitAfterDeath);
        SceneManager.LoadScene("PlayResults");
    }

    private void VerifyEggLife()
    {
        if (eggLife < 0 || eggLife == 0)
        {
            Die();
        }
    }
    #endregion


}
