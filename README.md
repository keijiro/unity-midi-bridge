Unity MIDI Bridge
=================

**Unity MIDI Bridge** is a C# plug-in for Unity that provides APIs for
communicating with MIDI devices. It sends and receives MIDI messages via the
bridge software and doesn't need to deal with any native code. It means that
you can access to the MIDI devices without Unity Pro license.

System Requirements
-------------------

- Unity 4 (Basic or Pro)
- This plug-in runs only on the desktop platforms (Windows or Mac OS X).

Sample Projects
---------------

You can find some sample projects in the [test branch]
(https://github.com/keijiro/unity-midi-bridge/tree/test). These sample projects
demonstrate functionalities and features of the plug-in.

Setting up
----------

#### Importing C# files

Import the C# source files (MidiBridge.cs, MidiInput.cs and MidiOut.cs). You
can simply drag and drop these files into the project view on Unity.

#### Launching Bridge

Extract the archive file (midi-bridge-osx.zip or midi-bridge-windows.zip) and
run "MIDI Bridge" which is in it.

Scripting Reference: MidiInput
------------------------------

You can omit *channel* arguments from these methods. In this case it returns
the union of the all channels.

#### GetKey (channel, noteNumber)

Returns the state of the key. If the key is "on", it returns the velocity value
(more than zero, up to 1.0f). If the key is "off", it returns zero.

#### GetKeyDown (channel, noteNumber)

Returns true only if the key was pressed down in the current frame.

#### GetKeyUp (channel, noteNumber)

Returns true only if the key was released in the current frame.

#### GetKnob (channel, knobNumber)

Returns the current knob (CC) value which will be between 0.0f and 1.0f.

#### GetKnobNumbers (channel)

Provides the list of knob (CC) numbers that has sent any CC messages.

Scripting Reference: MidiOut
----------------------------

#### SendNoteOn (channel, noteNumber, velocity)

Sends a note-on message to the specified channel with a note number and a
velocity value. The velocity value must be more than zero and up to 1.0f.

#### SendNoteOff (channel, noteNumber)

Sends a note-off message to the specified channel with a note number.

#### SendControlChange (channel, controllerNumber, value)

Sends a control-change (CC) message to the specified channel with a controller
number. The value must be between 0.0f and 1.0f.

MIDI Bridge for Mac OS X
------------------------

![screenshot]
(http://keijiro.github.io/unity-midi-bridge/bridge-screenshot-osx.png)

**MIDI Bridge for Mac OS X** is a kind of menu bar app which relays MIDI
messages between Unity and MIDI devices.

Simply run "MIDI Bridge" and then it appears as a status menu item on the
top-right corder of the screen. You can click the icon and it opens the
function menu. It shows the device list available at the moment, and provides
some other functionality.

You can select the destination device from the "MIDI Destinations" list. All
outgoing MIDI messages are delivered to it.

MIDI Bridge for Windows
-----------------------

![screenshot]
(http://keijiro.github.io/unity-midi-bridge/bridge-screenshot-windows1.png)

**MIDI Bridge for Windows** (MidiBridge.exe) is a command line application to
relay MIDI messages between Unity and MIDI devices.

Basically, what you need to do is just run the application. It captures the all
MIDI devices available on the launch and shows the list of these devices.

There are few points you have to take care.

- Every time you change the configuration (plug a new MIDI device, disconnect
  a device from the computer, etc.), it have to be restarted. You can restart
  the bridge internally by pressing down the enter key, or simply close and
  relaunch the application.
- Sometimes you may want to free a MIDI device to share it with other
  applications. In this case you have to use the **interactive mode** (see
  below), or run the application before launching MidiBridge and capture the
  device in advance.
- It sends outgoing messages to the all active output devices.

#### Interactive Mode

![screenshot]
(http://keijiro.github.io/unity-midi-bridge/bridge-screenshot-windows2.png)

You can run MidiBridge in the **interactive mode** by giving "/i" or "-i"
option. In this mode you can control MidiBridge at runtime from the console.

There are few commands you can use in this mode. You can input these commands
entirely or just the first character of the command.

- ID - activates/deactivates the specified device.
- scan - rescans and shows the all devices.
- reset - resets and recaptures the all devices.
- log - pops up the log viewer. Press the enter key to return to the command line.
- quit - terminates the bridge.

Related Projects
----------------

- [github.com/keijiro/midi-bridge-osx]
  (https://github.com/keijiro/midi-bridge-osx) - MIDI Bridge for OS X
- [github.com/keijiro/midi-bridge-windows]
  (https://github.com/keijiro/midi-bridge-windows) - MIDI Bridge for Windows

License
-------

Copyright (C) 2013 Keijiro Takahashi

Permission is hereby granted, free of charge, to any person obtaining a copy of
this software and associated documentation files (the "Software"), to deal in
the Software without restriction, including without limitation the rights to
use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
the Software, and to permit persons to whom the Software is furnished to do so,
subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS
FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER
IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
