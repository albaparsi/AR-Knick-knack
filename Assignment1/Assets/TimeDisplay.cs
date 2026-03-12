using UnityEngine;
using TMPro;

public class TimeDisplay : MonoBehaviour
{
    public TextMeshPro timeText;

    void Start()
    {
        if (timeText == null)
        {
            timeText = GetComponent<TextMeshPro>();
        }

        UpdateTime();
        InvokeRepeating(nameof(UpdateTime), 1f, 60f); // update every 60 seconds
    }

    void UpdateTime()
    {
        // Local device time (for now)
        System.DateTime localTime = System.DateTime.Now;
        string timeString = localTime.ToString("hh:mm tt"); // e.g. 03:21 PM

        if (timeText != null)
        {
            timeText.text = timeString;
        }
    }
}
