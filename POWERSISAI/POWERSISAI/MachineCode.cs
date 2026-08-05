
namespace POWERSISAI
{
	public class MachineCode
	{
		private static MachineCode machineCode;

		public static string GetMachineCodeString()
		{
			string empty = string.Empty;
			if (machineCode == null)
			{
				machineCode = new MachineCode();
			}
			return "PC." + machineCode.GetCpuInfo() + "." + machineCode.GetHDid() + "." + machineCode.GetMoAddress();
		}

		public string GetCpuInfo()
		{
			string text = "";
			try
			{
				ManagementClass managementClass = new ManagementClass("Win32_Processor");
                ManagementObjectCollection instances = managementClass.GetInstances();
				foreach (ManagementObject item in instances)
				{
					text = item.Properties["ProcessorId"].Value.ToString();
					item.Dispose();
				}
			}
			catch (Exception)
			{
				throw;
			}
			return text.ToString();
		}

		public string GetHDid()
		{
			string text = "";
			try
			{
				using ManagementClass managementClass = new ManagementClass("Win32_DiskDrive");
				ManagementObjectCollection instances = managementClass.GetInstances();
				foreach (ManagementObject item in instances)
				{
					text = (string)item.Properties["Model"].Value;
					item.Dispose();
				}
			}
			catch (Exception)
			{
				throw;
			}
			return text.ToString();
		}

		public string GetMoAddress()
		{
			string text = "";
			try
			{
				using ManagementClass managementClass = new ManagementClass("Win32_NetworkAdapterConfiguration");
				ManagementObjectCollection instances = managementClass.GetInstances();
				foreach (ManagementObject item in instances)
				{
					if ((bool)item["IPEnabled"])
					{
						text = item["MacAddress"].ToString();
					}
					item.Dispose();
				}
			}
			catch (Exception)
			{
				throw;
			}
			return text.ToString();
		}
	}
}
