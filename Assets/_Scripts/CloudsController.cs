using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudsController : MonoBehaviour
{
    [SerializeField] private Transform[] clouds = new Transform[5];
    [SerializeField] private float speed = 1.0f;
    [SerializeField] private float limitPositionX = -12.5f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"The First Transform is :{clouds[0]} ");
        Debug.Log($"The First Transform is :{clouds[1]} ");
        Debug.Log($"The First Transform is :{clouds[2]} ");
        Debug.Log($"The First Transform is :{clouds[clouds.Length-1]} ");
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < clouds.Length; i++)
        {
            clouds[i].position = clouds[i].position + Vector3.right * speed * Time.deltaTime;

            if(clouds[i].position.x > limitPositionX)
            {
                clouds[i].position -=  new Vector3(2 * limitPositionX, 0, 0);
            }
        }
        
    }
}
