namespace WinFormsApp5
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
            btnRefill = new Button();
            txtInfo = new RichTextBox();
            txtOut = new RichTextBox();
            btnGet = new Button();
            picCat = new PictureBox();
            picDog = new PictureBox();
            picCow = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picCat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDog).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCow).BeginInit();
            SuspendLayout();
            // 
            // btnRefill
            // 
            btnRefill.Location = new Point(9, 3);
            btnRefill.Name = "btnRefill";
            btnRefill.Size = new Size(360, 29);
            btnRefill.TabIndex = 0;
            btnRefill.Text = "Перезаполнить";
            btnRefill.UseVisualStyleBackColor = true;
            btnRefill.Click += btnRefill_Click;
            // 
            // txtInfo
            // 
            txtInfo.BorderStyle = BorderStyle.None;
            txtInfo.Location = new Point(9, 38);
            txtInfo.Name = "txtInfo";
            txtInfo.ReadOnly = true;
            txtInfo.Size = new Size(253, 111);
            txtInfo.TabIndex = 1;
            txtInfo.Text = "";
            // 
            // txtOut
            // 
            txtOut.Location = new Point(9, 155);
            txtOut.Name = "txtOut";
            txtOut.Size = new Size(185, 120);
            txtOut.TabIndex = 2;
            txtOut.Text = "";
            // 
            // btnGet
            // 
            btnGet.Location = new Point(200, 155);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(163, 120);
            btnGet.TabIndex = 3;
            btnGet.Text = "Взять";
            btnGet.UseVisualStyleBackColor = true;
            btnGet.Click += btnGet_Click;
            // 
            // picCat
            // 
            picCat.Image = Properties.Resources.cat;
            picCat.InitialImage = (Image)resources.GetObject("picCat.InitialImage");
            picCat.Location = new Point(268, 40);
            picCat.Name = "picCat";
            picCat.Size = new Size(101, 100);
            picCat.TabIndex = 4;
            picCat.TabStop = false;
            picCat.Visible = false;
            // 
            // picDog
            // 
            picDog.Image = Properties.Resources.dog;
            picDog.InitialImage = (Image)resources.GetObject("picDog.InitialImage");
            picDog.Location = new Point(270, 40);
            picDog.Name = "picDog";
            picDog.Size = new Size(101, 100);
            picDog.TabIndex = 5;
            picDog.TabStop = false;
            picDog.Visible = false;
            // 
            // picCow
            // 
            picCow.Image = Properties.Resources.cow;
            picCow.InitialImage = (Image)resources.GetObject("picCow.InitialImage");
            picCow.Location = new Point(270, 40);
            picCow.Name = "picCow";
            picCow.Size = new Size(99, 100);
            picCow.TabIndex = 6;
            picCow.TabStop = false;
            picCow.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 287);
            Controls.Add(picCow);
            Controls.Add(picDog);
            Controls.Add(picCat);
            Controls.Add(btnGet);
            Controls.Add(txtOut);
            Controls.Add(txtInfo);
            Controls.Add(btnRefill);
            Name = "Form1";
            Text = "Автомат с животными";
            ((System.ComponentModel.ISupportInitialize)picCat).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDog).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCow).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRefill;
        private RichTextBox txtInfo;
        private RichTextBox txtOut;
        private Button btnGet;
        private PictureBox picCat;
        private PictureBox picDog;
        private PictureBox picCow;
    }
}