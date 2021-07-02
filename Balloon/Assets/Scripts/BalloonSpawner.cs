using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject BalloonBrefab;
    [SerializeField]
    Transform SpawnPoint,parentTransform;
    Rigidbody rb;
    private void Awake() 
    {
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject balloon = Instantiate(BalloonBrefab,SpawnPoint.position,Quaternion.identity);
            balloon.GetComponent<SpringJoint>().connectedBody = rb;
            balloon.GetComponent<Balloon>().lookAt = transform;
            // to keep the hierarchy organized
            balloon.transform.SetParent(parentTransform);
        }
    }
}
