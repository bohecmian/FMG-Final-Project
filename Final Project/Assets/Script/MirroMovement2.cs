using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirroMovement : MonoBehaviour
{
    public Transform playerTarget;
    public Transform mirror;
    public float offsetY = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 localPlayer = mirror.InverseTransformPoint(playerTarget.position);
        Vector3 mirroredPosition = new Vector3(localPlayer.x, localPlayer.y, -localPlayer.z);
        Vector3 worldMirroredPosition = mirror.TransformPoint(mirroredPosition) + new Vector3(0, -offsetY, 0);
        transform.position = worldMirroredPosition;

        // Compute mirrored look-at target
        Vector3 lookAtTarget = new Vector3(-localPlayer.x, localPlayer.y, localPlayer.z);
        Vector3 worldLookAtTarget = mirror.TransformPoint(lookAtTarget) + new Vector3(0, -offsetY, 0);
        transform.LookAt(worldLookAtTarget);
        // Debugging to visualize positions
        Debug.DrawLine(transform.position, worldLookAtTarget, Color.red);
    }
}
