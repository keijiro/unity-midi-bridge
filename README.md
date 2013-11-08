Unity MIDI Bridge
=================

**Unity MIDI Bridge** is a plug-in for Unity that provides APIs for communicating
with MIDI devices. It uses external bridge software to communicate with the devices,
and runs without any native code plug-in. Therefore you can use this plug-in without
Unity Pro license.

System Requirements
-------------------

- Unity 4
- Windows or Mac OS X

Setting up
----------

#### Importing C# files

Drag and drop the .cs files (MidiBridge.cs, MidiInput.cs and MidiOut.cs) into the
project view.

#### Launching Bridge

Extract the archive file (midi-bridge-osx.zip or midi-bridge-windows.zip) and
run the bridge software in it.

MIDI Bridge for Mac OS X
------------------------

![screenshot](http://keijiro.github.io/unity-midi-bridge/bridge-screenshot-osx.png)

**MIDI Bridge for Mac OS X** is a kind of menu bar app. It relays MIDI messages
between Unity and external MIDI devices.

Simply run "MIDI Bridge" and it appears as a status menu item on the top-right
corder of the display. You can click the icon and it shows the device list and
Log Viewer.

You can click the one of the destination device and put a check mark on it.
And then Bridge uses that device as a **default MIDI-out device**. MIDI messages
sent from Unity are delivered to the device.

MIDI Bridge for Windows
-----------------------

![screenshot](http://keijiro.github.io/unity-midi-bridge/bridge-screenshot-windows.png)

**MIDI Bridge for Windows** (MidiBridge.exe) is a command line application to relay
MIDI messages between Unity and external MIDI devices.

Basically, what you have to do is just run the application. There are few points
you have to take care.

- Every time you change the configuration (plug new MIDI devices or disconnect
  devices from the computer), you have to restart MidiBridge.exe.
- MidiBridge.exe opens all MIDI-in devices available when it was launched. It
  might conflict with other MIDI capable applications.
- MidiBridge.exe sends MIDI messages to all MIDI-out devices available.

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
