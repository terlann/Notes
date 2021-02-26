using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListViewMashinSifarisListi
{
    public partial class btn : Form
    {
        ListViewItem selected;
        public btn()
        {
            InitializeComponent();
        }

        void Clear()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is ComboBox)
                {
                    ((ComboBox)ctrl).SelectedIndex = -1;
                }
                else if (ctrl is Button)
                {
                    Button btn = (Button)ctrl;
                    if (btn.Name == "btnColor")
                    {
                        ((Button)ctrl).BackColor = Color.Gray;
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.UseItemStyleForSubItems = false;

            lvi.Text = cmbMarka.Text;
            lvi.SubItems.Add(cmbModel.Text);
            lvi.SubItems.Add(cmbYanacaqNovu.Text);
            if (!string.IsNullOrWhiteSpace(cmbMarka.Text))
            {
                lvi.SubItems.Add("");
                lvi.SubItems[3].BackColor = btnColor.BackColor;
                lvi.SubItems.Add(dtYear.Value.Year.ToString());
                listViewSaved.Items.Add(lvi);
            }
           
            Clear();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            DialogResult dialoqResult = colorDialog1.ShowDialog();
            if (dialoqResult == DialogResult.OK)
                btnColor.BackColor = colorDialog1.Color;
        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbMarka.Text)
            {
                case "Mercedes":
                    cmbModel.Items.Clear();
                    cmbModel.Items.Add("E320");
                    cmbModel.Items.Add("E350");
                    break;
                case "BMW":
                    cmbModel.Items.Clear();
                    cmbModel.Items.Add("Troyka");
                    cmbModel.Items.Add("Pityorka");
                    break;
                case "KIA":
                    cmbModel.Items.Clear();
                    cmbModel.Items.Add("Opitam");
                    cmbModel.Items.Add("Rio");
                    break;
                default:
                    cmbModel.Items.Clear();
                    break;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            listViewSaved.Items.Remove(listViewSaved.SelectedItems[0]);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ArrayList arr = new ArrayList();
            foreach (string item in listBox1.Items)
            {
                arr.Add(item);
            }
            foreach (string element in arr)
            {
                listBox2.Items.Add(element);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ArrayList arr2 = new ArrayList();
            foreach (string item in listBox2.SelectedItems)
            {
                arr2.Add(item);
            }
            foreach (string item in arr2)
            {
                listBox2.Items.Remove(item);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listViewSaved.SelectedItems.Count > 0)
            {
                 selected = listViewSaved.SelectedItems[0];

                cmbMarka.Text = selected.Text;
                cmbModel.Text = selected.SubItems[1].Text;
                cmbYanacaqNovu.Text = selected.SubItems[2].Text;
                btnColor.BackColor = selected.SubItems[3].BackColor;
                dtYear.Text = string.Format("01.01.{0}", selected.SubItems[4].Text);

               
                
            }
            else
            {
                MessageBox.Show("Zehmet olmasa her hansi bir setiri secin", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
        }

        private void UpdateSave_Click(object sender, EventArgs e)
        {
            //Update Save

            selected.Text = cmbMarka.Text;
            selected.SubItems[1].Text = cmbModel.Text;
            selected.SubItems[2].Text = cmbYanacaqNovu.Text;
            selected.SubItems[3].BackColor = btnColor.BackColor;
            selected.SubItems[4].Text = dtYear.Value.Year.ToString();
        }

        private void listViewSaved_KeyDown(object sender, KeyEventArgs e)
        {
            if (listViewSaved.SelectedItems.Count > 0 && e.KeyCode == Keys.Delete)
            {
                listViewSaved.Items.Remove(listViewSaved.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Zehmet olmasa her hansi bir setiri secin", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewSaved.SelectedItems.Count > 0)
            {
                listViewSaved.Items.Remove(listViewSaved.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Zehmet olmasa her hansi bir setiri secin", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
