using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject[] nots;
    public Transform[] points;
    public float beat = (60/30) * 2;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > beat) {
            GameObject not = Instantiate(nots[Random.Range(0, 14)], points[Random.Range(0, 4)]);
            not.transform.localPosition = Vector3.zero;
            timer -= beat;
        }

        timer += Time.deltaTime; 
    }
}
