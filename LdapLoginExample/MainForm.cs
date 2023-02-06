using LdapLoginExample.Model;
using LdapLoginExample.Utilitys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LdapLoginExample
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            LdapAuthrntication ldapAuthrntication = new LdapAuthrntication(textBoxDomainPath.Text, textBoxUserName.Text, textBoxPassword.Text);
            try
            {
                if (ldapAuthrntication.IsAuthenticatedPrincipal(textBoxOu.Text))
                {
                    MessageBox.Show("Login Ok");
                }
                else
                {
                    MessageBox.Show("Login Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSearchGroupMember_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = string.Empty;
            try
            {
                LdapAuthrntication ldapAuthrntication = new LdapAuthrntication(textBoxDomainPath.Text, textBoxUserName.Text, textBoxPassword.Text);
                List<string> members = ldapAuthrntication.SearchGroupMemberPrincipal(textBoxOu.Text, textBoxGroup.Text).ToList();
                members.ForEach(c => textBoxResult.Text = textBoxResult.Text + c + Environment.NewLine);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void buttonSetToProduction_Click(object sender, EventArgs e)
        {
            textBoxDomainPath.Text = "megabank.megafg.net";
            textBoxOu.Text = "DC=megabank,DC=megafg,DC=net";
            textBoxUserName.Text = "";
            textBoxPassword.Text = "";
        }

        private void buttonSetToUat_Click(object sender, EventArgs e)
        {
            textBoxDomainPath.Text = "192.168.211.96";
            textBoxOu.Text = "DC=MEGABANKTEST4,DC=NET";
            textBoxUserName.Text = "005057";
            textBoxPassword.Text = "Mega@12341234";
        }

        private void buttonExport900Excel_Click(object sender, EventArgs e)
        {
            try
            {
                LdapAuthrntication ldapAuthrntication = new LdapAuthrntication(textBoxDomainPath.Text, textBoxUserName.Text, textBoxPassword.Text);

                OpenFileDialog openDialog = new OpenFileDialog();

                var members = ldapAuthrntication.Export900GroupMember(textBoxOu.Text, textBoxGroup.Text);
                var workbook = ExcelUtility.DictionaryToWorkBook(members);
                SaveFileDialog saveDlg = new SaveFileDialog();                
                saveDlg.Filter = "Excel files (*.xlsx)|*.xlsx";
                saveDlg.FilterIndex = 0;
                saveDlg.RestoreDirectory = true;
                saveDlg.Title = "Export Excel File To";
                if(saveDlg.ShowDialog() == DialogResult.OK)
{
                    try
                    {
                        string path = saveDlg.FileName;
                        FileStream fs = File.Create(path);
                        workbook.Write(fs);
                        workbook.Close();
                        MessageBox.Show("File is Created");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
