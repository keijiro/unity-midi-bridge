public struct MidiMessage
{
    // MIDI status byte.
    public byte status;
    
    // MIDI data bytes.
    public byte data1;
    public byte data2;
    
    public MidiMessage (byte status)
    {
        this.status = status;
        data1 = data2 = 0;
    }

    public MidiMessage (byte status, byte data1)
    {
        this.status = status;
        this.data1 = data1;
        data2 = 0;
    }

    public MidiMessage (byte status, byte data1, byte data2)
    {
        this.status = status;
        this.data1 = data1;
        this.data2 = data2;
    }

    public override string ToString ()
    {
        return string.Format ("s({0:X2}) d({1:X2},{2:X2})", status, data1, data2);
    }
}
