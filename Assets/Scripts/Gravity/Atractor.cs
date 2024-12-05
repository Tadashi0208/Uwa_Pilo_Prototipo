using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atractor : MonoBehaviour
{
    public float gravity=-10f;

    [SerializeField] GameObject cam;
    
    public void Attract(GameObject body)
    {
        Vector3 targetDir=(body.transform.position-transform.position).normalized;
        Vector3 bodyUp=body.transform.up;

        body.transform.rotation = Quaternion.FromToRotation(bodyUp,targetDir)*body.transform.rotation;
        cam.transform.rotation=Quaternion.FromToRotation(cam.transform.up,targetDir)*cam.transform.rotation;
        body.GetComponent<Rigidbody>().AddForce(targetDir*gravity);
    }
}
