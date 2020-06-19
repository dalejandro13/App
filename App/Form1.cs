using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Form1 : Form
    {
        Button btn = new Button();
        Button btn2 = new Button();
        Label lbl = new Label();
        public Form1()
        {
            InitializeComponent();

            btn.Location = new Point(100, 100);
            btn.Size = new Size(100, 50);
            btn.Name = "btnTest";
            btn.Text = "action1";
            btn.Click += new EventHandler(ClickEvent);
            this.Controls.Add(btn);

            btn2.Location = new Point(400, 100);
            btn2.Size = new Size(100, 50);
            btn2.Name = "btnTest2";
            btn2.Text = "action2";
            btn2.Click += new EventHandler(ClickEvent2);
            this.Controls.Add(btn2); 
        
            lbl.Location = new Point(100, 200);
            lbl.Size = new Size(400, 50);
            lbl.Name = "lblText";
            lbl.Text = "result";
            this.Controls.Add(lbl);
        }

        private void ClickEvent2(object sender, EventArgs e)
        {
            lbl.Text = "Flexolumens, la empresa del mañana";
        }

        private void ClickEvent(object sender, EventArgs e)
        {
            lbl.Text = "Hola, Bienvenido a";
            //ubuntu 18.04
        }
    }
}
