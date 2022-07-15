namespace Extractbase64
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
            this.txt_base_64 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_rigths = new System.Windows.Forms.Label();
            this.cbb_extension = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txt_base_64
            // 
            this.txt_base_64.Location = new System.Drawing.Point(103, 134);
            this.txt_base_64.Multiline = true;
            this.txt_base_64.Name = "txt_base_64";
            this.txt_base_64.Size = new System.Drawing.Size(671, 307);
            this.txt_base_64.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Insert base64:";
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(687, 509);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(87, 30);
            this.btn_submit.TabIndex = 2;
            this.btn_submit.Text = "Convertir";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Extensión:";
            // 
            // txt_rigths
            // 
            this.txt_rigths.AutoSize = true;
            this.txt_rigths.Location = new System.Drawing.Point(351, 575);
            this.txt_rigths.Name = "txt_rigths";
            this.txt_rigths.Size = new System.Drawing.Size(0, 15);
            this.txt_rigths.TabIndex = 5;
            // 
            // cbb_extension
            // 
            this.cbb_extension.FormattingEnabled = true;
            this.cbb_extension.Items.AddRange(new object[] {
            "xml",
            "pfx"});
            this.cbb_extension.Location = new System.Drawing.Point(103, 79);
            this.cbb_extension.Name = "cbb_extension";
            this.cbb_extension.Size = new System.Drawing.Size(121, 23);
            this.cbb_extension.TabIndex = 6;
            this.cbb_extension.Text = "xml";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(864, 599);
            this.Controls.Add(this.cbb_extension);
            this.Controls.Add(this.txt_rigths);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_base_64);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fredickzen-Base64Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_base_64;
        private Label label1;
        private Button btn_submit;
        private Label label2;
        private Label txt_rigths;
        private ComboBox cbb_extension;
    }
}