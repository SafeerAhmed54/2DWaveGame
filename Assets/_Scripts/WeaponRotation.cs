using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponRotation : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb2DWeapon;
    [SerializeField] private int speed;
    // Start is called before the first frame update
    void Start()
    {
        rb2DWeapon = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb2DWeapon.MoveRotation(rb2DWeapon.rotation + speed * Time.fixedDeltaTime);
    }
}
