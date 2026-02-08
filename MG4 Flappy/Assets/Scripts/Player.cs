using UnityEngine;
using System;
public class Player : MonoBehaviour
{
    public static event Action OnScored;

    [SerializeField] private float flapForce = 5f;
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    public void Update()
    {
       if (Input.GetKeyDown(KeyCode.Space))
        {
               Flap();
        }
    }

    private float Flap()
    {
        rb.velocity = new Vector2(rb.velocity.x, flapForce);
        AudioManager.Instance?.playFlapSound();
        return rb.velocity.y;

    }
    public void AddScore()
    {
        OnScored?.Invoke();
    }

   
}
