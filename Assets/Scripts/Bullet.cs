using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float TimeAlive = 3f;
    private float _instantiatedTime;
    void Start() {
        _instantiatedTime = Time.time;
    }

    void Update() {
        if (Time.time - _instantiatedTime >= TimeAlive)
        {
            Destroy(gameObject);
        }
    }
}