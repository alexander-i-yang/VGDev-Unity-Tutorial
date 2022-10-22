using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float TraversalTime = 10f;
    private float _spawnInTime = 0;
    private Vector3 _startPos;
    // Start is called before the first frame update
    void Start() {
        _spawnInTime = Time.time;
        _startPos = transform.position;
        Helper.LookTowards(transform, Vector3.zero);
    }

    void OnCollisionEnter(Collision collision) {
        Bullet b = collision.gameObject.GetComponent<Bullet>();
        if (b != null) {
            Destroy(gameObject);
        }
    }

}