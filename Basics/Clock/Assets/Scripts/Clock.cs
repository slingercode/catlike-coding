using System;
using UnityEngine;

public class Clock : MonoBehaviour
{
  private const float hoursToDegrees = -30f, minutesToDegrees = -6f, secondsToDegrees = -6f;

  [SerializeField]
  private Transform hoursPivot, minutesPivot, secondsPivot;

  void Update()
  {
    var currentTime = DateTime.Now.TimeOfDay;

    hoursPivot.localRotation = Quaternion.Euler(0f, 0f, hoursToDegrees * (float)currentTime.TotalHours);
    minutesPivot.localRotation = Quaternion.Euler(0f, 0f, minutesToDegrees * (float)currentTime.TotalMinutes);
    secondsPivot.localRotation = Quaternion.Euler(0f, 0f, secondsToDegrees * (float)currentTime.TotalSeconds);
  }
}
