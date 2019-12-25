using UnityEngine;
using System.Collections;

[System.Serializable]
public partial class BallControll : MonoBehaviour
{
    public int rotationSpeed;
    public int jumpHeight;
    private bool isFalling;
    public virtual void Update()
    {
        float rotation = Input.GetAxis("Horizontal") * this.rotationSpeed;
        rotation = rotation * Time.deltaTime;
        this.GetComponent<Rigidbody>().AddRelativeTorque(Vector3.back * rotation);
        if (Input.GetKeyDown(KeyCode.W) && (this.isFalling == false))
        {

            {
                int _1 = this.jumpHeight;
                Vector3 _2 = this.GetComponent<Rigidbody>().velocity;
                _2.y = _1;
                this.GetComponent<Rigidbody>().velocity = _2;
            }
        }
        this.isFalling = true;
    }

    public virtual void OnCollisionStay()
    {
        this.isFalling = false;
    }

    public BallControll()
    {
        this.rotationSpeed = 100;
        this.jumpHeight = 8;
    }

}