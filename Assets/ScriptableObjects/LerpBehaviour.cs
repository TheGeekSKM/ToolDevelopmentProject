using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LerpBehaviour : MonoBehaviour
{
    //variables
    [SerializeField] public Transform firstTransform;
    [SerializeField] public Transform secondTransform;
    [SerializeField] public float movementDuration = 3f;
    

    private float elapsedTime;

    void Start()
    {
        transform.position = firstTransform.position;
    }

    void Update()
    {
        elapsedTime += Time.deltaTime;
        float movementPercentage = elapsedTime / movementDuration;

        transform.position = Vector3.Lerp(firstTransform.position, secondTransform.position, movementPercentage);
    }

    public void Remove()
    {
        Destroy(this);

    }
}
