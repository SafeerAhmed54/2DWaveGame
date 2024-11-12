using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] int speed;
    [SerializeField] Vector3 rotationPoint = Vector3.zero;
    [SerializeField] Vector3 rotationPosition = Vector3.forward;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rotaionAmount = CalculateRotation(Time.deltaTime);
        transform.RotateAround(rotationPoint, rotationPosition, rotaionAmount);
    }

    private float CalculateRotation(float delta)
    {
        return speed * delta;
    }
}
