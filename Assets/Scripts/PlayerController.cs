using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(transform.forward * Time.deltaTime * 20.0f);
    }
}
