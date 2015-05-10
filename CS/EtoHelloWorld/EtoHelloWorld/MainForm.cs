// /*
//  *	MICHAEL KOEPPL 3AHIF
//  * 	2014/2015
//  */
using System;
using Eto.Forms;
using Eto.Drawing;

namespace EtoHelloWorld
{
	/// <summary>
	/// Your application's main form
	/// </summary>
	public class MainForm : Form
	{
		public MainForm ()
		{
			Title = "Hello World!";
			ClientSize = new Size (400, 350);

			var row = new TableRow (null, new Label { Text = "Hello World!" }, null);

			// scrollable region as the main content
			Content = new Scrollable {
				// table with three rows
				Content = new TableLayout (
					null,
					// row with three columns
					row,
					null
				)
			};

			Content.Visible = false;

			// create a few commands that can be used for the menu and toolbar
			var clickMe = new Command {
				MenuText = "Click Me!",
				ToolBarText = "Click Me!"
			};
			clickMe.Executed += (sender, e) => Content.Visible = true;

			var quitCommand = new Command {
				MenuText = "Quit",
				Shortcut = Application.Instance.CommonModifier | Keys.Q
			};
			quitCommand.Executed += (sender, e) => Application.Instance.Quit ();

			var aboutCommand = new Command { MenuText = "About..." };
			aboutCommand.Executed += (sender, e) => MessageBox.Show (this, "About my app...");

			// create menu
			Menu = new MenuBar {
				Items = {
					// File submenu
					new ButtonMenuItem { Text = "&File", Items = { clickMe } },
					// new ButtonMenuItem { Text = "&Edit", Items = { /* commands/items */ } },
					// new ButtonMenuItem { Text = "&View", Items = { /* commands/items */ } },
				},
				ApplicationItems = {
					// application (OS X) or file menu (others)
					new ButtonMenuItem { Text = "&Preferences..." },
				},
				QuitItem = quitCommand,
				AboutItem = aboutCommand
			};

			// create toolbar			
			ToolBar = new ToolBar { Items = { clickMe } };
		}
	}
}
