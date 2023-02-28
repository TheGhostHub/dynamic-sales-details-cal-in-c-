using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_ASSIGNMENT
{
    public partial class frmSalesReport : Form
    {
        public frmSalesReport()
        {
            InitializeComponent();
        }
        TextBox[] txtbox;
        Label[] lb1;
        Label[] lb2;
        ComboBox[] combo;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtbox = new TextBox[Convert.ToInt32(comboBoxAjentCount.Text)];
            lb1 = new Label[Convert.ToInt32(comboBoxAjentCount.Text)];
            lb2 = new Label[Convert.ToInt32(comboBoxAjentCount.Text)];
            combo = new ComboBox[Convert.ToInt32(comboBoxAjentCount.Text)];
     
            for (int i = 0; i < txtbox.Count(); i++)
            {

                txtbox[i] = new TextBox();
                lb1[i] = new Label();
                lb2[i] = new Label();
                combo[i] = new ComboBox();
            }
            int x = 0;
            int tbxname = 1;
            int comboName = 1;
            foreach  (TextBox txt in txtbox)
            {
                txt.Name = "tbx"+ tbxname.ToString();
                Controls.Add(txt);
                txt.Location = new Point(150, 100 + (x * 100));
                x++;
                tbxname++;
            }
            int y = 0;
            int labelNmae = 1;
            foreach (Label item in lb1)
            {
                item.Text="Agent name #"+ labelNmae.ToString();
                Controls.Add(item);
                item.Location = new Point(50, 100 + (y * 100));
                y++;
                labelNmae++;
            }

            int s = 0;
            foreach (Label item in lb2)
            {
                item.Text = "Number of sales";
                Controls.Add(item);
                item.Location = new Point(280, 100 + (s * 100));
                s++;
            }
            int[] list = { 1, 2, 3, 4, 5 };
            int z = 0;

           
            foreach (ComboBox item in combo)
            {
                item.Name = "Combo" + comboName.ToString();
                Controls.Add(item);
                for (int i = 1; i <=5; i++)
                {
                    item.Items.Add(i);
                }
                item.Location = new Point(400, 100 + (z * 100));
                item.SelectedIndexChanged += new System.EventHandler(combo1_SelectedValueChanged);
                z++;
                comboName++;
            }
            

        }
        TextBox[] subText1;
        TextBox[] subText2;
        TextBox[] subText3;
        TextBox[] subText4;
        TextBox[] subText5;
        Label subLabel;
        private void combo1_SelectedValueChanged(object sender, EventArgs e)
        {

            foreach (ComboBox item in combo)
            {
                //MessageBox.Show(item.Name);
                if (item.Name == "Combo1")
                {
                    int col = 1;
                    int x = 0;
                 
                    subText1 = new TextBox[item.SelectedIndex + 1];
                    for (int i = 0; i < subText1.Count(); i++)
                    {
                        //subText[i] = new TextBox();
                        subText1[i] = new TextBox();
                        subLabel = new Label();
                        Controls.Add(subLabel);
                        subLabel.Text = "Sales:";
                        subLabel.Location = new Point(50, 150);

                    }

                    foreach (TextBox items in subText1)
                    {
                        item.Name = "Row1" + "col"+ col.ToString();
                        Controls.Add(items);
                        items.Location = new Point(150 + (x * 110), 150);
                        x++;
                        col++;
                    }
                }
                if(item.Name == "Combo2")
                {
                    int col = 1;
                    int x = 0;
                    
                    subText2 = new TextBox[item.SelectedIndex + 1];
                    for (int i = 0; i < subText2.Count(); i++)
                    {
                        subText2[i] = new TextBox();
                        subLabel = new Label();
                        Controls.Add(subLabel);
                        subLabel.Text = "Sales:";
                        subLabel.Location = new Point(50, 250);
                    }
                    foreach (TextBox items in subText2)
                    {
                        item.Name = "Row2" + "col" + col.ToString();
                        Controls.Add(items);
                        items.Location = new Point(150 + (x * 110), 250);
                        x++;
                        col++;
                    }

                }
                if (item.Name == "Combo3")
                {
                    int col = 1;
                    int x = 0;
                    
                    subText3 = new TextBox[item.SelectedIndex + 1];
                    for (int i = 0; i < subText3.Count(); i++)
                    {
                        subText3[i] = new TextBox();
                        subLabel = new Label();
                        Controls.Add(subLabel);
                        subLabel.Text = "Sales:";
                        subLabel.Location = new Point(50, 350);
                    }
                    foreach (TextBox items in subText3)
                    {
                        item.Name = "Row3" + "col" + col.ToString();
                        Controls.Add(items);
                        items.Location = new Point(150 + (x * 110), 350);
                        x++;
                        col++;
                    }

                }
                if (item.Name == "Combo4")
                {
                    int col = 1;
                    int x = 0;
        
                    subText4 = new TextBox[item.SelectedIndex + 1];
                    for (int i = 0; i < subText4.Count(); i++)
                    {
                        subText4[i] = new TextBox();
                        subLabel = new Label();
                        Controls.Add(subLabel);
                        subLabel.Text = "Sales:";
                        subLabel.Location = new Point(50, 450);
                    }
                    foreach (TextBox items in subText4)
                    {
                        item.Name = "Row4" + "col" + col.ToString();
                        Controls.Add(items);
                        items.Location = new Point(150 + (x * 110), 450);
                        x++;
                        col++;
                    }

                }
                if (item.Name == "Combo5")
                {
                    int col = 1;
                    int x = 0;
                  
                    subText5 = new TextBox[item.SelectedIndex + 1];
                    for (int i = 0; i < subText5.Count(); i++)
                    {
                        subText5[i] = new TextBox();
                        subLabel = new Label();
                        Controls.Add(subLabel);
                        subLabel.Text = "Sales:";
                        subLabel.Location = new Point(50, 550);
                    }
                    foreach (TextBox items in subText5)
                    {
                        item.Name = "Row5" + "col" + col.ToString();
                        Controls.Add(items);
                        items.Location = new Point(150 + (x * 110), 550);
                        x++;
                        col++;
                    }

                }

            }
            //MessageBox.Show(subText[0].Text);
            
            /*
                TextBox tbx = new TextBox();
                Controls.Add(tbx);
                tbx.Location = new Point(300, 300);
                tbx.Text=combo1.*/
        }

        private void resultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            barchart.Hide();
            tableLayoutPanel.Hide();
            panel1.Show();
            int totalSales = 0;
            int [] array=new int[5];
            int[] rowMax = new int[5];
            string[] arrName = new string[5];
            string agentName="";

            for (int i = 1; i <= txtbox.Count(); i++)
            {
                if (i == 1)
                {
                    int total1 = 0;
                    int row1Max=0;
                    for (int j = 0; j < subText1.Count(); j++)
                    {

                        total1 = total1 + Convert.ToInt32(subText1[j].Text);
                        if (row1Max< Convert.ToInt32(subText1[j].Text))
                        {
                            row1Max = Convert.ToInt32(subText1[j].Text);
                        }
                        
                    }
                    rowMax[0] = row1Max;
                    button5.Text = "Agent #1";
                    button6.Text = txtbox[0].Text;
                    arrName[0]= txtbox[0].Text;
                    totalSales = totalSales + total1;
                    array[0] = total1;
                }

                if (i == 2)
                {
                    int total2 = 0;
                    int row2Max = 0;
                    for (int j = 0; j < subText2.Count(); j++)
                    {

                        total2 = total2 + Convert.ToInt32(subText2[j].Text);
                        if (row2Max < Convert.ToInt32(subText2[j].Text))
                        {
                            row2Max = Convert.ToInt32(subText2[j].Text);
                        }
                    }
                    rowMax[1] = row2Max;
                    button9.Text = "Agent #2";
                    button10.Text = txtbox[1].Text;
                    arrName[1] = txtbox[1].Text;
                    totalSales = totalSales + total2;
                    array[1] = total2;
                }

                if (i == 3)
                {
                    int total3 = 0;
                    int row3Max = 0;
                    for (int j = 0; j < subText3.Count(); j++)
                    {

                        total3 = total3 + Convert.ToInt32(subText3[j].Text);
                        if (row3Max < Convert.ToInt32(subText3[j].Text))
                        {
                            row3Max = Convert.ToInt32(subText3[j].Text);
                        }
                    }
                    rowMax[2] = row3Max;
                    button13.Text = "Agent #3";
                    button14.Text = txtbox[2].Text;
                    arrName[2] = txtbox[2].Text;
                    totalSales = totalSales + total3;
                    array[2] = total3;
                }
                if (i == 4)
                {
                    int total3 = 0;
                    int row4Max = 0;
                    for (int j = 0; j < subText4.Count(); j++)
                    {

                        total3 = total3 + Convert.ToInt32(subText4[j].Text);
                        if (row4Max < Convert.ToInt32(subText4[j].Text))
                        {
                            row4Max = Convert.ToInt32(subText4[j].Text);
                        }
                    }
                    rowMax[3] = row4Max;
                    button17.Text = "Agent #4";
                    button18.Text = txtbox[3].Text;
                    arrName[3] = txtbox[3].Text;
                    totalSales = totalSales + total3;
                    array[3] = total3;
                }
                if (i == 5)
                {
                    int total3 = 0;
                    int row5Max = 0;
                    for (int j = 0; j < subText5.Count(); j++)
                    {

                        total3 = total3 + Convert.ToInt32(subText5[j].Text);
                        if (row5Max < Convert.ToInt32(subText5[j].Text))
                        {
                            row5Max = Convert.ToInt32(subText5[j].Text);
                        }
                    }
                    rowMax[4] = row5Max;
                    button21.Text = "Agent #5";
                    button22.Text = txtbox[4].Text;
                    arrName[4] = txtbox[4].Text;
                    totalSales = totalSales + total3;
                    array[4] = total3;
                }
            }


            label2.Text = "Total Sales of Agents: $" + totalSales.ToString();
            int max = array[0];
            
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                    
                    agentName = arrName[i];
                   
                }

            }
            
            label3.Text = "Higest Total sales of $" + max.ToString()+" Made by "+agentName;

            int singleMax = rowMax[0];
            string aName = "";
            for (int i = 0; i < rowMax.Length; i++)
            {
                if (singleMax < rowMax[i])
                {
                    singleMax = rowMax[i];
                    aName = arrName[i];
                }

            }
            label4.Text = aName + " made the single sale of $" + singleMax;
        }



        private void chartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            barchart.Show();
            tableLayoutPanel.Hide();
            panel1.Hide();


            for (int i = 1; i <= txtbox.Count(); i++)
            {
                if (i == 1)
                {
                    int total1 = 0;
                    for (int j = 0; j < subText1.Count(); j++)
                    {

                        total1 = total1 + Convert.ToInt32(subText1[j].Text);
                    }
                    barchart.Series["Sales Chart"].Points.AddXY(txtbox[0].Text, total1);
                    barchart.Series["Sales Chart"].Points[0].Label = "$"+total1.ToString();
                    
                }

                if (i == 2)
                {
                    int total2 = 0;
                    for (int j = 0; j < subText2.Count(); j++)
                    {

                        total2 = total2 + Convert.ToInt32(subText2[j].Text);
                    }
                    barchart.Series["Sales Chart"].Points.AddXY(txtbox[1].Text, total2);
                    barchart.Series["Sales Chart"].Points[1].Label = "$" + total2.ToString();
                    
                }

                if (i== 3)
                {
                    int total3 = 0;
                    for (int j = 0; j < subText3.Count(); j++)
                    {

                        total3 = total3 + Convert.ToInt32(subText3[j].Text);
                    }
                    barchart.Series["Sales Chart"].Points.AddXY(txtbox[2].Text, total3);
                    barchart.Series["Sales Chart"].Points[2].Label = "$" + total3.ToString();
                }
                if (i == 4)
                {
                    int total3 = 0;
                    for (int j = 0; j < subText4.Count(); j++)
                    {

                        total3 = total3 + Convert.ToInt32(subText4[j].Text);
                    }
                    barchart.Series["Sales Chart"].Points.AddXY(txtbox[3].Text, total3);
                    barchart.Series["Sales Chart"].Points[3].Label = "$" + total3.ToString();
                }
                if (i == 5)
                {
                    int total3 = 0;
                    for (int j = 0; j < subText5.Count(); j++)
                    {

                        total3 = total3 + Convert.ToInt32(subText5[j].Text);
                    }
                    barchart.Series["Sales Chart"].Points.AddXY(txtbox[4].Text, total3);
                    barchart.Series["Sales Chart"].Points[4].Label = "$" + total3.ToString();
                }
            }

        }

        private void frmSalesReport_Load(object sender, EventArgs e)
        {
            barchart.Hide();
            tableLayoutPanel.Hide();
            panel1.Hide();
        }


        private void tableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableLayoutPanel.Show();
            barchart.Hide();
            panel1.Hide();
            for (int i = 1; i <= txtbox.Count(); i++)
            {
                if (i == 1)
                {
                    int total1 = 0;
                    for (int j = 0; j < subText1.Count(); j++)
                    {

                        total1 = total1 + Convert.ToInt32(subText1[j].Text);
                    }
                    button5.Text = "Agent #1";
                    button6.Text = txtbox[0].Text;
                    button7.Text = "$" + total1.ToString();
                    button8.Text = "$" + (total1 * 5 / 100).ToString();
                }

                if (i == 2)
                {
                    int total2 = 0;
                    for (int j = 0; j < subText2.Count(); j++)
                    {

                        total2 = total2 + Convert.ToInt32(subText2[j].Text);
                    }
                    button9.Text = "Agent #1";
                    button10.Text = txtbox[1].Text;
                    button11.Text = "$" + total2.ToString();
                    button12.Text = "$" + (total2 * 5 / 100).ToString();
                }

                if (i == 3)
                {
                    int total3 = 0;
                    for (int j = 0; j < subText3.Count(); j++)
                    {

                        total3 = total3 + Convert.ToInt32(subText3[j].Text);
                    }
                    button13.Text = "Agent #1";
                    button14.Text = txtbox[2].Text;
                    button15.Text = "$" + total3.ToString();
                    button16.Text = "$" + (total3 * 5 / 100).ToString();
                }
                if (i == 4)
                {
                    int total3 = 0;
                    for (int j = 0; j < subText4.Count(); j++)
                    {

                        total3 = total3 + Convert.ToInt32(subText4[j].Text);
                    }
                    button17.Text = "Agent #1";
                    button18.Text = txtbox[3].Text;
                    button19.Text = "$" + total3.ToString();
                    button20.Text = "$" + (total3 * 5 / 100).ToString();
                }
                if (i == 5)
                {
                    int total3 = 0;
                    for (int j = 0; j < subText5.Count(); j++)
                    {

                        total3 = total3 + Convert.ToInt32(subText5[j].Text);
                    }
                    button21.Text = "Agent #1";
                    button22.Text = txtbox[4].Text;
                    button23.Text = "$" + total3.ToString();
                    button24.Text = "$" + (total3 * 5 / 100).ToString();
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

