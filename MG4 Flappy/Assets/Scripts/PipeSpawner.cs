using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{

    public GameObject pipePrefab;
    public float spawnRate = 1.3f;
    public float heightOffset = 10f;
    // Start is called before the first frame update
    void Start()
    {
        Coroutine coroutine = StartCoroutine(SpawnPipe());
    }

    // Update is called once per frame
    IEnumerator SpawnPipe()
    {
        while(true)
        {
            float waitTime = Random.Range(spawnRate, heightOffset);
            yield return new WaitForSeconds(waitTime);

            Vector3 spawnPos = new Vector3(10f, Random.Range(1f, 3f), 0f);
            Instantiate(pipePrefab,transform.position,Quaternion.identity);
        }
    }
}
