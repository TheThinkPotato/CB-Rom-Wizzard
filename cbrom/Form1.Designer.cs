namespace cbrom
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonAddBios = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxRoms = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonMakeNew = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(620, 34);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(347, 139);
            this.listBox1.TabIndex = 0;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(705, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selected Microcode Roms to Add";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "NCPU_MicroCode";
            this.openFileDialog1.InitialDirectory = ".\\";
            // 
            // buttonAddBios
            // 
            this.buttonAddBios.Location = new System.Drawing.Point(61, 48);
            this.buttonAddBios.Name = "buttonAddBios";
            this.buttonAddBios.Size = new System.Drawing.Size(125, 24);
            this.buttonAddBios.TabIndex = 2;
            this.buttonAddBios.Text = "Add Original Bios";
            this.buttonAddBios.UseVisualStyleBackColor = true;
            this.buttonAddBios.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Microcode Patch Roms";
            // 
            // listBoxRoms
            // 
            this.listBoxRoms.FormattingEnabled = true;
            this.listBoxRoms.ItemHeight = 15;
            this.listBoxRoms.Location = new System.Drawing.Point(247, 34);
            this.listBoxRoms.Name = "listBoxRoms";
            this.listBoxRoms.Size = new System.Drawing.Size(347, 139);
            this.listBoxRoms.TabIndex = 3;
            this.listBoxRoms.SelectedIndexChanged += new System.EventHandler(this.listBoxRoms_SelectedIndexChanged);
            this.listBoxRoms.DoubleClick += new System.EventHandler(this.listBoxRoms_DoubleClick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 196);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(477, 456);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // buttonMakeNew
            // 
            this.buttonMakeNew.Location = new System.Drawing.Point(61, 89);
            this.buttonMakeNew.Name = "buttonMakeNew";
            this.buttonMakeNew.Size = new System.Drawing.Size(125, 24);
            this.buttonMakeNew.TabIndex = 8;
            this.buttonMakeNew.Text = "Make New Bios";
            this.buttonMakeNew.UseVisualStyleBackColor = true;
            this.buttonMakeNew.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Orignal Bios Microcode Patches";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(652, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "New Bios Microcode Patches";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(496, 196);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(477, 456);
            this.richTextBox2.TabIndex = 10;
            this.richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(13, 675);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(960, 159);
            this.richTextBox3.TabIndex = 12;
            this.richTextBox3.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 658);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Log";
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(61, 132);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(125, 24);
            this.buttonOpen.TabIndex = 14;
            this.buttonOpen.Text = "Open Folder";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 846);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonMakeNew);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxRoms);
            this.Controls.Add(this.buttonAddBios);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CB Rom Wizzard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonAddBios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxRoms;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonMakeNew;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonOpen;
    }
}
