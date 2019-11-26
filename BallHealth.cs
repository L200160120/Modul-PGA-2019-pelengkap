using UnityEngine;
using System.Collections;

[System.Serializable]
public partial class BallHealth : MonoBehaviour
{
    public int maxFallDistance;
    public virtual void Update()
    {
        if (this.transform.position.y <= this.maxFallDistance)
        {
            Application.LoadLevel("gameSederhana");
        }
    }

    public BallHealth()
    {
        this.maxFallDistance = -10;
    }

}