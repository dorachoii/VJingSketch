using UnityEngine;
using MidiJack;

public class LaunchpadInput : MonoBehaviour
{
    void Update()
    {
        for (int i = 0; i < 128; i++)
        {
            if (MidiMaster.GetKeyDown(i))
            {
                Debug.Log("Pressed: " + i);
            }
            if (MidiMaster.GetKeyUp(i))
            {
                Debug.Log("Released: " + i);
            }
        }
    }
}
