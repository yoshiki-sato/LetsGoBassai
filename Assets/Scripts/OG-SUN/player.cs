using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour {

    SpriteRenderer m_spriteRenderer;
    AudioSource m_audioSource;

    bool deadby;

    private void Start(){
        m_audioSource = GetComponent<AudioSource>();
    }

    void move(){
        deadby = false;
        transform.rotation = Quaternion.Euler(0,0,0);

        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 5.0f;
        var y = Input.GetAxis("Vertical") * Time.deltaTime * 5.0f;

        transform.position += new Vector3(x, y, 0);
    }


    void dead(){
        deadby = true;
        transform.rotation = Quaternion.Euler(0, 0, 90);
    }
    void Update(){

        if (Input.GetKeyDown(KeyCode.D)){
            transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
        }
        if (Input.GetKeyDown(KeyCode.A)){
            transform.localScale = new Vector3(-0.3f, 0.3f, 0.3f);
        }

        if (Input.GetKey(KeyCode.Space)){
            dead();
        }else{
            move();
        }
    }

    private void OnTriggerStay2D(Collider2D arg_col)
    {
        if (arg_col.gameObject.tag == "kuma")
        {
            //死んだふりしてなければ
            if (!deadby){
                SceneManager.LoadScene("GameOver");
            }
        }
    }
}
