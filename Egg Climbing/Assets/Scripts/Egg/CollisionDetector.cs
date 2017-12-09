using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}
    

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Safe Ground")
        {
            Debug.Log("Safe Ground Touched");
            GameObject.Find("Slide Detector").GetComponent<SwipeDetector>().SetCanJump(true);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        GameObject.Find("Slide Detector").GetComponent<SwipeDetector>().SetCanJump(false);
    }
}
