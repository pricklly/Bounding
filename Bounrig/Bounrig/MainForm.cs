
/*
 * Создано в SharpDevelop.
 * Пользователь: pricklly
 * Дата: 18.04.2024
 * Время: 12:00
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Bounrig
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public int[,] bt=new int[10,10]{{123,345,234,234,24,234,46,234,457,25},{345,35,345,54,57,24,35,345,24,24},
			{234,57,456,678,456,68,456,25,68,35},{678,46,68,643,68,46,46,35,46,365},
			{345,57,453,456,57,35663,75,57,63,364},{24,46,24,4636,36,2452,36,36,25,46},
			{463,475,53,36,36,57,36,46,36,46},{345,234,46,254,36,25,234,4365,35,24},
			{453,35,475,435,345,24,57,46,35,25},{242,345,24,35,24,46,24,6,24,25}};
		public int i,j,x;
		public long c;
		public Random rnd;
		public bool s=true;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
			rtb.AppendText(tb.Text+'\n'.ToString());
		}
		void Button2Click(object sender, EventArgs e)
		{
			rnd=new Random();
			for (i=0;i<10;i++)
			{
				for (j=0;j<10;j++)
				{
					rtb.AppendText(bt[i,j].ToString()+"  ");
					c=c+bt[i,j];
				}
				rtb.AppendText('\n'.ToString());
				x=c.ToString().Length;
				c=c-(c%(x-3));
				rtb.AppendText("1/"+c.ToString());
			}
			
			while(s==true)
			{
				if (pb.Value<100)
				{
				pb.Value= pb.Value+rnd.Next(8);
				} else 
				{s=false;}
			}
		}
	}
}
