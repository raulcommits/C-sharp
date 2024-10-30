/*
 * Created by SharpDevelop.
 * User: aluno
 * Date: 29/10/2024
 * Time: 21:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Atividade_22__Uso_de_RichTextBox_
{

	public partial class MainForm : Form
	{
		public MainForm()
		{

			InitializeComponent();
			

		}
		void Button1Click(object sender, EventArgs e)
		{
			
			richTextBox1.Text += textBox1.Text + " | " + textBox2.Text + " | " + textBox3.Text;
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
		}
		void Button2Click(object sender, EventArgs e)
		{
			richTextBox1.SaveFile("dados.txt", RichTextBoxStreamType.PlainText);
		}
		void Button3Click(object sender, EventArgs e)
		{
			richTextBox1.LoadFile("dados.txt", RichTextBoxStreamType.PlainText);
		}
		void Button4Click(object sender, EventArgs e)
		{
			richTextBox1.Clear();
		}
	}
}
