using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeEnemyMovement : MonoBehaviour
{

    [SerializeField]
    float enemySpeed;

    float timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        timer = timer + Time.deltaTime;
        
        transform.position += transform.right * enemySpeed * Time.deltaTime;

    }
}
