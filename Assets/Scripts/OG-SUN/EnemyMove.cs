using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {

    [SerializeField][Range(1f,5f)]
    private float m_enemySpeed;

    private GameObject m_targetPlayer;

    private Vector3 m_targetPosition;

    private SpriteRenderer m_spriteRenderer;

    private Renderer m_renderer;

    private bool m_enabled;

    private Vector3 angleVec;

    // Use this for initialization
    void Start () {

        m_enabled = false;
        m_renderer = GetComponent<Renderer>();
        m_spriteRenderer = GetComponent<SpriteRenderer>();

        //敵の座標格納
        if (!m_targetPlayer){
            m_targetPlayer = GameObject.FindWithTag("Player");
            m_targetPosition = m_targetPlayer.transform.position;
        }

        //敵の位置によって移動方向ベクトル変更
        if (transform.position.x > m_targetPosition.x){
            m_enemySpeed = m_enemySpeed * -1f;
            m_spriteRenderer.flipX = false;
        }
        else{
            m_enemySpeed = m_enemySpeed * 1f;
            m_spriteRenderer.flipX = true;
        }

        //角度指定
        float zRotation = Mathf.Atan2(m_targetPosition.y - transform.position.y,
        m_targetPosition.x - transform.position.x) * Mathf.Rad2Deg;

        //値格納
        float AngleRotation = zRotation;

        //取得した角度反映
        transform.rotation = Quaternion.Euler(0f, 0f, AngleRotation);
    }
	
	// Update is called once per frame
	void Update () {
        PopukoMove();

        if (!m_enabled && m_renderer.isVisible)
            m_enabled = true;
        if (m_enabled && !m_renderer.isVisible)
            Destroy(gameObject);
	}


    private void PopukoMove(){


        /*
        //モロモロの処理
        var theta = Mathf.Atan2(transform.position.y - m_targetPosition.y,
                                transform.position.x - m_targetPosition.x);
        var vy = Mathf.Sin(theta) * 5f;


        GetComponent<Rigidbody2D>().velocity = new Vector2(m_enemySpeed,-vy);
        */

        //移動量
        angleVec = transform.rotation * new Vector3(m_enemySpeed, 0f, 0);

        //向いている方向に向かって移動
        transform.position += angleVec * Time.deltaTime;
    }
}
