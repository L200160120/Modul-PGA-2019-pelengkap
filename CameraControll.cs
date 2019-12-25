using UnityEngine;
using System.Collections;

[System.Serializable]
public partial class CameraControll : MonoBehaviour
{
    public Transform target;
    public int distance;
    public float lift;
    public virtual void Update()
    {
        this.transform.position = this.target.position + new Vector3(0, this.lift, this.distance);
        this.transform.LookAt(this.target);
    }

    public CameraControll()
    {
        this.distance = -10;
        this.lift = 1.5f;
    }

}