using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowController : MonoBehaviour
{
    [SerializeField] private Transform heroTransform;
    private Vector3 cameraOffset;
    private Vector3 newPosition;

    [SerializeField] private float lerpValue;


    // Start is called before the first frame update
    void Start()
    {
        cameraOffset = transform.position - heroTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // LateUpdate is called after Update methods
    // It is guaranteed to run after all items have been processed in Update
    void LateUpdate()
    {
        SetCameraSmoothFollow();
    }

    private void SetCameraSmoothFollow()
    {
        newPosition = Vector3.Lerp(transform.position, new Vector3(0f, heroTransform.position.y, heroTransform.position.z) + cameraOffset, lerpValue * Time.deltaTime);
        transform.position = newPosition;
    }
}
