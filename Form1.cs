using System.Collections;
using System.Drawing.Text;

namespace ScreenShot
{
    public partial class Form1 : Form
    {
        private int count = 0;
        private int nnnn = 0;
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
            
            //
            this.captureListBox.Items.AddRange(new object[] {$"테스트{count}"});
            count++;
        }
    }
}