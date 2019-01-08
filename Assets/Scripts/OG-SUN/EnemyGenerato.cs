using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerato : MonoBehaviour {

    private bool Birthing;

    [SerializeField]
    private GameObject m_Popuko;

    [SerializeField][Range(1f, 5f)]
    private float m_birthTime;

    AudioSource m_audioSource;

    SpriteRenderer enemySpriteRenderer;
    SpriteRenderer m_spriteRenderer;

    private void Start(){
        m_audioSource = GetComponent<AudioSource>();
        StartCoroutine(Gene());
        enemySpriteRenderer = m_Popuko.GetComponent<SpriteRenderer>();
        m_spriteRenderer = GetComponent<SpriteRenderer>();
    }

    IEnumerator Gene(){
        while (true)
        {
            yield return new WaitForSeconds(m_birthTime);
            EnemyBirth();
        }
    }

    void EnemyBirth()
    {
        Instantiate(m_Popuko,transform.position,Quaternion.identity);
        // m_audioSource.Play();
        //enemySpriteRenderer.flipY = m_spriteRenderer.flipY;
    }
}
