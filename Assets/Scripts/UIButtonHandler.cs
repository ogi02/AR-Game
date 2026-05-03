using System;
using UnityEngine;
using UnityEngine.UI;

public class UIButtonHandler : MonoBehaviour
{
    [SerializeField] private Button UIStartButton;
    [SerializeField] private Button UIClearButton;
    [SerializeField] private Button UIShootButton;
    [SerializeField] private Button UIResetButton;

    public static event Action OnUIStartButtonClicked;
    public static event Action OnUIClearButtonClicked;
    public static event Action OnUIShootButtonClicked;
    public static event Action OnUIResetButtonClicked;

    void Start()
    {
        UIStartButton.onClick.AddListener(OnStartButtonClicked);
        UIClearButton.onClick.AddListener(OnClearButtonClicked);
        UIShootButton.onClick.AddListener(OnShootButtonClicked);
        UIResetButton.onClick.AddListener(OnResetButtonClicked);

        // While the gravity is disabled, shooting and resetting is disabled
        UIShootButton.gameObject.SetActive(false);
        UIResetButton.gameObject.SetActive(false);
    }

    void OnStartButtonClicked()
	{
        OnUIStartButtonClicked?.Invoke();
        // Once we start, we hide the "Start" and "Clear" buttons and we show the "Shoot" and "Reset" buttons
        UIStartButton.gameObject.SetActive(false);
        UIClearButton.gameObject.SetActive(false);
        UIShootButton.gameObject.SetActive(true);
        UIResetButton.gameObject.SetActive(true);
	}

    void OnClearButtonClicked()
    {
        OnUIClearButtonClicked?.Invoke();
    }

    void OnShootButtonClicked()
    {
        OnUIShootButtonClicked?.Invoke();
    }

    void OnResetButtonClicked()
    {
        OnUIResetButtonClicked?.Invoke();
        // Once we reset, we show the "Start" and "Clear" buttons and we hide the "Shoot" and "Reset" buttons
        UIStartButton.gameObject.SetActive(true);
        UIClearButton.gameObject.SetActive(true);
        UIShootButton.gameObject.SetActive(false);
        UIResetButton.gameObject.SetActive(false);
    }
}
