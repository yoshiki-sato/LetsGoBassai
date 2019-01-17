using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class killcount : MonoBehaviour {


    [SerializeField]
    private OhNo ono;


    Text text;
    // Use this for initialization
    void Start () {
        text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        text.text = "切る数："+ono.woodkill.ToString();
	}
}
