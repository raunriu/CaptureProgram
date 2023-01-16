using System.Collections;
using System.Drawing.Text;

namespace ScreenShot
{
    public partial class Form1 : Form
    {
        private int count = 0;
        private int nnnn = 0;
        private bool allSelect = false;
        //List<TableLayoutPanel> aaaa = new List<TableLayoutPanel>();
        ArrayList labelList = new ArrayList();
        ArrayList labels = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void allSaveButton_Click(object sender, EventArgs e)
        {
            /*
            labelList.Add(new Label());
            foreach (Label label in labelList)
            {
                label.AutoSize = true;
                label.Dock = System.Windows.Forms.DockStyle.Top;
                if (label.Name == "")
                {
                    label.Name = "label" + (count + 1);
                    label.Location = new System.Drawing.Point(nnnn, 0);
                    label.Size = new System.Drawing.Size(39, 15);
                    label.Text = "테스트" + (count + 1);
                    nnnn += 20; count++;
                    mainPanel.Controls.Add(label);
                }
            }
            */
            this.captureListBox.Items.AddRange(new object[] {$"테스트{count}"});
            this.captureListBox.Items.Add($"테스트{count}");
            //captureListBox.SetItemChecked(count, true);
            int index = 0;
            if (captureListBox.GetItemChecked(count) == true)
            {
                pathTextBox.Text = $"체크됨";
            }
            else
            {
                index = captureListBox.SelectedIndex;
                pathTextBox.Text = $"{index} 체크안됨";
            }
            count++;
        }

        private void captureListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = captureListBox.SelectedIndex;
            string item = captureListBox.SelectedItem.ToString();
            pathTextBox.Text = $"{index}/{item}이 선택됨";
        }

        private void allSelectionButton_Click(object sender, EventArgs e)
        {
            if (allSelect == true)
            {
                for (int i = 0; i < captureListBox.Items.Count; i++)
                {
                    captureListBox.SetItemChecked(i, false);
                }
                allSelect = false;
            }
            else if (allSelect == false)
            {
                for (int i = 0; i < captureListBox.Items.Count; i++)
                {
                    captureListBox.SetItemChecked(i, true);
                }
                allSelect = true;
            }
        }

        private void pathButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                pathTextBox.Text = fbd.SelectedPath;
            }
        }
    }
}