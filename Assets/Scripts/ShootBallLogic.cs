using UnityEngine;

public class ShootBallLogic : MonoBehaviour
{
    private Camera mainCamera;

    [SerializeField] private GameObject ballPrefab;
    [SerializeField] private float ballForwardForce = 500f;


    void Start()
    {
        mainCamera = FindObjectOfType<Camera>();
        UIButtonHandler.OnUIShootButtonClicked += ShootBallOnButtonClicked;
    }

    private void ShootBallOnButtonClicked()
	{
        // Spawn position of the ball is a bit in front of the camera
        Vector3 spawnPosition = mainCamera.transform.position + mainCamera.transform.forward * 0.03f;
        Quaternion spawnRotation = mainCamera.transform.rotation;

        GameObject spawnedBall = Instantiate(ballPrefab, spawnPosition, spawnRotation);
        Rigidbody rb = spawnedBall.GetComponent<Rigidbody>();

        if (rb != null)
		{
            // Add forward force to the spawned ball
            rb.AddForce(mainCamera.transform.forward * ballForwardForce);
		}

        // Destroy the ball in 5 seconds, so that the balls don't clutter the canvas
        Destroy(spawnedBall, 5f);
	}
}
