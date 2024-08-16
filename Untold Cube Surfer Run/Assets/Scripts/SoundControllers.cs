using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControllers : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip audioClip;
    private Transform cameraTransform;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = audioClip;
        cameraTransform = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(cameraTransform.position, transform.position);
        float maxDistance = 10f;
        float normalizedDistance = Mathf.Clamp01(distance / maxDistance);
        audioSource.volume = 1f - normalizedDistance;
    }
}
