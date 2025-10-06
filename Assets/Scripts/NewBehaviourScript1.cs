using UnityEngine;

public class JumpCube : MonoBehaviour
{
    // Make the cube jump when pressing Space



        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Rigidbody rb = GetComponent<Rigidbody>();
                if (rb != null)
                {
                    rb.AddForce(Vector3.up * 5f, ForceMode.Impulse);
                }
            }
        }

    void Start()
    {
        Debug.Log("Ready to jump!");
    }
}
