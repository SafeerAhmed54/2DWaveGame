using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private string _horizontalAxis = "Horizontal";
    [SerializeField] private string _verticalAxis = "Vertical";
    [SerializeField] private int speed = 3;
    [SerializeField] private Rigidbody2D rb2DPlayer;

    public UnityEvent onPlayerDie;

    private Vector2 _input;
    // Start is called before the first frame update
    void Start()
    {
        rb2DPlayer = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rb2DPlayer.velocity = _input * speed;
    }
    // Update is called once per frame
    void Update()
    {
        float horizontalAxis = Input.GetAxisRaw(_horizontalAxis);
        float verticalAxis = Input.GetAxisRaw(_verticalAxis);
        _input = new Vector2(horizontalAxis , verticalAxis);
        _input.Normalize();

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(onPlayerDie != null)
        {
            onPlayerDie.Invoke();
        }
        Destroy(gameObject);
    }
}
