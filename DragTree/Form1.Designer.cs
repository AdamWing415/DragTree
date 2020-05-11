namespace DragTree
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
            this.reactionLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.startbutton = new System.Windows.Forms.Button();
            this.GOButton = new System.Windows.Forms.Button();
            this.topYellow = new System.Windows.Forms.Label();
            this.midYellow = new System.Windows.Forms.Label();
            this.bottomYellow = new System.Windows.Forms.Label();
            this.green = new System.Windows.Forms.Label();
            this.lightTimer = new System.Windows.Forms.Timer(this.components);
            this.blockLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reactionLabel
            // 
            this.reactionLabel.BackColor = System.Drawing.Color.Gray;
            this.reactionLabel.Font = new System.Drawing.Font("Swis721 BlkEx BT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reactionLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reactionLabel.Location = new System.Drawing.Point(296, 70);
            this.reactionLabel.Name = "reactionLabel";
            this.reactionLabel.Size = new System.Drawing.Size(201, 33);
            this.reactionLabel.TabIndex = 0;
            this.reactionLabel.Text = "Reaction: ";
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.resetButton.Font = new System.Drawing.Font("Swis721 Blk BT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resetButton.Location = new System.Drawing.Point(300, 177);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(185, 61);
            this.resetButton.TabIndex = 1;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.BackColor = System.Drawing.Color.Gray;
            this.timeLabel.Font = new System.Drawing.Font("Swis721 BlkEx BT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.timeLabel.Location = new System.Drawing.Point(296, 103);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(201, 40);
            this.timeLabel.TabIndex = 2;
            this.timeLabel.Text = "0.000";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startbutton
            // 
            this.startbutton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.startbutton.Font = new System.Drawing.Font("Swis721 Blk BT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.startbutton.Location = new System.Drawing.Point(300, 244);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(185, 61);
            this.startbutton.TabIndex = 3;
            this.startbutton.Text = "Start";
            this.startbutton.UseVisualStyleBackColor = false;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // GOButton
            // 
            this.GOButton.BackColor = System.Drawing.Color.LimeGreen;
            this.GOButton.Font = new System.Drawing.Font("Swis721 Blk BT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GOButton.ForeColor = System.Drawing.Color.White;
            this.GOButton.Location = new System.Drawing.Point(300, 311);
            this.GOButton.Name = "GOButton";
            this.GOButton.Size = new System.Drawing.Size(185, 61);
            this.GOButton.TabIndex = 4;
            this.GOButton.Text = "GO!";
            this.GOButton.UseVisualStyleBackColor = false;
            this.GOButton.Click += new System.EventHandler(this.GOButton_Click);
            // 
            // topYellow
            // 
            this.topYellow.BackColor = System.Drawing.Color.DimGray;
            this.topYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topYellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.topYellow.Location = new System.Drawing.Point(46, 51);
            this.topYellow.Name = "topYellow";
            this.topYellow.Size = new System.Drawing.Size(212, 70);
            this.topYellow.TabIndex = 6;
            // 
            // midYellow
            // 
            this.midYellow.BackColor = System.Drawing.Color.DimGray;
            this.midYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.midYellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.midYellow.Location = new System.Drawing.Point(46, 143);
            this.midYellow.Name = "midYellow";
            this.midYellow.Size = new System.Drawing.Size(212, 70);
            this.midYellow.TabIndex = 8;
            // 
            // bottomYellow
            // 
            this.bottomYellow.BackColor = System.Drawing.Color.DimGray;
            this.bottomYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bottomYellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bottomYellow.Location = new System.Drawing.Point(46, 236);
            this.bottomYellow.Name = "bottomYellow";
            this.bottomYellow.Size = new System.Drawing.Size(212, 70);
            this.bottomYellow.TabIndex = 10;
            // 
            // green
            // 
            this.green.BackColor = System.Drawing.Color.DimGray;
            this.green.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.green.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.green.Location = new System.Drawing.Point(46, 332);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(212, 70);
            this.green.TabIndex = 12;
            // 
            // lightTimer
            // 
            this.lightTimer.Interval = 400;
            this.lightTimer.Tick += new System.EventHandler(this.lightTimer_Tick);
            // 
            // blockLabel
            // 
            this.blockLabel.BackColor = System.Drawing.Color.Gray;
            this.blockLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blockLabel.Location = new System.Drawing.Point(116, -19);
            this.blockLabel.Name = "blockLabel";
            this.blockLabel.Size = new System.Drawing.Size(71, 483);
            this.blockLabel.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(521, 473);
            this.Controls.Add(this.blockLabel);
            this.Controls.Add(this.green);
            this.Controls.Add(this.bottomYellow);
            this.Controls.Add(this.midYellow);
            this.Controls.Add(this.topYellow);
            this.Controls.Add(this.GOButton);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.reactionLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label reactionLabel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.Button GOButton;
        private System.Windows.Forms.Label topYellow;
        private System.Windows.Forms.Label midYellow;
        private System.Windows.Forms.Label bottomYellow;
        private System.Windows.Forms.Label green;
        private System.Windows.Forms.Timer lightTimer;
        private System.Windows.Forms.Label blockLabel;
    }
}

