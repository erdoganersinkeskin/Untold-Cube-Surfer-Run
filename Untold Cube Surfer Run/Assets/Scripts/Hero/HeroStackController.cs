using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroStackController : MonoBehaviour
{
    public List<GameObject> heroStack = new List<GameObject>();
    private GameObject lastCubeObject;
    // Start is called before the first frame update
    void Start()
    {
        UpdateLastCubeObject();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncreaseCubeStack(GameObject _gameObject)
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + 2f, transform.position.z);
        _gameObject.transform.position = new Vector3(lastCubeObject.transform.position.x, lastCubeObject.transform.position.y - 2f, lastCubeObject.transform.position.z);
        _gameObject.transform.SetParent(transform);
        heroStack.Add(_gameObject);
        UpdateLastCubeObject();
    }

    public void DecreaseCubeStack(GameObject _gameObject)
    {
        _gameObject.transform.parent = null;
        heroStack.Remove(_gameObject);
        UpdateLastCubeObject();
    }

    private void UpdateLastCubeObject()
    {
        lastCubeObject = heroStack[heroStack.Count - 1];
    }
}
