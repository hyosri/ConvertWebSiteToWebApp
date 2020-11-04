using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ConvertWebSiteToWebApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "Select workspace folder ";
            folderBrowserDialog1.ShowNewFolderButton = false;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFolderPath.Text = folderBrowserDialog1.SelectedPath;
            }
            folderBrowserDialog1.Dispose();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (!isValid()) return;

            try
            {
                btnRun.Enabled = false;

                DirectoryInfo directory = new DirectoryInfo(txtFolderPath.Text);

                if(chkDesignerFile.Checked)
                {
                    tslStatus.Text = "Create designer files";
                    FileInfo[] listOfDesignerFiles = directory.GetFiles("*.aspx", SearchOption.TopDirectoryOnly);
                    if(listOfDesignerFiles.Length == 0)
                    {
                        //MessageBox.Show("No aspx files exist to create designer file", "No files", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //return;
                        tslStatus.Text = "No aspx files exist to create designer file";
                    }
                    else
                    {
                        tsProgressBar.Maximum = listOfDesignerFiles.Length;
                        tsProgressBar.Value = 0;
                        CreateDesignerFiles(listOfDesignerFiles);
                    }
                }

                if(chkHandlerCodeBehind.Checked)
                {
                    tslStatus.Text = "Create Handler files";
                    FileInfo[] listOfHandlerFiles = directory.GetFiles("*.ashx", SearchOption.TopDirectoryOnly);
                    if (listOfHandlerFiles.Length == 0)
                    {
                        tslStatus.Text = "No ashx files exist to create Handler CodeBehind file";
                    }
                    else
                    {
                        tsProgressBar.Maximum = listOfHandlerFiles.Length;
                        tsProgressBar.Value = 0;
                        CreateHandlerFiles(listOfHandlerFiles);
                    }
                }
                MessageBox.Show("Coverte files complete", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnRun.Enabled = true;
                tslStatus.Text = "Complete";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private bool isValid()
        {
            if (string.IsNullOrWhiteSpace(txtFolderPath.Text))
            {
                MessageBox.Show("Please select workspace folder first","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
             
            if(!chkDesignerFile.Checked & !chkHandlerCodeBehind.Checked & !chkUpdateNamespace.Checked)
            {
                MessageBox.Show("Please select action to run", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if(chkUpdateNamespace.Checked & string.IsNullOrWhiteSpace(txtNameSpace.Text))
            {
                MessageBox.Show("Please add Namespace to update it in files", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void CreateDesignerFiles(FileInfo[] listOfFiles)
        {
            try
            {
                foreach (FileInfo designerFile in listOfFiles)
                {
                    File.Create(designerFile.FullName + ".designer.cs").Dispose();

                    if (chkUpdateNamespace.Checked)
                    {
                        List<string> fileLines = File.ReadLines(designerFile.FullName + ".cs").ToList();
                        int indx = 0;
                        for (int i = 0; i < fileLines.Count - 1; i++)
                        {
                            if (fileLines[i].StartsWith("public ", StringComparison.OrdinalIgnoreCase))
                            {
                                indx = i;
                                break;
                            }
                        }
                        fileLines.Insert(indx++, Environment.NewLine);
                        //fileLines.Insert(indx++, Environment.NewLine);
                        fileLines.Insert(indx++, "namespace " + txtNameSpace.Text + " { ");
                        fileLines.Insert(indx, Environment.NewLine);
                        fileLines.Add("}");

                        File.WriteAllLines(designerFile.FullName + ".cs", fileLines);

                        
                    }
                        tsProgressBar.Increment(1);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void CreateHandlerFiles(FileInfo[] listOfFiles)
        {
            try
            {
                foreach (FileInfo handlerFile in listOfFiles)
                {
                    FileStream newFile = File.Create(handlerFile.FullName + ".cs");
                    StreamReader oldFile = new StreamReader(handlerFile.FullName,true);

                    //Read from old file
                    string strHeader = oldFile.ReadLine();
                    if(!strHeader.EndsWith("%>"))
                        strHeader += oldFile.ReadLine();

                    string codeTxt = oldFile.ReadToEnd();
                    oldFile.Close();
                    oldFile.Dispose();

                    //write to new file
                    StreamWriter swNewFile = new StreamWriter(newFile);
                    swNewFile.Write(codeTxt);
                    swNewFile.Flush();
                    swNewFile.Close();
                    swNewFile.Dispose();

                    //Add namespace 
                    if(chkUpdateNamespace.Checked)
                    {                      
                        strHeader = strHeader.Replace(Path.GetFileNameWithoutExtension(handlerFile.Name), txtNameSpace.Text + "." + Path.GetFileNameWithoutExtension(handlerFile.Name));

                        List<string> fileLines = File.ReadLines(newFile.Name).ToList();
                        int indx = 0;
                        for (int i = 0; i < fileLines.Count -1; i++)
                        {
                            if (fileLines[i].StartsWith("public class", StringComparison.OrdinalIgnoreCase))
                            {
                                indx = i;
                                break;
                            }
                        }
                        fileLines.Insert(indx++, Environment.NewLine);
                        //fileLines.Insert(indx++, Environment.NewLine);
                        fileLines.Insert(indx++, "namespace " + txtNameSpace.Text + " { ");
                        fileLines.Insert(indx, Environment.NewLine);
                        fileLines.Add("}");

                        File.WriteAllLines(newFile.Name, fileLines);
                    }

                    //Modify oldFile
                    strHeader = strHeader.Replace("%>", "CodeBehind=\"" + handlerFile.Name + ".cs" + "\" %>");
                    File.WriteAllText(handlerFile.FullName, strHeader);
                    tsProgressBar.Increment(1);
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
