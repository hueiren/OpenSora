/* Generated by MyraPad at 01.10.2019 3:21:27 */
using Myra.Graphics2D.UI;

#if !XENKO
using Microsoft.Xna.Framework;
#else
using Xenko.Core.Mathematics;
#endif

namespace OpenSora.Viewer.UI
{
	partial class MainPanel: VerticalBox
	{
		private void BuildUI()
		{
			_textPath = new TextField();
			_textPath.Text = "";
			_textPath.Readonly = true;
			_textPath.Id = "_textPath";
			_textPath.Width = 300;

			_buttonChange = new TextButton();
			_buttonChange.Text = "Change...";
			_buttonChange.Id = "_buttonChange";

			_buttonAbout = new TextButton();
			_buttonAbout.Text = "About";
			_buttonAbout.Id = "_buttonAbout";
			_buttonAbout.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Right;

			var horizontalBox1 = new HorizontalBox();
			horizontalBox1.Spacing = 8;
			horizontalBox1.Proportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Auto,
			});
			horizontalBox1.Proportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Auto,
			});
			horizontalBox1.Proportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Fill,
			});
			horizontalBox1.Widgets.Add(_textPath);
			horizontalBox1.Widgets.Add(_buttonChange);
			horizontalBox1.Widgets.Add(_buttonAbout);

			var listItem1 = new ListItem();
			listItem1.Id = null;
			listItem1.Text = "Textures";

			var listItem2 = new ListItem();
			listItem2.Id = null;
			listItem2.Text = "Models";

			_comboResourceType = new ComboBox();
			_comboResourceType.Id = "_comboResourceType";
			_comboResourceType.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			_comboResourceType.Items.Add(listItem1);
			_comboResourceType.Items.Add(listItem2);

			var listItem3 = new ListItem();
			listItem3.Id = null;
			listItem3.Text = "TEXTURE1._DS";

			var listItem4 = new ListItem();
			listItem4.Id = null;
			listItem4.Text = "TEXTURE2._DS";

			_listFiles = new ListBox();
			_listFiles.Id = "_listFiles";
			_listFiles.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Stretch;
			_listFiles.Items.Add(listItem3);
			_listFiles.Items.Add(listItem4);

			var verticalBox1 = new VerticalBox();
			verticalBox1.Spacing = 8;
			verticalBox1.Proportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Auto,
			});
			verticalBox1.Proportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Fill,
			});
			verticalBox1.Widgets.Add(_comboResourceType);
			verticalBox1.Widgets.Add(_listFiles);

			_panelViewer = new Panel();
			_panelViewer.Id = "_panelViewer";

			_textStatus = new TextBlock();
			_textStatus.Text = "Processing mesh 23/40...";
			_textStatus.Id = "_textStatus";
			_textStatus.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Bottom;

			var panel1 = new Panel();
			panel1.Widgets.Add(_panelViewer);
			panel1.Widgets.Add(_textStatus);

			var horizontalBox2 = new HorizontalBox();
			horizontalBox2.Spacing = 8;
			horizontalBox2.Proportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Auto,
			});
			horizontalBox2.Proportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Fill,
			});
			horizontalBox2.Widgets.Add(verticalBox1);
			horizontalBox2.Widgets.Add(panel1);

			
			Spacing = 8;
			Proportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Auto,
			});
			Proportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Fill,
			});
			Widgets.Add(horizontalBox1);
			Widgets.Add(horizontalBox2);
		}

		
		public TextField _textPath;
		public TextButton _buttonChange;
		public TextButton _buttonAbout;
		public ComboBox _comboResourceType;
		public ListBox _listFiles;
		public Panel _panelViewer;
		public TextBlock _textStatus;
	}
}