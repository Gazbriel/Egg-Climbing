using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrongBranchController : MonoBehaviour {

	// Use this for initialization
	void Start () {
        a = Random.Range(0, 2);
        SetPosition();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private int a;
    #region Set Position random, left or right.
    private void SetPosition()
    {
        if (a == 0)
        {

            Debug.Log("Placed ramdom");
            gameObject.transform.position = new Vector3(-5.4f, transform.position.y, transform.position.z);
            gameObject.transform.localScale = new Vector3(-1, 1, 1);
            gameObject.transform.rotation = new Quaternion(gameObject.transform.rotation.x, gameObject.transform.rotation.y, -gameObject.transform.rotation.z, transform.rotation.w);
        }
    else
	{
             gameObject.transform.position = new Vector3(5.4f, transform.position.y, transform.position.z);
        }
        
    }

    #endregion
}
