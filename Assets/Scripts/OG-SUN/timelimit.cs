using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timelimit : MonoBehaviour {

    private float time;

    private int limit;

    Text text;

    // Use this for initialization
	void Start () {
        text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {

        time += Time.deltaTime;
        limit = 60 - (int)time;
        text.text = "残り時間："+limit.ToString();
	}
}
