using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace code
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if( TextBox1.Text="ryuuichie" And TextBox2.Text = "adminpass") Then
                MsgBox("you are now logged in", MsgBoxStyle.SystemInformation, "login")
            { else 
            if (TextBox1.Text = "" and TextBook2.Text = "" )Then
                MsgBox("No Username and/or Password Found!", MsgBoxStyle.Critical, "Error")
 
                {else
            if (TextBox1.Text = "" )Then 
                MsgBox("No Username Found!", MsgBoxStyle.Critical, "Error")

                    {else
                if (TextBox2.Text = "") Then
                    MsgBox("No Password Found!", MsgBoxStyle.Critical,"Error")

                        {else
                    MsgBox("Invalid Username And/or Password!", MsgBoxStyle.Critical, "Error")
                }
                    }
                }
            }
        }
    }
    }

