using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcuator
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void FormAbout_Load(object sender, EventArgs e)
        {
            this.Text = "About " + Language.String1;
            Assembly assembly = Assembly.GetExecutingAssembly();
            AssemblyFileVersionAttribute assemblyFileVersion = assembly.GetCustomAttributes(typeof(AssemblyFileVersionAttribute), false)[0] as AssemblyFileVersionAttribute;
            labelVersion.Text = Language.String4 + ": " + assemblyFileVersion.Version;
            label3.Text = Language.String5;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Unable to open link that was clicked.\n{0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VisitLink()
        {
            // Change the color of the link text by setting LinkVisited
            // to true.
            linkLabelIcons8.LinkVisited = true;
            //Call the Process.Start method to open the default browser
            //with a URL:
            System.Diagnostics.Process.Start(linkLabelIcons8.Text);
        }

        private void linkLabelUserManual_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabelIcons8.LinkVisited = true;
            //Call the Process.Start method to open the default browser
            //with a URL:
            System.Diagnostics.Process.Start("https://docs.google.com/presentation/d/e/2PACX-1vQFQd_GLChGOqMZx6PO-gvfr_k9IBicCub3yh76MWTAVCtXpdwLAv695t0TEy5vIELzXWtCaJBY7XGb/pub?start=false&loop=false&delayms=3000");
        }
    }
 }

