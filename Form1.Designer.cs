namespace FreezingCounter
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
            this.labelKeystroke = new System.Windows.Forms.Label();
            this.labelKeyInput = new System.Windows.Forms.Label();
            this.labelStartStop = new System.Windows.Forms.Label();
            this.labelFreezing = new System.Windows.Forms.Label();
            this.labelTotalFreezing = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelKeystroke
            // 
            this.labelKeystroke.AutoSize = true;
            this.labelKeystroke.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKeystroke.Location = new System.Drawing.Point(61, 40);
            this.labelKeystroke.Name = "labelKeystroke";
            this.labelKeystroke.Size = new System.Drawing.Size(126, 29);
            this.labelKeystroke.TabIndex = 0;
            this.labelKeystroke.Text = "Keystroke:";
            this.labelKeystroke.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelKeyInput
            // 
            this.labelKeyInput.AutoSize = true;
            this.labelKeyInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKeyInput.Location = new System.Drawing.Point(196, 40);
            this.labelKeyInput.Name = "labelKeyInput";
            this.labelKeyInput.Size = new System.Drawing.Size(21, 29);
            this.labelKeyInput.TabIndex = 1;
            this.labelKeyInput.Text = "-";
            // 
            // labelStartStop
            // 
            this.labelStartStop.AutoSize = true;
            this.labelStartStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartStop.Location = new System.Drawing.Point(196, 99);
            this.labelStartStop.Name = "labelStartStop";
            this.labelStartStop.Size = new System.Drawing.Size(37, 29);
            this.labelStartStop.TabIndex = 2;
            this.labelStartStop.Text = "---";
            this.labelStartStop.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelFreezing
            // 
            this.labelFreezing.AutoSize = true;
            this.labelFreezing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFreezing.Location = new System.Drawing.Point(196, 158);
            this.labelFreezing.Name = "labelFreezing";
            this.labelFreezing.Size = new System.Drawing.Size(37, 29);
            this.labelFreezing.TabIndex = 3;
            this.labelFreezing.Text = "---";
            this.labelFreezing.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelTotalFreezing
            // 
            this.labelTotalFreezing.AutoSize = true;
            this.labelTotalFreezing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalFreezing.Location = new System.Drawing.Point(196, 217);
            this.labelTotalFreezing.Name = "labelTotalFreezing";
            this.labelTotalFreezing.Size = new System.Drawing.Size(37, 29);
            this.labelTotalFreezing.TabIndex = 4;
            this.labelTotalFreezing.Text = "---";
            this.labelTotalFreezing.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Start/Stop:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Freeze (msec):";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Freezing (%):";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTotalFreezing);
            this.Controls.Add(this.labelFreezing);
            this.Controls.Add(this.labelStartStop);
            this.Controls.Add(this.labelKeyInput);
            this.Controls.Add(this.labelKeystroke);
            this.Name = "Form1";
            this.Text = "Freezing Counter";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKeystroke;
        private System.Windows.Forms.Label labelKeyInput;
        private System.Windows.Forms.Label labelStartStop;
        private System.Windows.Forms.Label labelFreezing;
        private System.Windows.Forms.Label labelTotalFreezing;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

