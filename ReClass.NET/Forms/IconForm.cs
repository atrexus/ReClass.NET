using System.Windows.Forms;

namespace ReClassNET.Forms
{
	public class IconForm : Form
	{
		public IconForm()
		{
			if (Program.Settings.HideWindowIcons)
			{
				ShowIcon = false;
				Icon = null;
			}
			else
			{
				ShowIcon = true;
				Icon = Properties.Resources.ReClassNet;
			}
		}
	}
}
