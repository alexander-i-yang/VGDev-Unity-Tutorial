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
        print(transform.rotation);
        Helper.LookTowards(transform, Vector3.zero);
        print(transform.rotation);
    }

    // Update is called once per frame
    void Update() {
        //transform.position = Vector3.Lerp(_startPos, Vector3.zero, (Time.time - _spawnInTime) / TraversalTime);
    }
    
    void OnCollisionEnter(Collision collision) {
        Bullet b = collision.gameObject.GetComponent<Bullet>();
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (b != null) {
            Destroy(gameObject);
        }
    }

}