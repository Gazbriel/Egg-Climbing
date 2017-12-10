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
            //the condition is necessarly because that way if the egg is not
            //quiet, the canjump variable activates and can jump from a spine, and i dont want that
            if (GetComponent<Rigidbody2D>().velocity.y < 2)
            {
                Debug.Log("Safe Ground Touched");
                GameObject.Find("Slide Detector").GetComponent<SwipeDetector>().SetCanJump(true);
            }
            
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        GameObject.Find("Slide Detector").GetComponent<SwipeDetector>().SetCanJump(false);
    }
}
