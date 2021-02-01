# AlphaBot2 Controller Application
A Windows application written in C# that connects to an AlphaBot2 on the network via SSH protocol, and sends control commands.

> [Master's thesis (in croatian)](https://zir.nsk.hr/en/islandora/object/etfos%3A2882)

> [AlphaBot2's wiki page](https://www.waveshare.com/wiki/AlphaBot2)

## How it works
First part of the application is the connection window, where it displays all devices on the networks the PC is connected to.
This is done by using a Windows command `arp -a`. The programs runs a background console with the mentioned command and parses out the output of the command into a list of IP addresses.
Afterwards, said list gets displayed on the window and for each item on the list, program starts a background worker to resolve the DNS name of the IP address. If the DNS request doesn't get a response, the IP address' host name is marked as "Unknown".

The program waits for a user to select an IP from the list, to enter a user name and password and ultimately press Connect button, which starts the procedure to connect to the device.
Connection is done by SSH.NET library. In order to connect to selected device, the library requires a host name of the device, and a username (password is optional).
If there were any errors in attempts of connecting, a popup error message will display.

When the connection process is done and successful, the application launches a new window used to control the AlphaBot2. Commands are created by this window and sent to the robot via SSH.
Given commands are visible on the read-only in-app console below.
The app sends inital commands that start the IP camera process on the robot and initializes the AlphaBot2 controls python script.
The videostream is displayed thanks to AForge libraries.

## Installation
For this application to work on the given AlphaBot2, there are a few things that have to be modified to the robot.
1. Make AlphaBot2 connect to your network.
2. Install required libraries on AlphaBot2:
```Linux Kernel Module
sudo apt-get update
sudo apt-get install ttf-wqy-zenhei
sudo apt-get install python-pip
sudo pip install RPi.GPIO
sudo pip install spidev
sudo apt-get install python-smbus
sudo apt-get install python-serial
sudo apt-get install subversion libjpeg8-dev
sudo pip install rpi_ws281x 
```
3. Download and install AlphaBot2 demo program:
```Linux Kernel Module
cd
wget https://www.waveshare.com/w/upload/7/74/AlphaBot2.tar.gz
tar zxvf AlphaBot2.tar.gz
```
