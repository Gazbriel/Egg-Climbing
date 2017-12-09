using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlendingBranch : MonoBehaviour {

    public float blendingForce;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    private void BlendBranch()
    {
        if (gameObject.transform.rotation.z < 20)
        {
            gameObject.transform.parent.Rotate(0f, 0f, blendingForce);
        }
    }


    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Egg")
        {
            BlendBranch();
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {

    }
}
