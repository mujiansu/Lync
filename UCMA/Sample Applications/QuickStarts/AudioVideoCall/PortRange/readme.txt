Title: AudioVideoFlow - AudioVideoSettings.

Description:

The application places an AudioVideo call to the designated target, after initalizing platform and endpoints. It then uses AudioVideoSettings to change the port range to be used by the media stack at runtime, and after successfully placing the AVCall, the application prints the content of the change to the console, and then quits; shutting the platform down normally.

Features:

	- Subscribing to a change in flow properties/dealing with being put on hold.
	- Basic AudioVideo call placement.
	- AudioVideoFlow handling and control.
	- Shifting the configuration of a currently active AudioVideoFlow.

Prerequisites:
	�	Microsoft Lync Server.
	�	Two users capable of sending/receiving Voice calls.
	�	The credentials for those users, and a client capable of logging in to Microsoft Lync Server.
	�	A currently logged-in client on Microsoft Lync Server.

Running the sample:
�	Replace the credentials in the variables at the beginning of the code sample with the credentials and server of the users from your Microsoft Lync Server topology.
�	Substitute the address of the called user in the code snippet with the address of a valid, currently signed-in user capable of receiving audio calls.
�	Open the project in Visual Studio, and hit F5.