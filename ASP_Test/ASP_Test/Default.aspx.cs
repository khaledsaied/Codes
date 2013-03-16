
using System;
using System.Web;
using System.Web.UI;

namespace ASP_Test
{
	public partial class Default : System.Web.UI.Page
	{
		
		public virtual void button1Clicked (object sender, EventArgs args)
		{
			button1.Text = "You clicked me";
		}

		public virtual void button2Clicked (object sender, EventArgs args)
		{
			button2.Text = "Hello";


		}

		public virtual void tb3_TextChanged (object sender, EventArgs args)
		{
			tb3.Text = tb1.Text; 
		}
	}

}

