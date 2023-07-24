using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public Transform[] placeList;
    public GameObject[] meteoryty;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(Random.Range(0.1f, 0.5f));
        Instantiate(meteoryty[Random.Range(0, meteoryty.Length)], placeList[Random.Range(0, placeList.Length)]);
        StartCoroutine(Spawn());
    }
}
