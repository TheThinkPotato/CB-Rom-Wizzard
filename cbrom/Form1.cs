using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace cbrom
{
    public partial class Form1 : Form
    {

        public string originalFile = string.Empty;
        public string [] romMicroCodeFiles = null;
        public static string currentFolder = Directory.GetCurrentDirectory();
        public static string currentFile = string.Empty;
        const string romReadExec = @"Bin\intelmicrocodelist.exe";
        const string newBiosFileName = "new-bios.bin";
        const string romWriteExec = @"Bin\CBROM32_195.exe";
        public string newBiosFldr = currentFolder + @"\New Bios";

        public Form1()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox3.Text += "Opened: " + openFileDialog1.FileName + "\n";
                currentFile = openFileDialog1.FileName;

                richTextBox1.Text = readRom(currentFile);               


                //string cmdExec = "/c " + currentFolder + @"\" + romExec + @" " + currentFile;// + @" " + romOut;


                //var p = new Process();                
                //p.StartInfo.UseShellExecute = false; 
                //p.StartInfo.RedirectStandardOutput = true;
                //string eOut = null;
                //p.ErrorDataReceived += new DataReceivedEventHandler((sender, e) =>
                //{ eOut += e.Data; });
                //p.StartInfo.RedirectStandardError = true;
                //p.StartInfo.RedirectStandardInput = true;

                //p.StartInfo.FileName = currentFolder + @"\" + romExec;                
                //p.StartInfo.Arguments = currentFile;

                //p.Start();
                //p.StandardInput.Write(p.StandardInput.NewLine);
                //p.StandardInput.Write(p.StandardInput.NewLine);
                //p.StandardInput.Write(p.StandardInput.NewLine);


                //string output = p.StandardOutput.ReadToEnd();


                //p.WaitForExit();

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Browse Bios Roms files";
            openFileDialog1.DefaultExt = "BIN";
            openFileDialog1.Filter = "bin files (*.bin)|*.txt|rom files (*.rom)|*.rom|bios files (*.f*)|*.f*|All files (*.*)|*.*";
            openFileDialog1.FileName = "*";

            listBoxRoms.Items.Clear();


            //foreach (var item in Directory.GetFiles(@"C:\Users\Dan\OneDrive\Documents\repos\cbrom\cbrom\bin\Debug\netcoreapp3.1\microcode", "*.bin"))
            foreach (var item in Directory.GetFiles(currentFolder + @"\microcode", "*.bin"))
            {
                
                listBoxRoms.Items.Add(item.ToString().Replace(currentFolder+@"\microcode\",""));
            }
        }

        static public void getRoms(ref string[] roms)
        {
            int i = 0;
            foreach (var item in Directory.GetFiles(@".\microcode", "*.bin"))
            {                
                roms[i] = item.ToString();
                i++;
            }
        }

        private void listBoxRoms_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listBoxRoms_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxRoms.Items.Count > 0 & listBoxRoms.SelectedIndex >=0)
            {
                
                if(listBox1.Items.Count > 0)
                {
                    MessageBox.Show("Only one rom only can be used.", "Selection Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                { 
                listBox1.Items.Add(listBoxRoms.Items[listBoxRoms.SelectedIndex].ToString());
                listBoxRoms.Items.Remove(listBoxRoms.SelectedItem.ToString());
                }
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0 & listBox1.SelectedIndex >= 0)
            {
                listBoxRoms.Items.Add(listBox1.Items[listBox1.SelectedIndex].ToString());
                listBox1.Items.Remove(listBox1.SelectedItem.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (listBox1.Items.Count == 1 & openFileDialog1.FileName != "*")
            {
                string ncpuRom = currentFolder + @"\NCPUCODE.BIN";


                System.IO.File.Copy(currentFile, currentFolder + @"\" + newBiosFileName, true);
                //MessageBox.Show(currentFolder + @"\microcode\" + listBox1.Items[0]);
                System.IO.File.Copy(currentFolder + @"\microcode\" + listBox1.Items[0], ncpuRom, true);
                var attr = File.GetAttributes(ncpuRom);

                attr = attr | FileAttributes.ReadOnly;
                File.SetAttributes(ncpuRom, attr);

                //ProcessStartInfo p = new ProcessStartInfo(@"Bin\CBROM32_195.exe", newBiosFileName +@" /d");
                //Process process = Process.Start(p);

                richTextBox3.Text += "\n\n" + RomWrite();

                attr = attr & ~FileAttributes.ReadOnly;
                File.SetAttributes(ncpuRom, attr);

                richTextBox2.Text = readRom(currentFolder + @"\" + newBiosFileName);

                richTextBox3.AppendText("\n\n==============================\n" + "Lines Rom1: " + richTextBox1.Lines.Count().ToString() +
                    "\nLines Rom2: " + richTextBox2.Lines.Count().ToString() + "\n==============================\n");



                try
                {
                    System.IO.File.Move(currentFolder + @"\" + newBiosFileName, newBiosFldr + @"\" + newBiosFileName, true);
                }
                catch (Exception)
                {
                    MessageBox.Show("Unable to move new new bios file to destination.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


                richTextBox3.Focus();
                richTextBox3.ScrollToCaret();
            }
            else if (openFileDialog1.FileName == "*")
            { 
                MessageBox.Show("Please open an original bios rom.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Please add a microcode patch rom.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Make a new copy of current bios
            // copy file needed to add to biod rom (NCPUCODE.BIN)
            // make NCPUCODE.BIN  readonly
            // execute cbrom195 "Your Bios".bin /d
        }

        private static string RomWrite()
        {

            var ProcessMicrocodeList = new Process();
            ProcessMicrocodeList.StartInfo.UseShellExecute = false;
            
            string eOut = null;
            ProcessMicrocodeList.ErrorDataReceived += new DataReceivedEventHandler((sender, e) =>
            { eOut += e.Data; });
            ProcessMicrocodeList.StartInfo.RedirectStandardOutput = true;
            ProcessMicrocodeList.StartInfo.RedirectStandardError = true;
            ProcessMicrocodeList.StartInfo.RedirectStandardInput = true;

            ProcessMicrocodeList.StartInfo.FileName = currentFolder + @"\" + romWriteExec;
            ProcessMicrocodeList.StartInfo.Arguments = newBiosFileName + " /nc_cpucode ncpucode.bin";

            ProcessMicrocodeList.Start();            

            string output = "\n\n"+ProcessMicrocodeList.StandardOutput.ReadToEnd();

            ProcessMicrocodeList.WaitForExit();
            ProcessMicrocodeList.Close();
            ProcessMicrocodeList.Dispose();

            return output;
        }

        private static string readRom(string fileName)
        {          

            var ProcessMicrocodeList = new Process();
            ProcessMicrocodeList.StartInfo.UseShellExecute = false;
            
            string eOut = null;
            ProcessMicrocodeList.ErrorDataReceived += new DataReceivedEventHandler((sender, e) =>
            { eOut += e.Data; });
            ProcessMicrocodeList.StartInfo.RedirectStandardOutput = true;
            ProcessMicrocodeList.StartInfo.RedirectStandardError = true;
            ProcessMicrocodeList.StartInfo.RedirectStandardInput = true;

            ProcessMicrocodeList.StartInfo.FileName = currentFolder + @"\" + romReadExec;       
            ProcessMicrocodeList.StartInfo.Arguments = fileName;

            ProcessMicrocodeList.Start();


            //ProcessMicrocodeList.StandardInput.WriteLine("aa");                      
            //ProcessMicrocodeList.StandardInput.Write(ProcessMicrocodeList.StandardInput.NewLine);

            string output = ProcessMicrocodeList.StandardOutput.ReadToEnd();

            ProcessMicrocodeList.WaitForExit();
            ProcessMicrocodeList.Close();
            ProcessMicrocodeList.Dispose();

            return output;
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", newBiosFldr);            
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
                MessageBox.Show("CB Rom wizzard has been made by the OFFbit Tech\nAKA TheThinkPotatoe.\n\nPlease use this software at your own risk. We hold no responsability if it causes you damage.\n\nVersion 1.0a", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            button4_Click(sender, e);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            buttonOpen_Click(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
