using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Camera _cam;
    [SerializeField , Range(1,100)] private float _rotationSpeed= 2f;
    [SerializeField] private Shooting bulletPrefab;
    [SerializeField] private Transform spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        _cam= Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        var mousePosition= _cam.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z=0;
        transform.up= Vector3.MoveTowards(transform.up,mousePosition,_rotationSpeed*Time.deltaTime);

        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(bulletPrefab,spawnPoint.position,Quaternion.identity).Init(transform.up);
        }


    }
}
