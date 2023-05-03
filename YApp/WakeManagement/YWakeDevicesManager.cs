using System.Data;
using System.Management;
using System.Xml.Linq;
using YY.Logging;

namespace YY.WakeManagement;

internal static class YWakeDevicesManager {
    internal static XDocument GetDevicesXDocument() {
        try {
            XDocument devicesXDocument = new(new XElement("Devices"));

            ManagementObjectCollection wakeDevicesCollection = new ManagementObjectSearcher("root\\wmi", "SELECT * FROM MSPower_DeviceWakeEnable").Get();
            ManagementObjectCollection devicesPropertiesCollection = new ManagementObjectSearcher("root\\wmi", "SELECT * FROM MSWmi_ProviderInfo").Get();

            foreach(ManagementObject wakeDevice in wakeDevicesCollection.Cast<ManagementObject>()) {
                XElement deviceElement = new("NodeTitle");

                foreach(ManagementObject deviceProperty in devicesPropertiesCollection.Cast<ManagementObject>()) {
                    if(deviceProperty.Properties["InstanceName"].Value.ToString() == wakeDevice.Properties["InstanceName"].Value.ToString()) {
                        deviceElement.SetValue(deviceProperty.Properties["Description"].Value.ToString() ?? "Unknown");
                        foreach(PropertyData property in deviceProperty.Properties) {
                            deviceElement.Add(new XElement(property.Name, property.Value));
                        }
                    }
                }
                deviceElement.Add(new XElement("Enable", wakeDevice.Properties["Enable"].Value));
                devicesXDocument.Root?.Add(deviceElement);
            }
            YLog.Info($"Create DevicesXDocument - Devices count: {wakeDevicesCollection.Count}");
            return devicesXDocument;
        } catch(Exception ex) {
            YLog.Error(ex);
            return new XDocument();
        }
    }

    internal static bool SetDeviceEnable(string deviceInstanceName, bool isEnable) {
        try {
            ManagementObjectCollection wakeDevicesCollection = new ManagementObjectSearcher("root\\wmi", "SELECT * FROM MSPower_DeviceWakeEnable").Get();
            foreach(ManagementObject wakeDevice in wakeDevicesCollection.Cast<ManagementObject>()) {
                if(wakeDevice.Properties["InstanceName"].Value.ToString() == deviceInstanceName) {
                    wakeDevice["Enable"] = isEnable;
                    _ = wakeDevice.Put();
                }
            }
            YLog.Info($"Set device instance - Name: {deviceInstanceName}, Enable: {isEnable}");
            return true;
        } catch(Exception ex) {
            YLog.Error(ex);
            return false;
        }        
    }
}