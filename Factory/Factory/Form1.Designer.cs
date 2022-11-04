
namespace Factory
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.mainPanel = new System.Windows.Forms.Panel();
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.btnSelect_Car = new System.Windows.Forms.Button();
            this.btnSelect_Ball = new System.Windows.Forms.Button();
            this.lblNext = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createTimer
            // 
            this.createTimer.Enabled = true;
            this.createTimer.Interval = 3000;
            this.createTimer.Tick += new System.EventHandler(this.createTimer_Tick_1);
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(0, 216);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(800, 100);
            this.mainPanel.TabIndex = 0;
            // 
            // conveyorTimer
            // 
            this.conveyorTimer.Enabled = true;
            this.conveyorTimer.Interval = 10;
            this.conveyorTimer.Tick += new System.EventHandler(this.conveyorTimer_Tick);
            // 
            // btnSelect_Car
            // 
            this.btnSelect_Car.Location = new System.Drawing.Point(25, 22);
            this.btnSelect_Car.Name = "btnSelect_Car";
            this.btnSelect_Car.Size = new System.Drawing.Size(75, 23);
            this.btnSelect_Car.TabIndex = 1;
            this.btnSelect_Car.Text = "Car";
            this.btnSelect_Car.UseVisualStyleBackColor = true;
            this.btnSelect_Car.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSelect_Ball
            // 
            this.btnSelect_Ball.Location = new System.Drawing.Point(126, 22);
            this.btnSelect_Ball.Name = "btnSelect_Ball";
            this.btnSelect_Ball.Size = new System.Drawing.Size(75, 23);
            this.btnSelect_Ball.TabIndex = 2;
            this.btnSelect_Ball.Text = "Ball";
            this.btnSelect_Ball.UseVisualStyleBackColor = true;
            this.btnSelect_Ball.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblNext
            // 
            this.lblNext.AutoSize = true;
            this.lblNext.Location = new System.Drawing.Point(285, 27);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(70, 13);
            this.lblNext.TabIndex = 3;
            this.lblNext.Text = "Coming Next:";
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(126, 52);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(75, 23);
            this.btnColor.TabIndex = 4;
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.lblNext);
            this.Controls.Add(this.btnSelect_Ball);
            this.Controls.Add(this.btnSelect_Car);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer createTimer;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Button btnSelect_Car;
        private System.Windows.Forms.Button btnSelect_Ball;
        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.Button btnColor;
    }
}

