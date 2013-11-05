using UnityEngine;

public static class MidiOutput
{
    public static void SendNoteOn(int channel, int noteNumber, float velocity)
    {
        velocity = Mathf.Clamp (127.0f * velocity, 0.0f, 127.0f);
        MidiBridge.instance.Send (0x90 + channel, noteNumber, (int)velocity);
    }

    public static void SendNoteOff(int channel, int noteNumber)
    {
        MidiBridge.instance.Send (0x80 + channel, noteNumber, 0);
    }

    public static void SendControlChange(int channel, int controlChannel, float value)
    {
        value = Mathf.Clamp (127.0f * value, 0.0f, 127.0f);
        MidiBridge.instance.Send (0xb0 + channel, controlChannel, (int)value);
    }
}
