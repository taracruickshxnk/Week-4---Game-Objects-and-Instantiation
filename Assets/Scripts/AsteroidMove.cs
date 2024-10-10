using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class AsteroidMove : MonoBehaviour { 
    public int rotz;
    public int mx, my;
    public Rigidbody2D myRigid;

    void Start() {
        myRigid = GetComponent<Rigidbody2D>();

        myRigid.AddForce(Vector3.up * my);
        myRigid.AddForce(Vector3.right * mx);
        myRigid.AddTorque(rotz);
    }

    void Update() {
        
    }
}
