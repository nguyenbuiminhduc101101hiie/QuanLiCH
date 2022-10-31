using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiCH.DTO_1;

namespace QuanLiCH
{
    public partial class frmAdmin : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
       

        public frmAdmin(DTO_1.Account loginAccount)
        {
            InitializeComponent();
            random = new Random();
            btnCloseChillForm.Enabled = false;
            this.ControlBox = false;
        }
        //[DllImport("user32.DLL", EntryPoint = "ReleaseCapure")]
        //private extern static void ReleaseCapure();

        //[DllImport("user32.DLL", EntryPoint = "SendMessage")]
        //private extern static void SendMessage(System.IntPtr hwnd,int wMsg,int wParam,int lParam);

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while(tempIndex == index)
            {
              index=  random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if(btnSender != null)
            {
                if(currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor=Color.White;
                    currentButton.Font= new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    pnTitleBar.BackColor = color;
                    pnLogo.BackColor = ThemeColor.ChangeColorBrightness(color,-0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryyColor = ThemeColor.ChangeColorBrightness(color,-0.3);
                    btnCloseChillForm.Enabled = true;
                }    
            }    
        }
        private void DisableButton()
        {
            foreach(Control previousBtn in pnMenu.Controls)
                {
                if(previousBtn.GetType()==typeof(Button))
                {
                    previousBtn.BackColor=Color.FromArgb(135,206,250);
                    previousBtn.ForeColor=Color.Gainsboro;
                    previousBtn.Font= new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }    
            }
        }
        private void OpenChildForm(Form childForm,object btnSender)
        {
            if(activeForm != null)
            {
                 activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel=false;
            childForm.FormBorderStyle = FormBorderStyle.None;  
            childForm.Dock = DockStyle.Fill;
            this.pnDesktopPane.Controls.Add(childForm);
            this.pnDesktopPane.Tag = childForm;
            childForm.BringToFront();
            try
            {
                childForm.Show();
            }
            catch { }
            lbTitleBar.Text = childForm.Text;
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Admin.frmBill(), sender);
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Admin.frmFood(), sender);
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Admin.frmCategory(), sender);
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Admin.frmAccount(), sender);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnCloseChillForm_Click(object sender, EventArgs e)
        {
            if(activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void Reset()
        {
           DisableButton();
            lbTitleBar.Text ="HOME" ;
            pnTitleBar.BackColor = Color.FromArgb(0,150,136);
            pnLogo.BackColor = Color.FromArgb(39,39,58);
            currentButton=null;
            btnCloseChillForm.Enabled = false;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                this.WindowState=FormWindowState.Maximized;
            }    
            else
            {
                this.WindowState=FormWindowState.Normal;
            }    

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lbHello.Left += 10;
        }

        private void lbHello_Click(object sender, EventArgs e)
        {

        }

        private void pnTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
