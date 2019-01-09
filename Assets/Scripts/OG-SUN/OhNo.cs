using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OhNo : MonoBehaviour {
    private AudioSource m_audioSource;

    private void Start(){
        m_audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerStay2D(Collider2D arg_col){
        if (Input.GetMouseButtonDown(0))
        {
            if (arg_col.gameObject.tag == "Wood"){
                m_audioSource.Play();
                Destroy(arg_col.gameObject);
            }
        }
    }
}
