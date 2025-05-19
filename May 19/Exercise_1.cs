using System;

abstract class SmartDevice
{
    public abstract void TurnOn();
    public void ShowStatus()
    {
        Console.WriteLine("Device status:Active");  
    }
}

interface IRemoteControl
{ 
    public void IncreaseVolume();
    public void DecreaseVolume();
}

class SmartLight : SmartDevice, IRemoteControl
{
    public override void TurnOn()
    {
        Console.WriteLine("Smart Light Turned ON");
    }

    public void IncreaseVolume()
    { 
        Console.WriteLine("Lights do not support volume control");
    }
    public void DecreaseVolume()
    {
        Console.WriteLine("Lights do not support volume control");
    }
}

class SmartSpeaker : SmartDevice, IRemoteControl
{
    public override void TurnOn()
    {
        Console.WriteLine("Smart Speaker Turned ON");
    }

    public void IncreaseVolume()
    {
        Console.WriteLine("Volume Increased");
    }
    public void DecreaseVolume()
    {
        Console.WriteLine("Volume Decreased");
    }
}

class program
{
    static void Main()
    {
        SmartDevice lightdevice = new SmartLight();

        IRemoteControl lightcontrol = (IRemoteControl) lightdevice;
        Console.WriteLine("Light device controls");
        Console.WriteLine("----------------------");
        lightdevice.ShowStatus();
        lightdevice.TurnOn();
        lightcontrol.IncreaseVolume();
        lightcontrol.DecreaseVolume();
        
        SmartDevice sounddevice = new SmartSpeaker();

        IRemoteControl soundcontrol = (IRemoteControl) sounddevice;
        Console.WriteLine("Sound device controls");
        Console.WriteLine("----------------------");
        sounddevice.ShowStatus();
        sounddevice.TurnOn();
        soundcontrol.IncreaseVolume();
        soundcontrol.DecreaseVolume();
        
    }
}