using UnityEngine;
using CoreNameSpace;

class Movement : MonoBehaviour
{
    [Header("Options")]
    [SerializeField] [Range(50, 100)] float SpeedDirectionRotation;
    [SerializeField] [Range(10, 100)] float ForceUp;
    private GameObject ourCharacter;
    private Rigidbody rb;

    void Start()
    {
        ourCharacter = this.gameObject;
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        Core.Move(rb, SpeedDirectionRotation, ForceUp, ourCharacter);
        Scene.ResetTheScene(KeyCode.L);
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Obstacle")
        {
            Debug.Log("You hit an obstacle");
            Scene.ResetOnlyScene();
        }
    }

}