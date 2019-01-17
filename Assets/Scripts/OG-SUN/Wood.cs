using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wood : MonoBehaviour {

    private float m_deathTime = 10f;

    private void Start(){
        StartCoroutine(desu());
    }

    IEnumerator desu(){
        while(true){
            yield return new WaitForSeconds(m_deathTime);
            Death();
        }
    }

    void Death(){
        Destroy(gameObject);
    }
}
