using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBalls : MonoBehaviour
{
    [SerializeField] GameObject[] ballPrefab;

    [SerializeField]float spawnPosX;

    [SerializeField] float spawnPosY;


    //[SerializeField] float spawnPosZ;

    

    [SerializeField] float secondSPawn = 0.2f;



    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(BallSpawn());

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator BallSpawn()
    {
        while(true)
        {
            var wanted = Random.Range(spawnPosX,spawnPosY);
            var position= new Vector3(wanted,transform.position.y);
            GameObject gameObject = Instantiate(ballPrefab[Random.Range(0,ballPrefab.Length)], position,Quaternion.identity);
            yield return new  WaitForSeconds(secondSPawn);

        }
    }
}
