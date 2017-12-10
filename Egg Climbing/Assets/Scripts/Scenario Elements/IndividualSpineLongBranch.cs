using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndividualSpineLongBranch : MonoBehaviour {


    public string position;
	// Use this for initialization
	void Start () {
        
        
	}
	
	// Update is called once per frame
	void Update () {
        switch (position)
        {
            case "left":
                if (!GetComponentInParent<LongBranchSpines>().GetSpineLeft())
                {
                    Debug.Log("Left false");
                    //enabled = false;
                    Destroy(this.gameObject);
                }
                break;

            case "center":
                if (!GetComponentInParent<LongBranchSpines>().GetSpineCenter())
                {
                    Debug.Log("Center false");
                    //enabled = false;
                    Destroy(this.gameObject);
                }
                break;

            case "right":
                if (!GetComponentInParent<LongBranchSpines>().GetSpineRight())
                {
                    Debug.Log("Right false");
                    //enabled = false;
                    Destroy(this.gameObject);
                }
                break;
        }
    }
}
