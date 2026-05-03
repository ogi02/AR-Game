using UnityEngine;
using Quaternion = UnityEngine.Quaternion;
using Vector3 = UnityEngine.Vector3;

public class ResetRbPositionOfObject : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;

    private Vector3 rbStartPosition;
    private Quaternion rbStartRotation;

    void Start()
    {
        UIButtonHandler.OnUIResetButtonClicked += ResetRbPositionOnButtonClicked;

        // Save the starting position and rotation of the object
        rbStartPosition = rb.transform.localPosition;
        rbStartRotation = rb.transform.localRotation;
    }

    private void ResetRbPositionOnButtonClicked()
	{
        // Reset physics
        rb.isKinematic = true;

        // Reset original position and rotation of the object
        rb.transform.localPosition = rbStartPosition;
        rb.transform.localRotation = rbStartRotation;

        // Reset velocity in case the object is moving when the "Reset" button is clicked
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
	}

    private void OnDestroy()
	{
        UIButtonHandler.OnUIResetButtonClicked -= ResetRbPositionOnButtonClicked;
	}
}
