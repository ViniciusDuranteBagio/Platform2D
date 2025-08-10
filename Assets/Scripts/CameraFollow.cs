using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // o objeto a seguir (o Player)
    public Vector3 offset = new Vector3(0, 0, -10); // distância da câmera

    void LateUpdate()
    {
        if (target != null)
        {
            transform.position = target.position + offset;
        }
    }
}
