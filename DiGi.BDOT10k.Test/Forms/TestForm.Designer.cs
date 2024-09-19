namespace DiGi.BDOT10k.Test
{
    partial class TestForm
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
            Button_Load = new Button();
            Button_Close = new Button();
            SuspendLayout();
            // 
            // Button_Load
            // 
            Button_Load.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Button_Load.Location = new Point(12, 12);
            Button_Load.Name = "Button_Load";
            Button_Load.Size = new Size(230, 29);
            Button_Load.TabIndex = 0;
            Button_Load.Text = "Load";
            Button_Load.UseVisualStyleBackColor = true;
            Button_Load.Click += Button_Load_Click;
            // 
            // Button_Close
            // 
            Button_Close.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Button_Close.Location = new Point(12, 424);
            Button_Close.Name = "Button_Close";
            Button_Close.Size = new Size(230, 29);
            Button_Close.TabIndex = 1;
            Button_Close.Text = "Close";
            Button_Close.UseVisualStyleBackColor = true;
            Button_Close.Click += Button_Close_Click;
            // 
            // TestForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(254, 465);
            Controls.Add(Button_Close);
            Controls.Add(Button_Load);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TestForm";
            Text = "BDOT10k";
            Load += TestForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button Button_Load;
        private Button Button_Close;
    }
}
