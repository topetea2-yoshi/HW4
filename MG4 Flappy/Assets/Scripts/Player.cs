using UnityEngine;
using System;
public class Player : MonoBehaviour
{
    public static event Action OnScored;
    public void AddScore()
    {
        OnScored?.Invoke();
    }

   
}
