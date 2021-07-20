using UnityEngine;
using CoreNameSpace;

class Movement : MonoBehaviour
{
    [Header("Options")]
    [SerializeField] [Range(50, 500)] float SpeedDirectionRotation;
    [SerializeField] [Range(10, 500)] float ForceUp;
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

}