using UnityEngine;

public class HideBarOnStart : MonoBehaviour
{
    [SerializeField] private Canvas ARMagicBar;

    void Start()
    {
        UIButtonHandler.OnUIStartButtonClicked += OnStartButtonClicked;
        UIButtonHandler.OnUIResetButtonClicked += OnResetButtonClicked;
    }

    private void OnStartButtonClicked()
	{
        // Hide the bar with object once the game is started
        ARMagicBar.enabled = false;
	}

    private void OnResetButtonClicked()
    {
        // Show the bar with object once the game is stopped
        ARMagicBar.enabled = true;
    }
}
