using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OhNo : MonoBehaviour {

    private void OnTriggerStay2D(Collider2D arg_col){
        if (Input.GetMouseButtonDown(0))
        {
            if (arg_col.gameObject.tag == "Wood")
            {
                Destroy(arg_col.gameObject);
            }
        }
    }
}
