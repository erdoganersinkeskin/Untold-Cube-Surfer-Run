using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField] private HeroStackController heroStackController;

    private Vector3 direction = Vector3.back;
    private bool isStack = false;
    private RaycastHit hit;

    // Start is called before the first frame update
    void Start()
    {
        heroStackController = GameObject.FindObjectOfType<HeroStackController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        SetCubeRaycast();
    }

    private void SetCubeRaycast()
    {
        if (Physics.Raycast(transform.position, direction, out hit, 1f))
        {
            if (!isStack)
            {
                isStack = true;
                heroStackController.IncreaseCubeStack(gameObject);
                SetDirection();
            }

            if (hit.transform.name == "ObstacleCube")
            {
                heroStackController.DecreaseCubeStack(gameObject);
            }
        }
    }

    private void SetDirection()
    {
        direction = Vector3.forward;
    }
}
