using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;
using System.Windows.Forms;

namespace MobileRobotController
{
    class AlphaBot2Controller
    {
        public SSHConsole console { get; private set; }

        private LinkedList<Keys> cameraXPriority;
        private LinkedList<Keys> cameraYPriority;
        private LinkedList<Keys> movementPriority;

        private StringBuilder cameraXCommandBuilder;
        private StringBuilder cameraYCommandBuilder;

        private System.Timers.Timer cameraControlTimer;
        private const int limitX1 = 700;
        private const int limitX2 = 2400;

        private const int limitY1 = 600;
        private const int limitY2 = 1400;

        private int currentX = 1550;
        private int currentY = 1000;

        private bool cameraChangeX = false;
        private bool cameraChangeY = false;

        private enum ControlType
        {
            None = 0,
            CameraXControl = 1,
            CameraYControl = 2,
            MovementControl = 3
        }

        public AlphaBot2Controller(SSHConsole console)
        {

            cameraXPriority = new LinkedList<Keys>();
            cameraYPriority = new LinkedList<Keys>();
            movementPriority = new LinkedList<Keys>();
            cameraControlTimer = new System.Timers.Timer();
            cameraXCommandBuilder = new StringBuilder();
            cameraYCommandBuilder = new StringBuilder();

            this.console = console;

            console.WriteLine("cd AlphaBot2/python/");
            console.WriteLine("python -i");
            console.WriteLine("import AlphaBot2");
            console.WriteLine("import PCA9685");
            console.WriteLine("move = AlphaBot2.AlphaBot2()");
            console.WriteLine("camera = PCA9685.PCA9685(0x40, debug = False)");
            console.WriteLine("camera.setPWMFreq(50)");

            cameraControlTimer.Interval = 20;
            cameraControlTimer.Elapsed += onTimerElapsed;
            cameraControlTimer.Start();
        }

        public void Destroy()
        {
            cameraControlTimer.Stop();
            cameraControlTimer.Elapsed -= onTimerElapsed;
            cameraControlTimer.Dispose();
        }

        private void ProcessMovementKey()
        {

            LinkedListNode<Keys> currentKey = movementPriority.First;

            if (currentKey == null)
            {
                console.WriteLine("move.stop()");
                return;
            }

            Keys currentCommand = currentKey.Value;

            switch (currentCommand)
            {
                case Keys.Up: console.WriteLine("move.forward()"); break;
                case Keys.Left: console.WriteLine("move.left()"); break;
                case Keys.Down: console.WriteLine("move.backward()"); break;
                case Keys.Right: console.WriteLine("move.right()"); break;
                default: console.WriteLine("move.stop()"); break;
            }

        }

        private void onTimerElapsed(Object source, ElapsedEventArgs e)
        {
            try
            {
                ProcessCameraKey();
            }
            catch (Exception) { }
        }

        private void ProcessCameraKey()
        {

            LinkedListNode<Keys> currentKey = cameraYPriority.First;

            if (currentKey != null)
            {
                Keys currentCommand = currentKey.Value;

                switch (currentCommand)
                {
                    case Keys.W:

                        cameraChangeY = true;
                        currentY -= 10;
                        break;

                    case Keys.S:

                        cameraChangeY = true;
                        currentY += 10;
                        break;
                }
            }

            currentKey = cameraXPriority.First;

            if(currentKey != null)
            {
                Keys currentCommand = currentKey.Value;

                switch (currentCommand)
                {
                    case Keys.A:
                        cameraChangeX = true;
                        currentX += 10;
                        break;

                    case Keys.D:
                        cameraChangeX = true;
                        currentX -= 10;
                        break;

                }
            }

            if (cameraChangeX)
            {
                cameraChangeX = false;

                if (currentX > limitX2) currentX = limitX2;
                if (currentX < limitX1) currentX = limitX1;

                cameraXCommandBuilder.AppendFormat("camera.setServoPulse(0, {0})", currentX.ToString());
                console.WriteLine(cameraXCommandBuilder.ToString());
                cameraXCommandBuilder.Clear();
            }

            if (cameraChangeY) 
            { 
                cameraChangeY = false;

                if (currentY > limitY2) currentY = limitY2;
                if (currentY < limitY1) currentY = limitY1;                

                cameraYCommandBuilder.AppendFormat("camera.setServoPulse(1, {0})", currentY.ToString());
                console.WriteLine(cameraYCommandBuilder.ToString());
                cameraYCommandBuilder.Clear();
            }

        }

        private ControlType DetermineControlType(Keys whichKey)
        {
            switch (whichKey)
            {
                case Keys.W:
                case Keys.S:
                    return ControlType.CameraYControl;

                case Keys.A:
                case Keys.D:
                    return ControlType.CameraXControl;

                case Keys.Up:
                case Keys.Left:
                case Keys.Down:
                case Keys.Right:
                    return ControlType.MovementControl;
            }

            return ControlType.None;
        }

        public void RegisterPressedKey(Keys whichKey)
        {
            ControlType controlType = DetermineControlType(whichKey);

            if(controlType == ControlType.CameraXControl)
            {
                if (cameraXPriority.Contains(whichKey)) return;

                cameraXPriority.AddFirst(whichKey);
            }
            else if (controlType == ControlType.CameraYControl)
            {
                if (cameraYPriority.Contains(whichKey)) return;

                cameraYPriority.AddFirst(whichKey);
            }
            else if (controlType == ControlType.MovementControl)
            {
                if (movementPriority.Contains(whichKey)) return;

                movementPriority.AddFirst(whichKey);
                ProcessMovementKey();
            }

        }

        public void UnregisterPressedKey(Keys whichKey)
        {
            ControlType controlType = DetermineControlType(whichKey);

            if (controlType == ControlType.CameraXControl)
            {
                if (!cameraXPriority.Contains(whichKey)) return;

                cameraXPriority.Remove(whichKey);

            }
            else if (controlType == ControlType.CameraYControl)
            {
                if (!cameraYPriority.Contains(whichKey)) return;

                cameraYPriority.Remove(whichKey);

            }
            else if (controlType == ControlType.MovementControl)
            {
                if (!movementPriority.Contains(whichKey)) return;

                movementPriority.Remove(whichKey);
                ProcessMovementKey();
            }
            
        }
    }
}
