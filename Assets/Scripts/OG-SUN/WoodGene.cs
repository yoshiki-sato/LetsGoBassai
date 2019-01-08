using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodGene : MonoBehaviour {


    [SerializeField]
    private GameObject wood;

    [SerializeField]
    [Range(1f, 5f)]
    private float m_birthTime;

    void Start()
    {
        StartCoroutine(Gene());
    }

    IEnumerator Gene(){
        while (true){
            yield return new WaitForSeconds(m_birthTime);
            WoodBirth();
        }
    }

    void WoodBirth(){
        float genex = Random.Range(-9f, 9f);
        float geney = Random.Range(-4f, 4f); ;
        Vector3 genepos = new Vector3(genex, geney, 0);
        Instantiate(wood, genepos, Quaternion.identity);
    }
}
