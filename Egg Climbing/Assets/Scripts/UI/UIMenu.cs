using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMenu : MonoBehaviour {

    public float timeToWait;
    private bool play;// true if the game need to start
	public void PlayGame()
    {
        SetOutAnimations();
        play = true;
    }

    private void Update()
    {
        if (play)
        {
            if (timeToWait < 0)
            {
                SceneManager.LoadScene("Main");
            }
            else
            {
                timeToWait -= Time.deltaTime;
            }
        }
    }

    #region Set Out the animations
    private void SetOutAnimations()
    {
        GameObject.Find("Play").GetComponent<Animator>().SetBool("out", true);
        GameObject.Find("Cartel").GetComponent<Animator>().SetBool("out", true);
        GameObject.Find("Settings").GetComponent<Animator>().SetBool("out", true);
        GameObject.Find("Other").GetComponent<Animator>().SetBool("out", true);
    }
    #endregion
}
