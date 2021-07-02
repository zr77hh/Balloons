using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    [SerializeField]
    Material[] materials;
    Rigidbody rb;
    public Transform lookAt;
    private void Awake() 
    {
        GetComponentInChildren<Renderer>().material = materials[Random.Range(0,materials.Length)];
        LeanTween.scale(gameObject,Vector3.one,0.5f);  
        rb = GetComponent<Rigidbody>(); 
    }

    void Update()
    {
      transform.LookAt(lookAt.position);
    }

    private void FixedUpdate() 
    {
        Vector3 force = new Vector3(Random.Range(0,0.2f),10,Random.Range(0,0.2f)*Time.fixedDeltaTime);
        rb.AddForce(force);
        
    }
}
