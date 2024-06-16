using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody2D rb;
    private Enemy target;
    private void Update()
    {
    }
    public void Initialize(Enemy enemy)
    {
        target = enemy;
    }
}
