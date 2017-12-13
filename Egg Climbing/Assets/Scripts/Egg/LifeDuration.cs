using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeDuration : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if (GetComponent<Rigidbody2D>().velocity.x > 2 && collision.gameObject.tag == "Side Walls")
        //{
        //    Debug.Log("Side scratch " + GetComponent<Rigidbody2D>().velocity.x);
        //}
        //if (GetComponent<Rigidbody2D>().velocity.y < -2f)
        //{
        //    Debug.Log("Down scratch " + GetComponent<Rigidbody2D>().velocity.y);
        //}
        
    }
}
